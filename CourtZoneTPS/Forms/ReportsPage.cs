using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CourtZoneTPS.Services;
namespace CourtZoneTPS;

public partial class ReportsPage : UserControl
{
    private readonly ReservationService _service;

    // fixed employee user ids you gave
    private const int Employee1UserId = 1;
    private const int Employee2UserId = 2;

    public ReportsPage()
    {
        InitializeComponent();
        _service = new ReservationService();

        // Ensure combo box contains options (if designer didn't set them)
        if (comboBoxDateRange.Items.Count == 0)
        {
            comboBoxDateRange.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly", "Yearly", "All" });
            comboBoxDateRange.SelectedIndex = 0;
        }

        // Wire generate button
        buttonGenerateReport.Click -= buttonGenerate_Click;
        buttonGenerateReport.Click += buttonGenerate_Click;

        // Optionally pre-build grids
        EnsureSportGridColumns(dataGridViewBasketball);
        EnsureSportGridColumns(dataGridViewVolleyball);
        EnsureSportGridColumns(dataGridViewBadminton);
        EnsureSportGridColumns(dataGridViewTennis);
        EnsureSummaryGridColumns(dataGridViewSports);
    }

    // Generate clicked: compute range based on Today and selected range
    private void buttonGenerate_Click(object sender, EventArgs e)
    {
        if (comboBoxDateRange.SelectedIndex == -1)
        {
            MessageBox.Show("Please select a report range (Daily / Weekly / Monthly / Yearly / All).", "Select Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string range = comboBoxDateRange.SelectedItem.ToString();
        (DateTime from, DateTime to) = ComputeRangeUsingToday(range);

        LoadIncomeReport(from, to);
    }

    // Compute range using DateTime.Today because you said there's no date picker
    private (DateTime from, DateTime to) ComputeRangeUsingToday(string rangeType)
    {
        DateTime today = DateTime.Today;

        switch (rangeType)
        {
            case "Daily":
                return (today, today);

            case "Weekly":
                // Monday as start
                int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
                DateTime monday = today.AddDays(-diff).Date;
                DateTime sunday = monday.AddDays(6).Date;
                return (monday, sunday);

            case "Monthly":
                DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
                return (startOfMonth, endOfMonth);

            case "Yearly":
                DateTime startOfYear = new DateTime(today.Year, 1, 1);
                DateTime endOfYear = new DateTime(today.Year, 12, 31);
                return (startOfYear, endOfYear);

            case "All":
                // Use safe extremes for your DB text dates
                return (new DateTime(1900, 1, 1), new DateTime(9999, 12, 31));

            default:
                return (today, today);
        }
    }

    // Main loader that fills grids and labels
    private void LoadIncomeReport(DateTime from, DateTime to)
    {
        try
        {
            // 1) get sport × court sums
            var rows = _service.GetSumsBySportAndCourt(from, to);

            // prepare matrix for known sports and courts
            string[] sports = new[] { "Basketball", "Volleyball", "Badminton", "Tennis" };
            string[] courts = new[] { "Open Court", "Covered Court", "Airconditioned Court" };

            var matrix = new Dictionary<string, Dictionary<string, decimal>>(StringComparer.OrdinalIgnoreCase);
            foreach (var s in sports)
            {
                matrix[s] = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);
                foreach (var c in courts) matrix[s][c] = 0m;
            }

            // fill results
            foreach (var r in rows)
            {
                if (string.IsNullOrWhiteSpace(r.SportsType) || string.IsNullOrWhiteSpace(r.CourtType)) continue;

                if (!matrix.ContainsKey(r.SportsType))
                {
                    matrix[r.SportsType] = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase);
                    foreach (var c in courts) matrix[r.SportsType][c] = 0m;
                }

                if (!matrix[r.SportsType].ContainsKey(r.CourtType))
                    matrix[r.SportsType][r.CourtType] = 0m;

                matrix[r.SportsType][r.CourtType] += r.Total;
            }

            // 2) Ensure grids have columns and fill them
            EnsureSportGridColumns(dataGridViewBasketball);
            EnsureSportGridColumns(dataGridViewVolleyball);
            EnsureSportGridColumns(dataGridViewBadminton);
            EnsureSportGridColumns(dataGridViewTennis);
            EnsureSummaryGridColumns(dataGridViewSports);

            FillSportGrid("Basketball", dataGridViewBasketball, matrix);
            FillSportGrid("Volleyball", dataGridViewVolleyball, matrix);
            FillSportGrid("Badminton", dataGridViewBadminton, matrix);
            FillSportGrid("Tennis", dataGridViewTennis, matrix);

            // 3) Summary by sport
            dataGridViewSports.Rows.Clear();
            var totalsBySport = _service.GetTotalBySport(from, to);
            decimal grand = 0m;
            foreach (var kv in totalsBySport.OrderBy(k => k.Key))
            {
                dataGridViewSports.Rows.Add(kv.Key, kv.Value.ToString("N2"));
                grand += kv.Value;
            }

            // 4) Court totals
            var courtTotals = _service.GetTotalByCourtType(from, to);
            decimal openTotal = courtTotals.ContainsKey("Open Court") ? courtTotals["Open Court"] : 0m;
            decimal coveredTotal = courtTotals.ContainsKey("Covered Court") ? courtTotals["Covered Court"] : 0m;
            decimal acTotal = courtTotals.ContainsKey("Airconditioned Court") ? courtTotals["Airconditioned Court"] : 0m;

            labelOpenCourtIncome.Text = openTotal.ToString("N2");
            labelCoveredCourtIncome.Text = coveredTotal.ToString("N2");
            labelAirconditionedCourtIncome.Text = acTotal.ToString("N2");

            // 5) Employee incomes (fixed users 1 and 2)
            var empList = _service.GetIncomeByEmployee(from, to);

            var e1 = empList.FirstOrDefault(x => x.UserId == Employee1UserId);
            var e2 = empList.FirstOrDefault(x => x.UserId == Employee2UserId);

            emplloyee1Income.Text = (e1.UserId != 0)
                ? $"{(string.IsNullOrEmpty(e1.EmployeeNumber) ? "Employee 1" : e1.EmployeeNumber)}: {e1.Total.ToString("N2")}"
                : "N/A";

            employee2Income.Text = (e2.UserId != 0)
                ? $"{(string.IsNullOrEmpty(e2.EmployeeNumber) ? "Employee 2" : e2.EmployeeNumber)}: {e2.Total.ToString("N2")}"
                : "N/A";
        }
        catch (Exception ex)
        {
            MessageBox.Show("Failed to generate income report:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // create columns for sport grids if missing: Open | Covered | AC | Total
    private void EnsureSportGridColumns(DataGridView dgv)
    {
        if (dgv.Columns.Count == 0)
        {
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colOpen", HeaderText = "Open Court", Width = 120 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCovered", HeaderText = "Covered Court", Width = 120 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAC", HeaderText = "Airconditioned Court", Width = 140 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotal", HeaderText = "Total", Width = 120 });
        }
    }

    // create columns for summary grid if missing
    private void EnsureSummaryGridColumns(DataGridView dgv)
    {
        if (dgv.Columns.Count == 0)
        {
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSport", HeaderText = "Sport", Width = 200 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotalSport", HeaderText = "Total Income", Width = 140 });
        }
    }

    // fill one sport grid with values (single-row table showing the totals)
    private void FillSportGrid(string sport, DataGridView dgv, Dictionary<string, Dictionary<string, decimal>> matrix)
    {
        dgv.Rows.Clear();

        if (!matrix.ContainsKey(sport))
        {
            dgv.Rows.Add(0m.ToString("N2"), 0m.ToString("N2"), 0m.ToString("N2"), 0m.ToString("N2"));
            return;
        }

        var d = matrix[sport];
        decimal open = d.ContainsKey("Open Court") ? d["Open Court"] : 0m;
        decimal covered = d.ContainsKey("Covered Court") ? d["Covered Court"] : 0m;
        decimal ac = d.ContainsKey("Airconditioned Court") ? d["Airconditioned Court"] : 0m;
        decimal total = open + covered + ac;

        dgv.Rows.Add(open.ToString("N2"), covered.ToString("N2"), ac.ToString("N2"), total.ToString("N2"));
    }
}

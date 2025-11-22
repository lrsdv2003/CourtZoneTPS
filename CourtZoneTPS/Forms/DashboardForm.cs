using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CourtZoneTPS
{
    public partial class DashboardForm : UserControl
    {
        private string dbPath = @"C:\Users\EJ Ridge\OneDrive - STI College Ortigas-Cainta\Desktop\CourtZoneTPS_DB\CourtZoneTpsDB.db";
        private string connectionString;

        public DashboardForm()
        {
            InitializeComponent();
            connectionString = $"Data Source={dbPath};Version=3;";

            SetupGrid();
            LoadTodayReservations();

            dataGridViewTodayReservation.CellDoubleClick += dataGridViewTodayReservation_CellDoubleClick;
        }

        private void SetupGrid()
        {
            dataGridViewTodayReservation.AutoGenerateColumns = false;
            dataGridViewTodayReservation.Columns.Clear();

            dataGridViewTodayReservation.Columns.Add("id", "ID");
            dataGridViewTodayReservation.Columns.Add("customer", "Customer Name");
            dataGridViewTodayReservation.Columns.Add("sport", "Sport");
            dataGridViewTodayReservation.Columns.Add("court", "Court");
            dataGridViewTodayReservation.Columns.Add("timeSlot", "Time");
            dataGridViewTodayReservation.Columns.Add("payment", "Payment");
            dataGridViewTodayReservation.Columns.Add("contact", "Contact");

            dataGridViewTodayReservation.Columns["id"].Visible = false;

            dataGridViewTodayReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTodayReservation.ScrollBars = ScrollBars.Vertical;
        }

        private void LoadTodayReservations()
        {
            dataGridViewTodayReservation.Rows.Clear();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string today = DateTime.Now.ToString("yyyy-MM-dd");

                string query = "SELECT * FROM ReservationInfo WHERE date = @date";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", today);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        int totalReservations = 0;
                        decimal totalIncome = 0;
                        decimal openIncome = 0;
                        decimal coveredIncome = 0;
                        decimal airIncome = 0;
                        decimal pending = 0;

                        while (reader.Read())
                        {
                            string paymentStatus = reader["paymentStatus"].ToString();
                            decimal paymentAmount = Convert.ToDecimal(reader["paymentAmount"]);
                            string court = reader["courtType"].ToString();

                            totalReservations++;
                            totalIncome += paymentAmount;

                            if (paymentStatus == "half")
                                pending += paymentAmount;

                            if (court == "Open Court") openIncome += paymentAmount;
                            if (court == "Covered Court") coveredIncome += paymentAmount;
                            if (court == "Airconditioned Court") airIncome += paymentAmount;

                            dataGridViewTodayReservation.Rows.Add(
                                reader["reservation_Id"],
                                reader["customerName"],
                                reader["sportsType"],
                                reader["courtType"],
                                reader["timeSlot"],
                                reader["paymentStatus"],
                                reader["contactNumber"]
                            );
                        }

                        labelTotalReservationCount.Text = totalReservations.ToString();
                        labelTotalIncomeCount.Text = totalIncome.ToString("₱0.00");
                        labelTotalPendingmayment.Text = pending.ToString("₱0.00");
                        labelOpenCourtIncome.Text = openIncome.ToString("₱0.00");
                        labelCoveredCourtIncome.Text = coveredIncome.ToString("₱0.00");
                        labelAirconditionedCourtIncome.Text = airIncome.ToString("₱0.00");
                    }
                }
            }
        }

        // ✅ DOUBLE CLICK ONLY IF CUSTOMER NAME COLUMN
        private void dataGridViewTodayReservation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // header click

            // ✅ Check if clicked column is "customer"
            if (dataGridViewTodayReservation.Columns[e.ColumnIndex].Name != "customer")
                return;

            int id = Convert.ToInt32(
                dataGridViewTodayReservation.Rows[e.RowIndex].Cells["id"].Value
            );

            EditReservationDetailsForm editPage = new EditReservationDetailsForm(id);
            ((MainForm)ParentForm).LoadPage(editPage);
        }
    }
}

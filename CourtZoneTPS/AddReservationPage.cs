using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourtZoneTPS
{
    public partial class AddReservationPage : UserControl
    {
        public AddReservationPage()
        {
            InitializeComponent();
            dateTimePickerDate.MinDate = DateTime.Today;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonSaveReservation_Click(object sender, EventArgs e)
        {
            List<string> emptyFields = new List<string>();
            if (string.IsNullOrWhiteSpace(textBoxCustomerName.Text)) emptyFields.Add("Customer Name");
            if (string.IsNullOrWhiteSpace(comboBoxCourtType.Text)) emptyFields.Add("Court Type");
            if (string.IsNullOrWhiteSpace(comboBoxSportType.Text)) emptyFields.Add("Sport Type");
            if (string.IsNullOrWhiteSpace(comboBoxTime.Text)) emptyFields.Add("Time");
            if (string.IsNullOrWhiteSpace(textBoxContactNumber.Text)) emptyFields.Add("Contact Number");
            if (string.IsNullOrWhiteSpace(comboBoxPaymentStatus.Text)) emptyFields.Add("Payment Status");
            if (emptyFields.Count > 0)
            {
                string message = "Please fill in the following fields:\n- " + string.Join("\n- ", emptyFields);
                MessageBox.Show(message, "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Reservation r = new Reservation();
                r.CustomerName = textBoxCustomerName.Text;
                r.CourtType = comboBoxCourtType.Text;
                r.Date = dateTimePickerDate.Value.ToString("dd/MM/yyyy");
                r.Time = comboBoxTime.Text;
                r.SportsType = comboBoxSportType.Text;
                r.ContactNumber = textBoxContactNumber.Text;
                r.PaymentStatus = comboBoxPaymentStatus.Text;

                string dbPath = @"C:\Users\jm\OneDrive\Desktop\Database\CourtZoneTpsDB.db";
                string connectionString = $"Data Source={dbPath};Version=3;";

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO ReservationInfo (customerName,sportsType,date,paymentStatus,contactNumber,courtType,time) " +
                                    "VALUES (@customerName, @sportsType,@date,@paymentStatus,@contactNumber,@courtType,@time)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerName", r.CustomerName);
                        cmd.Parameters.AddWithValue("@sportsType", r.SportsType);
                        cmd.Parameters.AddWithValue("@date", r.Date);
                        cmd.Parameters.AddWithValue("@paymentStatus", r.PaymentStatus);
                        cmd.Parameters.AddWithValue("@contactNumber", r.ContactNumber);
                        cmd.Parameters.AddWithValue("@courtType", r.CourtType);
                        cmd.Parameters.AddWithValue("@time", r.Time);

                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
                MessageBox.Show("Reservation Added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                DashboardPage dashboardPage = new DashboardPage();
                ((MainForm)ParentForm).LoadPage(dashboardPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private Dictionary<string, List<string>> courtTimes = new Dictionary<string, List<string>>();

        private void LoadCourtsAndTimes()
        {
            comboBoxCourtType.Items.Clear();
            comboBoxTime.Items.Clear();

            List<string> allCourts = new List<string> { "Open Court", "Covered Court", "Airconditioned Court" };
            List<string> allTimes = new List<string>
    {
        "8:00AM - 10:00AM",
        "10:30AM - 12:30PM",
        "1:00PM - 3:00PM",
        "3:30PM - 5:30PM",
        "6:00PM - 8:00PM",
        "8:30PM - 10:30PM"
    };

            string selectedDate = dateTimePickerDate.Value.ToString("dd/MM/yyyy");
            string selectedSport = comboBoxSportType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedSport))
                return;

            courtTimes.Clear();

            string dbPath = @"C:\Users\jm\OneDrive\Desktop\Database\CourtZoneTpsDB.db";
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                foreach (var court in allCourts)
                {
                    List<string> availableTimes = new List<string>(allTimes);

                    string query = "SELECT time FROM ReservationInfo " +
                                   "WHERE date = @date AND sportsType = @sportsType AND courtType = @courtType";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", selectedDate);
                        cmd.Parameters.AddWithValue("@sportsType", selectedSport);
                        cmd.Parameters.AddWithValue("@courtType", court);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string taken = reader["time"].ToString().Trim();
                                availableTimes.RemoveAll(t => t.Trim() == taken);
                            }
                        }
                    }

                    if (availableTimes.Count > 0)
                        courtTimes[court] = availableTimes;
                }
            }

            foreach (var court in courtTimes.Keys)
                comboBoxCourtType.Items.Add(court);
        }
        private void LoadTimesForSelectedCourt()
        {
            comboBoxTime.Items.Clear();

            string court = comboBoxCourtType.SelectedItem?.ToString();
            if (court == null || !courtTimes.ContainsKey(court))
                return;

            foreach (var time in courtTimes[court])
                comboBoxTime.Items.Add(time);
        }


        private void Clear()
        {
            textBoxCustomerName.Clear();
            textBoxContactNumber.Clear();
            comboBoxCourtType.ResetText();
            comboBoxPaymentStatus.ResetText();
            comboBoxSportType.ResetText();
            comboBoxTime.ResetText();
            dateTimePickerDate.ResetText();
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            LoadCourtsAndTimes();
        }

        private void comboBoxSportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCourtsAndTimes();
        }

        private void comboBoxCourtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTimesForSelectedCourt();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Clear();
            DashboardPage dashboardPage = new DashboardPage();
            ((MainForm)ParentForm).LoadPage(dashboardPage);
        }
    }
}

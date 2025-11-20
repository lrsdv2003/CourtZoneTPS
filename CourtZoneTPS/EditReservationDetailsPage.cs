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
    public partial class EditReservationDetailsPage : UserControl
    {
        private int reservationID;
        private string connectionString = @"Data Source=C:\Users\jm\OneDrive\Desktop\Database\CourtZoneTpsDB.db;Version=3;";


        public EditReservationDetailsPage(int id)
        {
            InitializeComponent();
            reservationID = id;
            LoadReservationDetails();
            dateTimePickerDate.MinDate = DateTime.Today;
        }
        public EditReservationDetailsPage()
        {
            InitializeComponent();
        }
        private void LoadReservationDetails()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM ReservationInfo WHERE reservation_Id = @id";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", reservationID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBoxCustomerName.Text = reader["customerName"].ToString();
                            textBoxContactNumber.Text = reader["contactNumber"].ToString();
                            comboBoxSportType.Text = reader["sportsType"].ToString();
                            comboBoxCourtType.Text = reader["courtType"].ToString();
                            comboBoxTime.Text = reader["time"].ToString();
                            comboBoxPaymentStatus.Text = reader["paymentStatus"].ToString();


                            DateTime parsedDate;
                            if (DateTime.TryParse(reader["date"].ToString(), out parsedDate))
                            {
                                dateTimePickerDate.Value = parsedDate;
                            }
                        }
                    }
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = textBoxCustomerName.Text;
                Reservation r = new Reservation();
                r.CustomerName = textBoxCustomerName.Text;
                r.CourtType = comboBoxCourtType.Text;
                r.Date = dateTimePickerDate.Text;
                r.Time = comboBoxTime.Text;
                r.SportsType = comboBoxSportType.Text;
                r.ContactNumber = textBoxContactNumber.Text;
                r.PaymentStatus = comboBoxPaymentStatus.Text;

                string dbPath = @"C:\Users\jm\OneDrive\Desktop\Database\CourtZoneTpsDB.db";
                string connectionString = $"Data Source={dbPath};Version=3;";

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string query = @"UPDATE ReservationInfo 
                             SET sportsType = @sportsType, 
                                 date = @date, 
                                 paymentStatus = @paymentStatus, 
                                 contactNumber = @contactNumber, 
                                 courtType = @courtType, 
                                 time = @time  
                             WHERE customerName = @customerName";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerName", r.CustomerName);
                        cmd.Parameters.AddWithValue("@sportsType", r.SportsType);
                        cmd.Parameters.AddWithValue("@date", r.Date);
                        cmd.Parameters.AddWithValue("@paymentStatus", r.PaymentStatus);
                        cmd.Parameters.AddWithValue("@contactNumber", r.ContactNumber);
                        cmd.Parameters.AddWithValue("@courtType", r.CourtType);
                        cmd.Parameters.AddWithValue("@time", r.Time);


                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Reservation updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Update failed. Reservation not found.", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this reservation?",
                                           "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                MessageBox.Show("Reservation deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EditReservationPage editPage = new EditReservationPage();
                ((MainForm)ParentForm).LoadPage(editPage);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            EditReservationPage editPage = new EditReservationPage();
            ((MainForm)ParentForm).LoadPage(editPage);
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
    }
}

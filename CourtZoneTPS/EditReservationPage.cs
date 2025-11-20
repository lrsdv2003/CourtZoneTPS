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
    public partial class EditReservationPage : UserControl
    {
        private string dbPath = @"C:\Users\jm\OneDrive\Desktop\Database\CourtZoneTpsDB.db";
        private string connectionString;
        public EditReservationPage()
        {
            InitializeComponent();
            connectionString = $"Data Source={dbPath};Version=3;";
            SetupGrid();
            LoadReservations(DateTime.Now);
        }
        private void SetupGrid()
        {
            dataGridViewReservation.Columns.Clear();
            dataGridViewReservation.Columns.Add("id", "ID");
            dataGridViewReservation.Columns.Add("customer", "Customer Name");
            dataGridViewReservation.Columns.Add("sport", "Sport Type");
            dataGridViewReservation.Columns.Add("court", "Court");
            dataGridViewReservation.Columns.Add("time", "Time Slot");
            dataGridViewReservation.Columns.Add("payment", "Payment Status");
            dataGridViewReservation.Columns.Add("contact", "Contact Number");
            dataGridViewReservation.Columns["id"].Visible = false;
        }
        private void textBoxSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearchCustomer.Text.ToLower();

            foreach (DataGridViewRow row in dataGridViewReservation.Rows)
            {
                bool visible = row.Cells["customer"].Value.ToString()
                                 .ToLower()
                                 .Contains(keyword);
                row.Visible = visible;
            }
        }

        private void LoadReservations(DateTime selectedDate)
        {
            dataGridViewReservation.Rows.Clear();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string dateFormat = selectedDate.ToString("dd/MM/yyyy");

                string query = "SELECT * FROM ReservationInfo WHERE date = @date";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", dateFormat);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridViewReservation.Rows.Add(
                                reader["reservation_Id"],
                                reader["customerName"],
                                reader["sportsType"],
                                reader["courtType"],
                                reader["time"],
                                reader["paymentStatus"],
                                reader["contactNumber"]
                            );
                        }
                    }
                }
            }
        }

        private void buttonEditSelected_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to edit.");
                return;
            }

            int reservationID = Convert.ToInt32(
                dataGridViewReservation.SelectedRows[0].Cells["id"].Value
            );

            EditReservationDetailsPage detailsPage = new EditReservationDetailsPage(reservationID);
            ((MainForm)ParentForm).LoadPage(detailsPage);
        }
        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewReservation.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a reservation to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string customerName = dataGridViewReservation.SelectedRows[0].Cells["customer"].Value.ToString();

                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to delete {customerName}'s reservation?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    DeleteReservation(customerName);
                    LoadReservations(dateTimePickerSelectDate.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteReservation(string customerName)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM ReservationInfo WHERE customerName = @customerName";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerName", customerName);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservation deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record found with that name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadReservations(dateTimePickerSelectDate.Value);
        }
        private void dateTimePickerSelectDate_ValueChanged(object sender, EventArgs e)
        {
            LoadReservations(dateTimePickerSelectDate.Value);
        }
    }
}

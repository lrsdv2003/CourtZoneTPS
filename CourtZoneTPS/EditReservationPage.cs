using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourtZoneTPS
{
    public partial class EditReservationPage : UserControl
    {
        public EditReservationPage()
        {
            InitializeComponent();
            SetupGrid();
            LoadReservations(DateTime.Now);
        }

        private void dataGridViewReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            dataGridViewReservation.Columns["id"].Visible = false;
        }

        private void dateTimePickerSelectDate_ValueChanged(object sender, EventArgs e)
        {
            LoadReservations(dateTimePickerSelectDate.Value);
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

            // Simulated data
            dataGridViewReservation.Rows.Add(1, "John Doe", "Basketball", "Court 1", "1:00 PM - 3:00 PM", "50% Downpayment", "Confirmed");
            dataGridViewReservation.Rows.Add(2, "Anna Cruz", "Volleyball", "Court 2", "3:30 PM - 5:30 PM", "Fully Paid", "Confirmed");
            dataGridViewReservation.Rows.Add(3, "Mark Reyes", "Badminton", "Court 4", "6:00 PM - 7:00 PM", "Unpaid", "Pending");
        }

        private void buttonEditSelected_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reservationID = Convert.ToInt32(dataGridViewReservation.SelectedRows[0].Cells["id"].Value);
            EditReservationDetailsPage detailsPage = new EditReservationDetailsPage(reservationID);
            ((MainForm)ParentForm).LoadPage(detailsPage);
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = dataGridViewReservation.SelectedRows[0].Cells["customer"].Value.ToString();
            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete {name}'s reservation?",
                                                   "Confirm Delete",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                dataGridViewReservation.Rows.RemoveAt(dataGridViewReservation.SelectedRows[0].Index);
                MessageBox.Show("Reservation deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

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
    public partial class EditReservationDetailsPage : UserControl
    {
        private int reservationID;

        public EditReservationDetailsPage(int id)
        {
            InitializeComponent();
            reservationID = id;

            // Fill dropdown options
            comboBoxCourtType.Items.AddRange(new string[] { "Basketball", "Volleyball", "Badminton", "Tennis" });
            comboBoxCourtType.Items.AddRange(new string[] { "Open Court", "Covered Court", "Airconditioned Court" });
            comboBoxTime.Items.AddRange(new string[] {
        "8:00AM - 10:00AM",
        "10:30AM - 12:30PM",
        "1:00PM - 3:00PM",
        "3:30PM - 5:30PM",
        "6:00PM - 8:00PM",
        "8:30PM - 10:30PM"
    });
            comboBoxPaymentStatus.Items.AddRange(new string[] { "Half", "Full" });

            LoadReservationDetails();
        }

        public EditReservationDetailsPage()
        {
            InitializeComponent();
        }
        private void LoadReservationDetails()
        {
            // sample data lang to, pwede mo remove to later, inaadd ko lang para ma simulate yung pag edit
            if (reservationID == 1)
            {
                textBoxCustomerName.Text = "John Doe";
                textBoxContactNumber.Text = "09123456789";
                comboBoxSportType.SelectedItem = "Basketball";
                comboBoxCourtType.SelectedItem = "Open Court";
                dateTimePickerDate.Value = DateTime.Today;
                comboBoxTime.SelectedItem = "1:00PM - 3:00PM";
                comboBoxPaymentStatus.SelectedItem = "Half";
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCustomerName.Text) ||
        string.IsNullOrWhiteSpace(textBoxContactNumber.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Reservation updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EditReservationPage editPage = new EditReservationPage();
            ((MainForm)ParentForm).LoadPage(editPage);
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
    }
}

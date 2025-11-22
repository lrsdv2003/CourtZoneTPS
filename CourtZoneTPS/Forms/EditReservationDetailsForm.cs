using CourtZoneTPS.Services;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace CourtZoneTPS
{
    public partial class EditReservationDetailsForm : UserControl
    {
        private readonly ReservationService service;
        private readonly int reservationId;
        private Reservation current;

        public EditReservationDetailsForm(int reservationId)
        {
            InitializeComponent();
            service = new ReservationService();
            this.reservationId = reservationId;

            dateTimePickerDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDate.CustomFormat = "yyyy-MM-dd";

            LoadDropdowns();
            LoadReservation();
        }

        private void LoadDropdowns()
        {
            comboBoxSportType.Items.Clear();
            comboBoxSportType.Items.AddRange(new object[] { "Basketball", "Volleyball", "Badminton", "Tennis" });

            comboBoxCourtType.Items.Clear();
            comboBoxCourtType.Items.AddRange(new object[] { "Open Court", "Covered Court", "Airconditioned Court" });

            comboBoxTime.Items.Clear();
            comboBoxTime.Items.AddRange(new object[]
            {
                "8:00AM - 10:00AM",
                "10:30AM - 12:30PM",
                "1:00PM - 3:00PM",
                "3:30PM - 5:30PM",
                "6:00PM - 8:00PM",
                "8:30PM - 10:30PM"
            });

            comboBoxPaymentStatus.Items.Clear();
            comboBoxPaymentStatus.Items.AddRange(new object[] { "half", "full" });
        }

        private void LoadReservation()
        {
            current = service.GetReservationById(reservationId);
            if (current == null)
            {
                MessageBox.Show("Reservation not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((MainForm)ParentForm).LoadPage(new EditReservationForm());
                return;
            }

            textBoxCustomerName.Text = current.CustomerName;
            textBoxContactNumber.Text = current.ContactNumber;
            comboBoxSportType.SelectedItem = current.SportsType;
            comboBoxCourtType.SelectedItem = current.CourtType;
            dateTimePickerDate.Value = current.Date;
            comboBoxTime.SelectedItem = current.TimeSlot;
            comboBoxPaymentStatus.SelectedItem = current.PaymentStatus;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // validation
            if (string.IsNullOrWhiteSpace(textBoxCustomerName.Text) ||
                string.IsNullOrWhiteSpace(textBoxContactNumber.Text) ||
                comboBoxSportType.SelectedIndex == -1 ||
                comboBoxCourtType.SelectedIndex == -1 ||
                comboBoxTime.SelectedIndex == -1 ||
                comboBoxPaymentStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // compute paymentAmount using pricing table
            decimal price = service.GetCourtPrice(comboBoxCourtType.SelectedItem.ToString());
            decimal paymentAmount = comboBoxPaymentStatus.SelectedItem.ToString() == "half" ? price / 2 : price;

            var updated = new Reservation
            {
                ReservationID = reservationId,
                UserID = current.UserID,
                CustomerName = textBoxCustomerName.Text.Trim(),
                ContactNumber = textBoxContactNumber.Text.Trim(),
                SportsType = comboBoxSportType.SelectedItem.ToString(),
                CourtType = comboBoxCourtType.SelectedItem.ToString(),
                Date = dateTimePickerDate.Value,
                TimeSlot = comboBoxTime.SelectedItem.ToString(),
                PaymentStatus = comboBoxPaymentStatus.SelectedItem.ToString(),
                PaymentAmount = paymentAmount
            };

            bool ok = service.UpdateReservation(updated);
            if (ok)
            {
                MessageBox.Show("Reservation updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((MainForm)ParentForm).LoadPage(new EditReservationForm());
            }
            else
            {
                // likely booking conflict or DB error
                MessageBox.Show("Update failed: time slot may be occupied or an error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
        "Are you sure you want to delete this reservation?",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
    );

            if (confirm != DialogResult.Yes)
                return;

            ReservationService service = new ReservationService();

            bool success = service.DeleteReservationById(reservationId);

            if (success)
            {
                MessageBox.Show("Reservation deleted successfully!",
                                "Deleted",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Go back to the reservations list
                ((MainForm)ParentForm).LoadPage(new EditReservationForm());
            }
            else
            {
                MessageBox.Show("Failed to delete reservation.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ((MainForm)ParentForm).LoadPage(new EditReservationForm());
        }
    }
}

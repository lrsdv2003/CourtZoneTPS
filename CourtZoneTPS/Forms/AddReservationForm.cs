using CourtZoneTPS.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourtZoneTPS
{
    public partial class AddReservationForm : UserControl
    {
        private readonly ReservationService service = new ReservationService();
        private readonly int currentUserId;

        public Action OnReservationAdded;

        public AddReservationForm(int userId)
        {
            InitializeComponent();
            currentUserId = userId;

            LoadSportTypes();
            LoadCourtTypes();
            LoadTimeSlots();
            LoadPaymentStatus();

            dateTimePickerDate.MinDate = DateTime.Today;
        }

        // -----------------------------
        // LOAD DROPDOWN ITEMS
        // -----------------------------
        private void LoadSportTypes()
        {
            comboBoxSportType.Items.AddRange(new object[]
            {
                "Basketball",
                "Volleyball",
                "Badminton",
                "Tennis"
            });
        }

        private void LoadCourtTypes()
        {
            comboBoxCourtType.Items.AddRange(new object[]
            {
                "Open Court",
                "Covered Court",
                "Airconditioned Court"
            });
        }

        private void LoadTimeSlots()
        {
            comboBoxTime.Items.AddRange(new object[]
            {
                "8:00AM - 10:00AM",
                "10:30AM - 12:30PM",
                "1:00PM - 3:00PM",
                "3:30PM - 5:30PM",
                "6:00PM - 8:00PM",
                "8:30PM - 10:30PM"
            });
        }

        private void LoadPaymentStatus()
        {
            comboBoxPaymentStatus.Items.AddRange(new object[]
            {
                "half",
                "full"
            });
        }

        // -----------------------------
        // SAVE RESERVATION BUTTON
        // -----------------------------
        private void buttonSaveReservation_Click(object sender, EventArgs e)
        {
            // Validate required fields
            List<string> missing = new List<string>();

            if (string.IsNullOrWhiteSpace(textBoxCustomerName.Text)) missing.Add("Customer Name");
            if (string.IsNullOrWhiteSpace(textBoxContactNumber.Text)) missing.Add("Contact Number");
            if (comboBoxSportType.SelectedIndex == -1) missing.Add("Sport Type");
            if (comboBoxCourtType.SelectedIndex == -1) missing.Add("Court Type");
            if (comboBoxTime.SelectedIndex == -1) missing.Add("Time Slot");
            if (comboBoxPaymentStatus.SelectedIndex == -1) missing.Add("Payment Status");

            if (missing.Count > 0)
            {
                MessageBox.Show(
                    "Please fill in the following fields:\n - " + string.Join("\n - ", missing),
                    "Missing Required Fields",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string courtType = comboBoxCourtType.SelectedItem.ToString();
            string timeSlot = comboBoxTime.SelectedItem.ToString();
            string dateValue = dateTimePickerDate.Value.ToString("yyyy-MM-dd");

            // -----------------------------
            // CHECK DOUBLE BOOKING
            // -----------------------------
            bool available = service.CheckAvailability(
                courtType,
                dateValue,
                timeSlot
            );

            if (!available)
            {
                MessageBox.Show("This timeslot is already reserved for this court.",
                    "Slot Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // -----------------------------
            // CALCULATE PRICE
            // -----------------------------
            decimal price = service.GetCourtPrice(courtType);
            decimal paymentAmount = comboBoxPaymentStatus.SelectedItem.ToString() == "half"
                ? price / 2
                : price;

            // -----------------------------
            // INSERT RESERVATION
            // -----------------------------
            bool success = service.InsertReservation(
               currentUserId,
               textBoxCustomerName.Text.Trim(),
               textBoxContactNumber.Text.Trim(),
               comboBoxSportType.SelectedItem.ToString(),
               courtType,
               dateTimePickerDate.Value,
               timeSlot,
               comboBoxPaymentStatus.SelectedItem.ToString(),
               paymentAmount
            );

            if (success)
            {
                MessageBox.Show("Reservation successfully added!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                OnReservationAdded?.Invoke();

                // Remove AddReservationForm from the container
                var parent = this.Parent;
                if (parent != null)
                    parent.Controls.Remove(this);
            }

        }

        // -----------------------------
        // CANCEL BUTTON
        // -----------------------------
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Do you want to cancel adding this reservation?",
                "Cancel Reservation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                ((MainForm)ParentForm).LoadPage(new DashboardForm());
            }
        }

        // -----------------------------
        // CLEAR BUTTON
        // -----------------------------
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCustomerName.Clear();
            textBoxContactNumber.Clear();
            comboBoxSportType.SelectedIndex = -1;
            comboBoxCourtType.SelectedIndex = -1;
            comboBoxTime.SelectedIndex = -1;
            comboBoxPaymentStatus.SelectedIndex = -1;
            dateTimePickerDate.Value = DateTime.Now;
        }
    }
}

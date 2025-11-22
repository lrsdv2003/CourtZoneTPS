using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourtZoneTPS.Services;

namespace CourtZoneTPS
{
    public partial class EditReservationForm : UserControl
    {
        private readonly ReservationService _service;

        public EditReservationForm()
        {
            InitializeComponent();

            // create service
            _service = new ReservationService();

            // prevent events while initializing
            dateTimePickerSelectDate.ValueChanged -= dateTimePickerSelectDate_ValueChanged;
            textBoxSearchCustomer.TextChanged -= textBoxSearchCustomer_TextChanged;

            // ensure datepicker uses DB format for consistency
            dateTimePickerSelectDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerSelectDate.CustomFormat = "yyyy-MM-dd";
            dateTimePickerSelectDate.Value = DateTime.Today;

            SetupGrid();

            // load today's reservations
            LoadReservations(dateTimePickerSelectDate.Value);

            // attach events after setup
            dateTimePickerSelectDate.ValueChanged += dateTimePickerSelectDate_ValueChanged;
            textBoxSearchCustomer.TextChanged += textBoxSearchCustomer_TextChanged;
        }

        /// <summary>
        /// Setup DataGridView columns safely. Call this before adding rows.
        /// </summary>
        private void SetupGrid()
        {
            // Clear any existing columns and rows
            dataGridViewReservation.Rows.Clear();
            dataGridViewReservation.Columns.Clear();

            dataGridViewReservation.AutoGenerateColumns = false;
            dataGridViewReservation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReservation.MultiSelect = false;
            dataGridViewReservation.AllowUserToAddRows = false;
            dataGridViewReservation.ReadOnly = true;

            // Add columns (id hidden)
            var colId = new DataGridViewTextBoxColumn
            {
                Name = "id",
                HeaderText = "ID",
                DataPropertyName = "ReservationID",
                Visible = false
            };
            dataGridViewReservation.Columns.Add(colId);

            dataGridViewReservation.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "customer",
                HeaderText = "Customer Name",
                DataPropertyName = "CustomerName",
                Width = 200
            });

            dataGridViewReservation.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "sport",
                HeaderText = "Sport Type",
                DataPropertyName = "SportsType",
                Width = 120
            });

            dataGridViewReservation.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "court",
                HeaderText = "Court",
                DataPropertyName = "CourtType",
                Width = 140
            });

            dataGridViewReservation.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "timeSlot",
                HeaderText = "Time Slot",
                DataPropertyName = "TimeSlot",
                Width = 140
            });

            dataGridViewReservation.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "payment",
                HeaderText = "Payment Status",
                DataPropertyName = "PaymentStatus",
                Width = 100
            });

            dataGridViewReservation.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "contact",
                HeaderText = "Contact Number",
                DataPropertyName = "ContactNumber",
                Width = 130
            });
        }

        /// <summary>
        /// Loads reservations for the selected date and populates the DataGridView.
        /// </summary>
        /// <param name="selectedDate"></param>
        private void LoadReservations(DateTime selectedDate)
        {
            // ensure columns exist
            if (dataGridViewReservation.Columns.Count == 0)
                SetupGrid();

            dataGridViewReservation.Rows.Clear();

            List<Reservation> reservations;
            try
            {
                reservations = _service.GetReservationsByDate(selectedDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load reservations:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var r in reservations)
            {
                dataGridViewReservation.Rows.Add(
                    r.ReservationID,
                    r.CustomerName,
                    r.SportsType,
                    r.CourtType,
                    r.TimeSlot,
                    r.PaymentStatus,
                    r.ContactNumber
                );
            }
        }

        // EVENT: Date changed
        private void dateTimePickerSelectDate_ValueChanged(object sender, EventArgs e)
        {
            LoadReservations(dateTimePickerSelectDate.Value);
        }

        // EVENT: Live search filter
        private void textBoxSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearchCustomer.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridViewReservation.Rows)
            {
                if (row.IsNewRow) continue;

                var cell = row.Cells["customer"].Value;
                bool visible = cell != null && cell.ToString().ToLower().Contains(keyword);
                row.Visible = visible;
            }
        }

        // Refresh button click
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadReservations(dateTimePickerSelectDate.Value);
        }

        // Edit selected reservation
        private void buttonEditSelected_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reservationID = Convert.ToInt32(dataGridViewReservation.SelectedRows[0].Cells["id"].Value);

            // navigate to details editor (UserControl)
            var details = new EditReservationDetailsForm(reservationID);

            var main = this.FindForm() as MainForm;
            if (main != null)
            {
                main.LoadPage(details);
            }
            else
            {
                MessageBox.Show("Main form not found. Cannot open edit page.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete selected reservation (by id) safely
        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reservationID = Convert.ToInt32(dataGridViewReservation.SelectedRows[0].Cells["id"].Value);
            string customer = dataGridViewReservation.SelectedRows[0].Cells["customer"].Value?.ToString();

            var confirm = MessageBox.Show($"Are you sure you want to delete {customer}'s reservation?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                bool ok = _service.DeleteReservationById(reservationID);
                if (ok)
                {
                    MessageBox.Show("Reservation deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadReservations(dateTimePickerSelectDate.Value);
                }
                else
                {
                    MessageBox.Show("Delete failed (record may not exist).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting reservation:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

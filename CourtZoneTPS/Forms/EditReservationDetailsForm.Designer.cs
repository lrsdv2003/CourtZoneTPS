namespace CourtZoneTPS
{
    partial class EditReservationDetailsForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            labelEditReservation = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            flpanelInputFields = new FlowLayoutPanel();
            panel1 = new Panel();
            flpanelCustomerName = new FlowLayoutPanel();
            labelCustomerName = new Label();
            textBoxCustomerName = new TextBox();
            flpanelContactNumber = new FlowLayoutPanel();
            labelContanctNumber = new Label();
            textBoxContactNumber = new TextBox();
            panel2 = new Panel();
            flpanelDate = new FlowLayoutPanel();
            labelDate = new Label();
            dateTimePickerDate = new DateTimePicker();
            flpanelSportType = new FlowLayoutPanel();
            labelSportType = new Label();
            comboBoxSportType = new ComboBox();
            panel3 = new Panel();
            flpanleTime = new FlowLayoutPanel();
            labelTime = new Label();
            comboBoxTime = new ComboBox();
            flpanelCourtType = new FlowLayoutPanel();
            labelCourtType = new Label();
            comboBoxCourtType = new ComboBox();
            panel4 = new Panel();
            flpanelPaymentStatus = new FlowLayoutPanel();
            labelPaymentStatus = new Label();
            comboBoxPaymentStatus = new ComboBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonCancel = new Button();
            panelHeader.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flpanelInputFields.SuspendLayout();
            panel1.SuspendLayout();
            flpanelCustomerName.SuspendLayout();
            flpanelContactNumber.SuspendLayout();
            panel2.SuspendLayout();
            flpanelDate.SuspendLayout();
            flpanelSportType.SuspendLayout();
            panel3.SuspendLayout();
            flpanleTime.SuspendLayout();
            flpanelCourtType.SuspendLayout();
            panel4.SuspendLayout();
            flpanelPaymentStatus.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(labelEditReservation);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20);
            panelHeader.Size = new Size(980, 100);
            panelHeader.TabIndex = 3;
            // 
            // labelEditReservation
            // 
            labelEditReservation.BackColor = Color.Transparent;
            labelEditReservation.Dock = DockStyle.Left;
            labelEditReservation.FlatStyle = FlatStyle.Flat;
            labelEditReservation.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEditReservation.ForeColor = Color.FromArgb(30, 58, 138);
            labelEditReservation.Location = new Point(20, 20);
            labelEditReservation.Margin = new Padding(0);
            labelEditReservation.Name = "labelEditReservation";
            labelEditReservation.Size = new Size(284, 60);
            labelEditReservation.TabIndex = 0;
            labelEditReservation.Text = "Edit Reservation";
            labelEditReservation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(flpanelInputFields);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 100);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20);
            flowLayoutPanel1.Size = new Size(980, 700);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(30, 58, 138);
            label1.Location = new Point(20, 20);
            label1.Margin = new Padding(0, 0, 0, 20);
            label1.Name = "label1";
            label1.Size = new Size(940, 30);
            label1.TabIndex = 2;
            label1.Text = "Update the reservation details below";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(30, 58, 138);
            label2.Location = new Point(20, 70);
            label2.Margin = new Padding(0, 0, 0, 20);
            label2.Name = "label2";
            label2.Size = new Size(940, 40);
            label2.TabIndex = 3;
            label2.Text = "Reservation Details";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpanelInputFields
            // 
            flpanelInputFields.BackColor = Color.White;
            flpanelInputFields.Controls.Add(panel1);
            flpanelInputFields.Controls.Add(panel2);
            flpanelInputFields.Controls.Add(panel3);
            flpanelInputFields.Controls.Add(panel4);
            flpanelInputFields.Controls.Add(flowLayoutPanel2);
            flpanelInputFields.FlowDirection = FlowDirection.TopDown;
            flpanelInputFields.Location = new Point(20, 130);
            flpanelInputFields.Margin = new Padding(0);
            flpanelInputFields.Name = "flpanelInputFields";
            flpanelInputFields.Size = new Size(940, 550);
            flpanelInputFields.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(flpanelCustomerName);
            panel1.Controls.Add(flpanelContactNumber);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 100);
            panel1.TabIndex = 0;
            // 
            // flpanelCustomerName
            // 
            flpanelCustomerName.Controls.Add(labelCustomerName);
            flpanelCustomerName.Controls.Add(textBoxCustomerName);
            flpanelCustomerName.Dock = DockStyle.Right;
            flpanelCustomerName.FlowDirection = FlowDirection.TopDown;
            flpanelCustomerName.Location = new Point(0, 0);
            flpanelCustomerName.Margin = new Padding(0);
            flpanelCustomerName.Name = "flpanelCustomerName";
            flpanelCustomerName.Padding = new Padding(10);
            flpanelCustomerName.Size = new Size(470, 100);
            flpanelCustomerName.TabIndex = 2;
            // 
            // labelCustomerName
            // 
            labelCustomerName.Dock = DockStyle.Left;
            labelCustomerName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelCustomerName.ForeColor = Color.FromArgb(30, 58, 138);
            labelCustomerName.Location = new Point(10, 10);
            labelCustomerName.Margin = new Padding(0, 0, 0, 10);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(450, 30);
            labelCustomerName.TabIndex = 1;
            labelCustomerName.Text = "Customer Name";
            labelCustomerName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.BorderStyle = BorderStyle.FixedSingle;
            textBoxCustomerName.Dock = DockStyle.Left;
            textBoxCustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCustomerName.Location = new Point(10, 50);
            textBoxCustomerName.Margin = new Padding(0);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(400, 34);
            textBoxCustomerName.TabIndex = 2;
            // 
            // flpanelContactNumber
            // 
            flpanelContactNumber.Controls.Add(labelContanctNumber);
            flpanelContactNumber.Controls.Add(textBoxContactNumber);
            flpanelContactNumber.Dock = DockStyle.Right;
            flpanelContactNumber.FlowDirection = FlowDirection.TopDown;
            flpanelContactNumber.Location = new Point(470, 0);
            flpanelContactNumber.Margin = new Padding(0);
            flpanelContactNumber.Name = "flpanelContactNumber";
            flpanelContactNumber.Padding = new Padding(10);
            flpanelContactNumber.Size = new Size(470, 100);
            flpanelContactNumber.TabIndex = 1;
            // 
            // labelContanctNumber
            // 
            labelContanctNumber.Dock = DockStyle.Left;
            labelContanctNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelContanctNumber.ForeColor = Color.FromArgb(30, 58, 138);
            labelContanctNumber.Location = new Point(10, 10);
            labelContanctNumber.Margin = new Padding(0, 0, 0, 10);
            labelContanctNumber.Name = "labelContanctNumber";
            labelContanctNumber.Size = new Size(450, 30);
            labelContanctNumber.TabIndex = 1;
            labelContanctNumber.Text = "Contact Number";
            labelContanctNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxContactNumber
            // 
            textBoxContactNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxContactNumber.Dock = DockStyle.Left;
            textBoxContactNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContactNumber.Location = new Point(10, 50);
            textBoxContactNumber.Margin = new Padding(0);
            textBoxContactNumber.Name = "textBoxContactNumber";
            textBoxContactNumber.Size = new Size(400, 34);
            textBoxContactNumber.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(flpanelDate);
            panel2.Controls.Add(flpanelSportType);
            panel2.Location = new Point(0, 100);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 100);
            panel2.TabIndex = 1;
            // 
            // flpanelDate
            // 
            flpanelDate.Controls.Add(labelDate);
            flpanelDate.Controls.Add(dateTimePickerDate);
            flpanelDate.Dock = DockStyle.Left;
            flpanelDate.FlowDirection = FlowDirection.TopDown;
            flpanelDate.Location = new Point(0, 0);
            flpanelDate.Margin = new Padding(0);
            flpanelDate.Name = "flpanelDate";
            flpanelDate.Padding = new Padding(10);
            flpanelDate.Size = new Size(470, 100);
            flpanelDate.TabIndex = 2;
            // 
            // labelDate
            // 
            labelDate.Dock = DockStyle.Left;
            labelDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelDate.ForeColor = Color.FromArgb(30, 58, 138);
            labelDate.Location = new Point(10, 10);
            labelDate.Margin = new Padding(0, 0, 0, 10);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(450, 30);
            labelDate.TabIndex = 1;
            labelDate.Text = "Date";
            labelDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerDate.Dock = DockStyle.Left;
            dateTimePickerDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDate.Location = new Point(10, 50);
            dateTimePickerDate.Margin = new Padding(0);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(250, 27);
            dateTimePickerDate.TabIndex = 2;
            // 
            // flpanelSportType
            // 
            flpanelSportType.Controls.Add(labelSportType);
            flpanelSportType.Controls.Add(comboBoxSportType);
            flpanelSportType.Dock = DockStyle.Right;
            flpanelSportType.FlowDirection = FlowDirection.TopDown;
            flpanelSportType.Location = new Point(470, 0);
            flpanelSportType.Margin = new Padding(0);
            flpanelSportType.Name = "flpanelSportType";
            flpanelSportType.Padding = new Padding(10);
            flpanelSportType.Size = new Size(470, 100);
            flpanelSportType.TabIndex = 2;
            // 
            // labelSportType
            // 
            labelSportType.Dock = DockStyle.Left;
            labelSportType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelSportType.ForeColor = Color.FromArgb(30, 58, 138);
            labelSportType.Location = new Point(10, 10);
            labelSportType.Margin = new Padding(0, 0, 0, 10);
            labelSportType.Name = "labelSportType";
            labelSportType.Size = new Size(450, 30);
            labelSportType.TabIndex = 1;
            labelSportType.Text = "Sport Type";
            labelSportType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxSportType
            // 
            comboBoxSportType.Dock = DockStyle.Left;
            comboBoxSportType.Font = new Font("Segoe UI", 12F);
            comboBoxSportType.FormattingEnabled = true;
            comboBoxSportType.Items.AddRange(new object[] { "Basketball", "Volleyball", "Badminton", "Tennis" });
            comboBoxSportType.Location = new Point(10, 50);
            comboBoxSportType.Margin = new Padding(0);
            comboBoxSportType.Name = "comboBoxSportType";
            comboBoxSportType.Size = new Size(250, 36);
            comboBoxSportType.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(flpanleTime);
            panel3.Controls.Add(flpanelCourtType);
            panel3.Location = new Point(0, 200);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(940, 100);
            panel3.TabIndex = 2;
            // 
            // flpanleTime
            // 
            flpanleTime.Controls.Add(labelTime);
            flpanleTime.Controls.Add(comboBoxTime);
            flpanleTime.Dock = DockStyle.Right;
            flpanleTime.FlowDirection = FlowDirection.TopDown;
            flpanleTime.Location = new Point(470, 0);
            flpanleTime.Margin = new Padding(0);
            flpanleTime.Name = "flpanleTime";
            flpanleTime.Padding = new Padding(10);
            flpanleTime.Size = new Size(470, 100);
            flpanleTime.TabIndex = 1;
            // 
            // labelTime
            // 
            labelTime.Dock = DockStyle.Left;
            labelTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelTime.ForeColor = Color.FromArgb(30, 58, 138);
            labelTime.Location = new Point(10, 10);
            labelTime.Margin = new Padding(0, 0, 0, 10);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(450, 30);
            labelTime.TabIndex = 1;
            labelTime.Text = "Available Time";
            labelTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxTime
            // 
            comboBoxTime.Dock = DockStyle.Left;
            comboBoxTime.Font = new Font("Segoe UI", 12F);
            comboBoxTime.FormattingEnabled = true;
            comboBoxTime.Items.AddRange(new object[] { "8:00AM   - 10:00AM", "10:30AM - 12:30PM", "1:00PM   -  3:00PM", "3:30PM   -  5:30PM", "6:00PM   -  8:00PM", "8:30PM   - 10:30PM" });
            comboBoxTime.Location = new Point(10, 50);
            comboBoxTime.Margin = new Padding(0);
            comboBoxTime.Name = "comboBoxTime";
            comboBoxTime.Size = new Size(250, 36);
            comboBoxTime.TabIndex = 4;
            // 
            // flpanelCourtType
            // 
            flpanelCourtType.Controls.Add(labelCourtType);
            flpanelCourtType.Controls.Add(comboBoxCourtType);
            flpanelCourtType.Dock = DockStyle.Left;
            flpanelCourtType.FlowDirection = FlowDirection.TopDown;
            flpanelCourtType.Location = new Point(0, 0);
            flpanelCourtType.Margin = new Padding(0);
            flpanelCourtType.Name = "flpanelCourtType";
            flpanelCourtType.Padding = new Padding(10);
            flpanelCourtType.Size = new Size(470, 100);
            flpanelCourtType.TabIndex = 1;
            // 
            // labelCourtType
            // 
            labelCourtType.Dock = DockStyle.Left;
            labelCourtType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelCourtType.ForeColor = Color.FromArgb(30, 58, 138);
            labelCourtType.Location = new Point(10, 10);
            labelCourtType.Margin = new Padding(0, 0, 0, 10);
            labelCourtType.Name = "labelCourtType";
            labelCourtType.Size = new Size(450, 30);
            labelCourtType.TabIndex = 1;
            labelCourtType.Text = "Court Type";
            labelCourtType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxCourtType
            // 
            comboBoxCourtType.Dock = DockStyle.Left;
            comboBoxCourtType.Font = new Font("Segoe UI", 12F);
            comboBoxCourtType.FormattingEnabled = true;
            comboBoxCourtType.Items.AddRange(new object[] { "Open Court", "Covered Court", "Airconditioned Court" });
            comboBoxCourtType.Location = new Point(10, 50);
            comboBoxCourtType.Margin = new Padding(0);
            comboBoxCourtType.Name = "comboBoxCourtType";
            comboBoxCourtType.Size = new Size(250, 36);
            comboBoxCourtType.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(flpanelPaymentStatus);
            panel4.Location = new Point(0, 300);
            panel4.Margin = new Padding(0, 0, 0, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(940, 100);
            panel4.TabIndex = 3;
            // 
            // flpanelPaymentStatus
            // 
            flpanelPaymentStatus.Controls.Add(labelPaymentStatus);
            flpanelPaymentStatus.Controls.Add(comboBoxPaymentStatus);
            flpanelPaymentStatus.Dock = DockStyle.Left;
            flpanelPaymentStatus.FlowDirection = FlowDirection.TopDown;
            flpanelPaymentStatus.Location = new Point(0, 0);
            flpanelPaymentStatus.Margin = new Padding(0);
            flpanelPaymentStatus.Name = "flpanelPaymentStatus";
            flpanelPaymentStatus.Padding = new Padding(10);
            flpanelPaymentStatus.Size = new Size(470, 100);
            flpanelPaymentStatus.TabIndex = 2;
            // 
            // labelPaymentStatus
            // 
            labelPaymentStatus.Dock = DockStyle.Left;
            labelPaymentStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelPaymentStatus.ForeColor = Color.FromArgb(30, 58, 138);
            labelPaymentStatus.Location = new Point(10, 10);
            labelPaymentStatus.Margin = new Padding(0, 0, 0, 10);
            labelPaymentStatus.Name = "labelPaymentStatus";
            labelPaymentStatus.Size = new Size(450, 30);
            labelPaymentStatus.TabIndex = 1;
            labelPaymentStatus.Text = "Payment Status";
            labelPaymentStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxPaymentStatus
            // 
            comboBoxPaymentStatus.Dock = DockStyle.Left;
            comboBoxPaymentStatus.Font = new Font("Segoe UI", 12F);
            comboBoxPaymentStatus.FormattingEnabled = true;
            comboBoxPaymentStatus.Items.AddRange(new object[] { "Half Paid", "Full Paid" });
            comboBoxPaymentStatus.Location = new Point(10, 50);
            comboBoxPaymentStatus.Margin = new Padding(0);
            comboBoxPaymentStatus.Name = "comboBoxPaymentStatus";
            comboBoxPaymentStatus.Size = new Size(250, 36);
            comboBoxPaymentStatus.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(buttonUpdate);
            flowLayoutPanel2.Controls.Add(buttonDelete);
            flowLayoutPanel2.Controls.Add(buttonCancel);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 440);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(940, 50);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(30, 58, 138);
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(0, 0);
            buttonUpdate.Margin = new Padding(0, 0, 40, 0);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(200, 50);
            buttonUpdate.TabIndex = 0;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(30, 58, 138);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(240, 0);
            buttonDelete.Margin = new Padding(0, 0, 40, 0);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(200, 50);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(30, 58, 138);
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(480, 0);
            buttonCancel.Margin = new Padding(0, 0, 40, 0);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(200, 50);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // EditReservationDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelHeader);
            Margin = new Padding(0);
            Name = "EditReservationDetailsForm";
            Size = new Size(980, 800);
            panelHeader.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flpanelInputFields.ResumeLayout(false);
            panel1.ResumeLayout(false);
            flpanelCustomerName.ResumeLayout(false);
            flpanelCustomerName.PerformLayout();
            flpanelContactNumber.ResumeLayout(false);
            flpanelContactNumber.PerformLayout();
            panel2.ResumeLayout(false);
            flpanelDate.ResumeLayout(false);
            flpanelSportType.ResumeLayout(false);
            panel3.ResumeLayout(false);
            flpanleTime.ResumeLayout(false);
            flpanelCourtType.ResumeLayout(false);
            panel4.ResumeLayout(false);
            flpanelPaymentStatus.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelEditReservation;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flpanelInputFields;
        private Panel panel1;
        private FlowLayoutPanel flpanelCustomerName;
        private Label labelCustomerName;
        private TextBox textBoxCustomerName;
        private FlowLayoutPanel flpanelContactNumber;
        private Label labelContanctNumber;
        private TextBox textBoxContactNumber;
        private Panel panel2;
        private FlowLayoutPanel flpanelSportType;
        private Label labelSportType;
        private ComboBox comboBoxSportType;
        private FlowLayoutPanel flpanelCourtType;
        private Label labelCourtType;
        private ComboBox comboBoxCourtType;
        private Panel panel3;
        private FlowLayoutPanel flpanelDate;
        private Label labelDate;
        private DateTimePicker dateTimePickerDate;
        private FlowLayoutPanel flpanleTime;
        private Label labelTime;
        private ComboBox comboBoxTime;
        private Panel panel4;
        private FlowLayoutPanel flpanelPaymentStatus;
        private Label labelPaymentStatus;
        private ComboBox comboBoxPaymentStatus;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonCancel;
    }
}

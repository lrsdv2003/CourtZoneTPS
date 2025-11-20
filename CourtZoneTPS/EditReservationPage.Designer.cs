namespace CourtZoneTPS
{
    partial class EditReservationPage
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
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            dateTimePickerSelectDate = new DateTimePicker();
            textBoxSearchCustomer = new TextBox();
            dataGridViewReservation = new DataGridView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonEditSelected = new Button();
            buttonDeleteSelected = new Button();
            buttonRefresh = new Button();
            panelHeader.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservation).BeginInit();
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
            panelHeader.TabIndex = 2;
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
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(dataGridViewReservation);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 100);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20);
            flowLayoutPanel1.Size = new Size(980, 700);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(30, 58, 138);
            label2.Location = new Point(20, 20);
            label2.Margin = new Padding(0, 0, 0, 20);
            label2.Name = "label2";
            label2.Size = new Size(940, 40);
            label2.TabIndex = 2;
            label2.Text = "Find Reservation";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(30, 58, 138);
            label1.Location = new Point(20, 80);
            label1.Margin = new Padding(0, 0, 0, 20);
            label1.Name = "label1";
            label1.Size = new Size(940, 30);
            label1.TabIndex = 1;
            label1.Text = "Select a date to view and edit existing reservations";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePickerSelectDate);
            panel1.Controls.Add(textBoxSearchCustomer);
            panel1.Location = new Point(20, 130);
            panel1.Margin = new Padding(0, 0, 0, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 32);
            panel1.TabIndex = 6;
            // 
            // dateTimePickerSelectDate
            // 
            dateTimePickerSelectDate.CalendarFont = new Font("Segoe UI", 11F);
            dateTimePickerSelectDate.Dock = DockStyle.Left;
            dateTimePickerSelectDate.Font = new Font("Segoe UI", 11F);
            dateTimePickerSelectDate.Location = new Point(0, 0);
            dateTimePickerSelectDate.Margin = new Padding(0);
            dateTimePickerSelectDate.Name = "dateTimePickerSelectDate";
            dateTimePickerSelectDate.Size = new Size(400, 32);
            dateTimePickerSelectDate.TabIndex = 3;
            dateTimePickerSelectDate.ValueChanged += dateTimePickerSelectDate_ValueChanged;
            // 
            // textBoxSearchCustomer
            // 
            textBoxSearchCustomer.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearchCustomer.Dock = DockStyle.Right;
            textBoxSearchCustomer.Font = new Font("Segoe UI", 11F);
            textBoxSearchCustomer.Location = new Point(540, 0);
            textBoxSearchCustomer.Margin = new Padding(0);
            textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            textBoxSearchCustomer.Size = new Size(400, 32);
            textBoxSearchCustomer.TabIndex = 7;
            textBoxSearchCustomer.TextChanged += textBoxSearchCustomer_TextChanged;
            // 
            // dataGridViewReservation
            // 
            dataGridViewReservation.AllowUserToAddRows = false;
            dataGridViewReservation.AllowUserToResizeRows = false;
            dataGridViewReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReservation.BackgroundColor = Color.White;
            dataGridViewReservation.BorderStyle = BorderStyle.None;
            dataGridViewReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservation.Dock = DockStyle.Fill;
            dataGridViewReservation.Location = new Point(20, 182);
            dataGridViewReservation.Margin = new Padding(0, 0, 0, 20);
            dataGridViewReservation.Name = "dataGridViewReservation";
            dataGridViewReservation.ReadOnly = true;
            dataGridViewReservation.RowHeadersWidth = 51;
            dataGridViewReservation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReservation.Size = new Size(940, 400);
            dataGridViewReservation.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(buttonEditSelected);
            flowLayoutPanel2.Controls.Add(buttonDeleteSelected);
            flowLayoutPanel2.Controls.Add(buttonRefresh);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(20, 602);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(940, 50);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // buttonEditSelected
            // 
            buttonEditSelected.BackColor = Color.FromArgb(30, 58, 138);
            buttonEditSelected.FlatAppearance.BorderSize = 0;
            buttonEditSelected.FlatStyle = FlatStyle.Flat;
            buttonEditSelected.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditSelected.ForeColor = Color.White;
            buttonEditSelected.Location = new Point(0, 0);
            buttonEditSelected.Margin = new Padding(0, 0, 40, 0);
            buttonEditSelected.Name = "buttonEditSelected";
            buttonEditSelected.Size = new Size(200, 50);
            buttonEditSelected.TabIndex = 0;
            buttonEditSelected.Text = "Edit Selected";
            buttonEditSelected.UseVisualStyleBackColor = false;
            buttonEditSelected.Click += buttonEditSelected_Click;
            // 
            // buttonDeleteSelected
            // 
            buttonDeleteSelected.BackColor = Color.FromArgb(30, 58, 138);
            buttonDeleteSelected.FlatAppearance.BorderSize = 0;
            buttonDeleteSelected.FlatStyle = FlatStyle.Flat;
            buttonDeleteSelected.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteSelected.ForeColor = Color.White;
            buttonDeleteSelected.Location = new Point(240, 0);
            buttonDeleteSelected.Margin = new Padding(0, 0, 40, 0);
            buttonDeleteSelected.Name = "buttonDeleteSelected";
            buttonDeleteSelected.Size = new Size(200, 50);
            buttonDeleteSelected.TabIndex = 1;
            buttonDeleteSelected.Text = "Delete";
            buttonDeleteSelected.UseVisualStyleBackColor = false;
            buttonDeleteSelected.Click += buttonDeleteSelected_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.FromArgb(30, 58, 138);
            buttonRefresh.FlatAppearance.BorderSize = 0;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(480, 0);
            buttonRefresh.Margin = new Padding(0, 0, 40, 0);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(200, 50);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // EditReservationPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelHeader);
            Margin = new Padding(0);
            Name = "EditReservationPage";
            Size = new Size(980, 800);
            panelHeader.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservation).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelEditReservation;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePickerSelectDate;
        private Panel panel1;
        private TextBox textBoxSearchCustomer;
        private DataGridView dataGridViewReservation;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonEditSelected;
        private Button buttonDeleteSelected;
        private Button buttonRefresh;
    }
}

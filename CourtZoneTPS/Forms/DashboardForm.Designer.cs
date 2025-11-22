namespace CourtZoneTPS
{
    partial class DashboardForm
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
            components = new System.ComponentModel.Container();
            panelHeader = new Panel();
            labelDashboardDateTime = new Label();
            labelDashboardTitle = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTodaySummary = new Label();
            flpanelTodaySummary = new FlowLayoutPanel();
            panelTotalReservation = new Panel();
            labelTotalReservation = new Label();
            labelTotalReservationCount = new Label();
            panelTotalIncome = new Panel();
            labelTotalIncome = new Label();
            labelTotalIncomeCount = new Label();
            panelAvailableCourt = new Panel();
            labelPendingPayment = new Label();
            labelTotalPendingmayment = new Label();
            flpanelDailyReports = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            panel2 = new Panel();
            labelOpenCourt = new Label();
            labelOpenCourtIncome = new Label();
            panel3 = new Panel();
            label3 = new Label();
            labelCoveredCourtIncome = new Label();
            panel4 = new Panel();
            label4 = new Label();
            labelAirconditionedCourtIncome = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            dataGridViewTodayReservation = new DataGridView();
            panelHeader.SuspendLayout();
            flpanelTodaySummary.SuspendLayout();
            panelTotalReservation.SuspendLayout();
            panelTotalIncome.SuspendLayout();
            panelAvailableCourt.SuspendLayout();
            flpanelDailyReports.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTodayReservation).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(labelDashboardDateTime);
            panelHeader.Controls.Add(labelDashboardTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20);
            panelHeader.Size = new Size(980, 100);
            panelHeader.TabIndex = 0;
            // 
            // labelDashboardDateTime
            // 
            labelDashboardDateTime.BackColor = Color.Transparent;
            labelDashboardDateTime.Dock = DockStyle.Right;
            labelDashboardDateTime.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDashboardDateTime.ForeColor = Color.FromArgb(30, 58, 138);
            labelDashboardDateTime.Location = new Point(550, 20);
            labelDashboardDateTime.Margin = new Padding(0);
            labelDashboardDateTime.Name = "labelDashboardDateTime";
            labelDashboardDateTime.Size = new Size(410, 60);
            labelDashboardDateTime.TabIndex = 1;
            labelDashboardDateTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelDashboardTitle
            // 
            labelDashboardTitle.BackColor = Color.Transparent;
            labelDashboardTitle.Dock = DockStyle.Left;
            labelDashboardTitle.FlatStyle = FlatStyle.Flat;
            labelDashboardTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDashboardTitle.ForeColor = Color.FromArgb(30, 58, 138);
            labelDashboardTitle.Location = new Point(20, 20);
            labelDashboardTitle.Margin = new Padding(0);
            labelDashboardTitle.Name = "labelDashboardTitle";
            labelDashboardTitle.Size = new Size(284, 60);
            labelDashboardTitle.TabIndex = 0;
            labelDashboardTitle.Text = "Main Dashboard";
            labelDashboardTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // labelTodaySummary
            // 
            labelTodaySummary.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTodaySummary.ForeColor = Color.White;
            labelTodaySummary.Location = new Point(20, 20);
            labelTodaySummary.Margin = new Padding(0, 0, 0, 20);
            labelTodaySummary.Name = "labelTodaySummary";
            labelTodaySummary.Size = new Size(280, 50);
            labelTodaySummary.TabIndex = 1;
            labelTodaySummary.Text = "Today's Summary";
            labelTodaySummary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpanelTodaySummary
            // 
            flpanelTodaySummary.BackColor = Color.FromArgb(30, 58, 138);
            flpanelTodaySummary.Controls.Add(labelTodaySummary);
            flpanelTodaySummary.Controls.Add(panelTotalReservation);
            flpanelTodaySummary.Controls.Add(panelTotalIncome);
            flpanelTodaySummary.Controls.Add(panelAvailableCourt);
            flpanelTodaySummary.FlowDirection = FlowDirection.TopDown;
            flpanelTodaySummary.Location = new Point(20, 20);
            flpanelTodaySummary.Margin = new Padding(0, 0, 0, 20);
            flpanelTodaySummary.Name = "flpanelTodaySummary";
            flpanelTodaySummary.Padding = new Padding(20);
            flpanelTodaySummary.Size = new Size(310, 280);
            flpanelTodaySummary.TabIndex = 1;
            flpanelTodaySummary.WrapContents = false;
            // 
            // panelTotalReservation
            // 
            panelTotalReservation.Controls.Add(labelTotalReservation);
            panelTotalReservation.Controls.Add(labelTotalReservationCount);
            panelTotalReservation.Location = new Point(20, 90);
            panelTotalReservation.Margin = new Padding(0);
            panelTotalReservation.Name = "panelTotalReservation";
            panelTotalReservation.Size = new Size(280, 50);
            panelTotalReservation.TabIndex = 2;
            // 
            // labelTotalReservation
            // 
            labelTotalReservation.Dock = DockStyle.Left;
            labelTotalReservation.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalReservation.ForeColor = Color.White;
            labelTotalReservation.ImageAlign = ContentAlignment.MiddleRight;
            labelTotalReservation.Location = new Point(0, 0);
            labelTotalReservation.Margin = new Padding(0);
            labelTotalReservation.Name = "labelTotalReservation";
            labelTotalReservation.Size = new Size(166, 50);
            labelTotalReservation.TabIndex = 3;
            labelTotalReservation.Text = "Total Reservations";
            labelTotalReservation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTotalReservationCount
            // 
            labelTotalReservationCount.Dock = DockStyle.Right;
            labelTotalReservationCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalReservationCount.ForeColor = Color.White;
            labelTotalReservationCount.Location = new Point(180, 0);
            labelTotalReservationCount.Name = "labelTotalReservationCount";
            labelTotalReservationCount.Size = new Size(100, 50);
            labelTotalReservationCount.TabIndex = 3;
            labelTotalReservationCount.Text = "0";
            labelTotalReservationCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelTotalIncome
            // 
            panelTotalIncome.Controls.Add(labelTotalIncome);
            panelTotalIncome.Controls.Add(labelTotalIncomeCount);
            panelTotalIncome.Location = new Point(20, 140);
            panelTotalIncome.Margin = new Padding(0);
            panelTotalIncome.Name = "panelTotalIncome";
            panelTotalIncome.Size = new Size(280, 50);
            panelTotalIncome.TabIndex = 4;
            // 
            // labelTotalIncome
            // 
            labelTotalIncome.Dock = DockStyle.Left;
            labelTotalIncome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalIncome.ForeColor = Color.White;
            labelTotalIncome.ImageAlign = ContentAlignment.MiddleRight;
            labelTotalIncome.Location = new Point(0, 0);
            labelTotalIncome.Margin = new Padding(0);
            labelTotalIncome.Name = "labelTotalIncome";
            labelTotalIncome.Size = new Size(166, 50);
            labelTotalIncome.TabIndex = 3;
            labelTotalIncome.Text = "Total Income";
            labelTotalIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTotalIncomeCount
            // 
            labelTotalIncomeCount.Dock = DockStyle.Right;
            labelTotalIncomeCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalIncomeCount.ForeColor = Color.White;
            labelTotalIncomeCount.Location = new Point(180, 0);
            labelTotalIncomeCount.Name = "labelTotalIncomeCount";
            labelTotalIncomeCount.Size = new Size(100, 50);
            labelTotalIncomeCount.TabIndex = 3;
            labelTotalIncomeCount.Text = "0";
            labelTotalIncomeCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelAvailableCourt
            // 
            panelAvailableCourt.Controls.Add(labelPendingPayment);
            panelAvailableCourt.Controls.Add(labelTotalPendingmayment);
            panelAvailableCourt.Location = new Point(20, 190);
            panelAvailableCourt.Margin = new Padding(0);
            panelAvailableCourt.Name = "panelAvailableCourt";
            panelAvailableCourt.Size = new Size(280, 50);
            panelAvailableCourt.TabIndex = 5;
            // 
            // labelPendingPayment
            // 
            labelPendingPayment.Dock = DockStyle.Left;
            labelPendingPayment.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPendingPayment.ForeColor = Color.White;
            labelPendingPayment.ImageAlign = ContentAlignment.MiddleRight;
            labelPendingPayment.Location = new Point(0, 0);
            labelPendingPayment.Margin = new Padding(0);
            labelPendingPayment.Name = "labelPendingPayment";
            labelPendingPayment.Size = new Size(166, 50);
            labelPendingPayment.TabIndex = 3;
            labelPendingPayment.Text = "Pending Payment";
            labelPendingPayment.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTotalPendingmayment
            // 
            labelTotalPendingmayment.Dock = DockStyle.Right;
            labelTotalPendingmayment.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalPendingmayment.ForeColor = Color.White;
            labelTotalPendingmayment.Location = new Point(180, 0);
            labelTotalPendingmayment.Name = "labelTotalPendingmayment";
            labelTotalPendingmayment.Size = new Size(100, 50);
            labelTotalPendingmayment.TabIndex = 3;
            labelTotalPendingmayment.Text = "0";
            labelTotalPendingmayment.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flpanelDailyReports
            // 
            flpanelDailyReports.BackColor = Color.Transparent;
            flpanelDailyReports.Controls.Add(flpanelTodaySummary);
            flpanelDailyReports.Controls.Add(flowLayoutPanel2);
            flpanelDailyReports.Dock = DockStyle.Right;
            flpanelDailyReports.FlowDirection = FlowDirection.TopDown;
            flpanelDailyReports.Location = new Point(630, 100);
            flpanelDailyReports.Margin = new Padding(0);
            flpanelDailyReports.Name = "flpanelDailyReports";
            flpanelDailyReports.Padding = new Padding(20);
            flpanelDailyReports.Size = new Size(350, 700);
            flpanelDailyReports.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(30, 58, 138);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(20, 320);
            flowLayoutPanel2.Margin = new Padding(0, 0, 0, 70);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(20, 10, 20, 10);
            flowLayoutPanel2.Size = new Size(310, 250);
            flowLayoutPanel2.TabIndex = 2;
            flowLayoutPanel2.WrapContents = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 10);
            label2.Margin = new Padding(0, 0, 0, 20);
            label2.Name = "label2";
            label2.Size = new Size(280, 50);
            label2.TabIndex = 0;
            label2.Text = "Court Type Report";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelOpenCourt);
            panel2.Controls.Add(labelOpenCourtIncome);
            panel2.Location = new Point(20, 80);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 50);
            panel2.TabIndex = 1;
            // 
            // labelOpenCourt
            // 
            labelOpenCourt.Dock = DockStyle.Left;
            labelOpenCourt.Font = new Font("Segoe UI", 10.8F);
            labelOpenCourt.ForeColor = Color.White;
            labelOpenCourt.Location = new Point(0, 0);
            labelOpenCourt.Name = "labelOpenCourt";
            labelOpenCourt.Size = new Size(179, 50);
            labelOpenCourt.TabIndex = 0;
            labelOpenCourt.Text = "Open Court";
            // 
            // labelOpenCourtIncome
            // 
            labelOpenCourtIncome.Dock = DockStyle.Right;
            labelOpenCourtIncome.Font = new Font("Segoe UI", 10.8F);
            labelOpenCourtIncome.ForeColor = Color.White;
            labelOpenCourtIncome.Location = new Point(178, 0);
            labelOpenCourtIncome.Name = "labelOpenCourtIncome";
            labelOpenCourtIncome.Size = new Size(102, 50);
            labelOpenCourtIncome.TabIndex = 1;
            labelOpenCourtIncome.Text = "0";
            labelOpenCourtIncome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(labelCoveredCourtIncome);
            panel3.Location = new Point(20, 130);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 50);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(179, 50);
            label3.TabIndex = 0;
            label3.Text = "Covered Court";
            // 
            // labelCoveredCourtIncome
            // 
            labelCoveredCourtIncome.Dock = DockStyle.Right;
            labelCoveredCourtIncome.Font = new Font("Segoe UI", 10.8F);
            labelCoveredCourtIncome.ForeColor = Color.White;
            labelCoveredCourtIncome.Location = new Point(178, 0);
            labelCoveredCourtIncome.Name = "labelCoveredCourtIncome";
            labelCoveredCourtIncome.Size = new Size(102, 50);
            labelCoveredCourtIncome.TabIndex = 1;
            labelCoveredCourtIncome.Text = "0";
            labelCoveredCourtIncome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(labelAirconditionedCourtIncome);
            panel4.Location = new Point(20, 180);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(280, 50);
            panel4.TabIndex = 3;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(179, 50);
            label4.TabIndex = 0;
            label4.Text = "Airconditioned Court";
            // 
            // labelAirconditionedCourtIncome
            // 
            labelAirconditionedCourtIncome.Dock = DockStyle.Right;
            labelAirconditionedCourtIncome.Font = new Font("Segoe UI", 10.8F);
            labelAirconditionedCourtIncome.ForeColor = Color.White;
            labelAirconditionedCourtIncome.Location = new Point(178, 0);
            labelAirconditionedCourtIncome.Name = "labelAirconditionedCourtIncome";
            labelAirconditionedCourtIncome.Size = new Size(102, 50);
            labelAirconditionedCourtIncome.TabIndex = 1;
            labelAirconditionedCourtIncome.Text = "0";
            labelAirconditionedCourtIncome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 100);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(630, 700);
            panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(dataGridViewTodayReservation);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 20, 0, 0);
            flowLayoutPanel1.Size = new Size(630, 700);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 20);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(530, 50);
            label1.TabIndex = 0;
            label1.Text = "Today's Reservation";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridViewTodayReservation
            // 
            dataGridViewTodayReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTodayReservation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTodayReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTodayReservation.Location = new Point(20, 70);
            dataGridViewTodayReservation.Margin = new Padding(0);
            dataGridViewTodayReservation.Name = "dataGridViewTodayReservation";
            dataGridViewTodayReservation.RowHeadersWidth = 51;
            dataGridViewTodayReservation.Size = new Size(610, 250);
            dataGridViewTodayReservation.TabIndex = 1;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(panel1);
            Controls.Add(flpanelDailyReports);
            Controls.Add(panelHeader);
            Margin = new Padding(0);
            Name = "DashboardForm";
            Size = new Size(980, 800);
            panelHeader.ResumeLayout(false);
            flpanelTodaySummary.ResumeLayout(false);
            panelTotalReservation.ResumeLayout(false);
            panelTotalIncome.ResumeLayout(false);
            panelAvailableCourt.ResumeLayout(false);
            flpanelDailyReports.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTodayReservation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelDashboardTitle;
        private System.Windows.Forms.Timer timer1;
        private Label labelDashboardDateTime;
        private Label labelTodaySummary;
        private FlowLayoutPanel flpanelTodaySummary;
        private Panel panelTotalReservation;
        private Label labelTotalReservation;
        private Label labelTotalReservationCount;
        private Panel panelTotalIncome;
        private Label labelTotalIncome;
        private Label labelTotalIncomeCount;
        private Panel panelAvailableCourt;
        private Label labelPendingPayment;
        private Label labelTotalPendingmayment;
        private FlowLayoutPanel flpanelDailyReports;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private DataGridView dataGridViewTodayReservation;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private Panel panel2;
        private Label labelOpenCourt;
        private Label labelOpenCourtIncome;
        private Panel panel3;
        private Label label3;
        private Label labelCoveredCourtIncome;
        private Panel panel4;
        private Label label4;
        private Label labelAirconditionedCourtIncome;
    }
}

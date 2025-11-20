namespace CourtZoneTPS
{
    partial class DashboardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPage));
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
            labelAvailableCourt = new Label();
            labelAvailableCourtCount = new Label();
            flpanelDailyReports = new FlowLayoutPanel();
            flpanelUpcomingReservation = new FlowLayoutPanel();
            labelUpcomingReservation = new Label();
            panelCustomer1 = new Panel();
            labelCustomer1Name = new Label();
            labelCustomer1Time = new Label();
            panelCustomer2 = new Panel();
            labelCustomer2Name = new Label();
            labelCustomer2Time = new Label();
            panelCustomer3 = new Panel();
            labelCustomer3Name = new Label();
            labelCustomer3Time = new Label();
            panelCalendar = new Panel();
            panelHeader.SuspendLayout();
            flpanelTodaySummary.SuspendLayout();
            panelTotalReservation.SuspendLayout();
            panelTotalIncome.SuspendLayout();
            panelAvailableCourt.SuspendLayout();
            flpanelDailyReports.SuspendLayout();
            flpanelUpcomingReservation.SuspendLayout();
            panelCustomer1.SuspendLayout();
            panelCustomer2.SuspendLayout();
            panelCustomer3.SuspendLayout();
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
            timer1.Tick += timer1_Tick;
            // 
            // labelTodaySummary
            // 
            labelTodaySummary.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTodaySummary.ForeColor = Color.White;
            labelTodaySummary.Location = new Point(20, 20);
            labelTodaySummary.Margin = new Padding(0, 0, 0, 20);
            labelTodaySummary.Name = "labelTodaySummary";
            labelTodaySummary.Size = new Size(370, 50);
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
            flpanelTodaySummary.Size = new Size(410, 280);
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
            panelTotalReservation.Size = new Size(370, 50);
            panelTotalReservation.TabIndex = 2;
            // 
            // labelTotalReservation
            // 
            labelTotalReservation.Dock = DockStyle.Left;
            labelTotalReservation.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalReservation.ForeColor = Color.White;
            labelTotalReservation.Image = (Image)resources.GetObject("labelTotalReservation.Image");
            labelTotalReservation.ImageAlign = ContentAlignment.MiddleRight;
            labelTotalReservation.Location = new Point(0, 0);
            labelTotalReservation.Margin = new Padding(0);
            labelTotalReservation.Name = "labelTotalReservation";
            labelTotalReservation.Size = new Size(200, 50);
            labelTotalReservation.TabIndex = 3;
            labelTotalReservation.Text = "Total Reservations";
            labelTotalReservation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTotalReservationCount
            // 
            labelTotalReservationCount.Dock = DockStyle.Right;
            labelTotalReservationCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalReservationCount.ForeColor = Color.White;
            labelTotalReservationCount.Location = new Point(270, 0);
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
            panelTotalIncome.Size = new Size(370, 50);
            panelTotalIncome.TabIndex = 4;
            // 
            // labelTotalIncome
            // 
            labelTotalIncome.Dock = DockStyle.Left;
            labelTotalIncome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalIncome.ForeColor = Color.White;
            labelTotalIncome.Image = (Image)resources.GetObject("labelTotalIncome.Image");
            labelTotalIncome.ImageAlign = ContentAlignment.MiddleRight;
            labelTotalIncome.Location = new Point(0, 0);
            labelTotalIncome.Margin = new Padding(0);
            labelTotalIncome.Name = "labelTotalIncome";
            labelTotalIncome.Size = new Size(200, 50);
            labelTotalIncome.TabIndex = 3;
            labelTotalIncome.Text = "Total Income";
            labelTotalIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTotalIncomeCount
            // 
            labelTotalIncomeCount.Dock = DockStyle.Right;
            labelTotalIncomeCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalIncomeCount.ForeColor = Color.White;
            labelTotalIncomeCount.Location = new Point(270, 0);
            labelTotalIncomeCount.Name = "labelTotalIncomeCount";
            labelTotalIncomeCount.Size = new Size(100, 50);
            labelTotalIncomeCount.TabIndex = 3;
            labelTotalIncomeCount.Text = "0";
            labelTotalIncomeCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelAvailableCourt
            // 
            panelAvailableCourt.Controls.Add(labelAvailableCourt);
            panelAvailableCourt.Controls.Add(labelAvailableCourtCount);
            panelAvailableCourt.Location = new Point(20, 190);
            panelAvailableCourt.Margin = new Padding(0);
            panelAvailableCourt.Name = "panelAvailableCourt";
            panelAvailableCourt.Size = new Size(370, 50);
            panelAvailableCourt.TabIndex = 5;
            // 
            // labelAvailableCourt
            // 
            labelAvailableCourt.Dock = DockStyle.Left;
            labelAvailableCourt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAvailableCourt.ForeColor = Color.White;
            labelAvailableCourt.Image = (Image)resources.GetObject("labelAvailableCourt.Image");
            labelAvailableCourt.ImageAlign = ContentAlignment.MiddleRight;
            labelAvailableCourt.Location = new Point(0, 0);
            labelAvailableCourt.Margin = new Padding(0);
            labelAvailableCourt.Name = "labelAvailableCourt";
            labelAvailableCourt.Size = new Size(200, 50);
            labelAvailableCourt.TabIndex = 3;
            labelAvailableCourt.Text = "Available Courts";
            labelAvailableCourt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAvailableCourtCount
            // 
            labelAvailableCourtCount.Dock = DockStyle.Right;
            labelAvailableCourtCount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAvailableCourtCount.ForeColor = Color.White;
            labelAvailableCourtCount.Location = new Point(270, 0);
            labelAvailableCourtCount.Name = "labelAvailableCourtCount";
            labelAvailableCourtCount.Size = new Size(100, 50);
            labelAvailableCourtCount.TabIndex = 3;
            labelAvailableCourtCount.Text = "0";
            labelAvailableCourtCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flpanelDailyReports
            // 
            flpanelDailyReports.BackColor = Color.Transparent;
            flpanelDailyReports.Controls.Add(flpanelTodaySummary);
            flpanelDailyReports.Controls.Add(flpanelUpcomingReservation);
            flpanelDailyReports.Dock = DockStyle.Right;
            flpanelDailyReports.FlowDirection = FlowDirection.TopDown;
            flpanelDailyReports.Location = new Point(530, 100);
            flpanelDailyReports.Margin = new Padding(0);
            flpanelDailyReports.Name = "flpanelDailyReports";
            flpanelDailyReports.Padding = new Padding(20);
            flpanelDailyReports.Size = new Size(450, 700);
            flpanelDailyReports.TabIndex = 2;
            // 
            // flpanelUpcomingReservation
            // 
            flpanelUpcomingReservation.BackColor = Color.FromArgb(30, 58, 138);
            flpanelUpcomingReservation.Controls.Add(labelUpcomingReservation);
            flpanelUpcomingReservation.Controls.Add(panelCustomer1);
            flpanelUpcomingReservation.Controls.Add(panelCustomer2);
            flpanelUpcomingReservation.Controls.Add(panelCustomer3);
            flpanelUpcomingReservation.FlowDirection = FlowDirection.TopDown;
            flpanelUpcomingReservation.Location = new Point(20, 320);
            flpanelUpcomingReservation.Margin = new Padding(0, 0, 0, 20);
            flpanelUpcomingReservation.Name = "flpanelUpcomingReservation";
            flpanelUpcomingReservation.Padding = new Padding(20);
            flpanelUpcomingReservation.Size = new Size(410, 280);
            flpanelUpcomingReservation.TabIndex = 6;
            flpanelUpcomingReservation.WrapContents = false;
            // 
            // labelUpcomingReservation
            // 
            labelUpcomingReservation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUpcomingReservation.ForeColor = Color.White;
            labelUpcomingReservation.Location = new Point(20, 20);
            labelUpcomingReservation.Margin = new Padding(0, 0, 0, 20);
            labelUpcomingReservation.Name = "labelUpcomingReservation";
            labelUpcomingReservation.Size = new Size(370, 50);
            labelUpcomingReservation.TabIndex = 1;
            labelUpcomingReservation.Text = "Upcoming Reservations";
            labelUpcomingReservation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCustomer1
            // 
            panelCustomer1.Controls.Add(labelCustomer1Name);
            panelCustomer1.Controls.Add(labelCustomer1Time);
            panelCustomer1.Location = new Point(20, 90);
            panelCustomer1.Margin = new Padding(0);
            panelCustomer1.Name = "panelCustomer1";
            panelCustomer1.Size = new Size(370, 50);
            panelCustomer1.TabIndex = 2;
            // 
            // labelCustomer1Name
            // 
            labelCustomer1Name.Dock = DockStyle.Left;
            labelCustomer1Name.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCustomer1Name.ForeColor = Color.White;
            labelCustomer1Name.ImageAlign = ContentAlignment.MiddleRight;
            labelCustomer1Name.Location = new Point(0, 0);
            labelCustomer1Name.Margin = new Padding(0);
            labelCustomer1Name.Name = "labelCustomer1Name";
            labelCustomer1Name.Size = new Size(267, 50);
            labelCustomer1Name.TabIndex = 3;
            labelCustomer1Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCustomer1Time
            // 
            labelCustomer1Time.Dock = DockStyle.Right;
            labelCustomer1Time.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCustomer1Time.ForeColor = Color.White;
            labelCustomer1Time.Location = new Point(270, 0);
            labelCustomer1Time.Name = "labelCustomer1Time";
            labelCustomer1Time.Size = new Size(100, 50);
            labelCustomer1Time.TabIndex = 3;
            labelCustomer1Time.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelCustomer2
            // 
            panelCustomer2.Controls.Add(labelCustomer2Name);
            panelCustomer2.Controls.Add(labelCustomer2Time);
            panelCustomer2.Location = new Point(20, 140);
            panelCustomer2.Margin = new Padding(0);
            panelCustomer2.Name = "panelCustomer2";
            panelCustomer2.Size = new Size(370, 50);
            panelCustomer2.TabIndex = 4;
            // 
            // labelCustomer2Name
            // 
            labelCustomer2Name.Dock = DockStyle.Left;
            labelCustomer2Name.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCustomer2Name.ForeColor = Color.White;
            labelCustomer2Name.ImageAlign = ContentAlignment.MiddleRight;
            labelCustomer2Name.Location = new Point(0, 0);
            labelCustomer2Name.Margin = new Padding(0);
            labelCustomer2Name.Name = "labelCustomer2Name";
            labelCustomer2Name.Size = new Size(267, 50);
            labelCustomer2Name.TabIndex = 3;
            labelCustomer2Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCustomer2Time
            // 
            labelCustomer2Time.Dock = DockStyle.Right;
            labelCustomer2Time.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCustomer2Time.ForeColor = Color.White;
            labelCustomer2Time.Location = new Point(270, 0);
            labelCustomer2Time.Name = "labelCustomer2Time";
            labelCustomer2Time.Size = new Size(100, 50);
            labelCustomer2Time.TabIndex = 3;
            labelCustomer2Time.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelCustomer3
            // 
            panelCustomer3.Controls.Add(labelCustomer3Name);
            panelCustomer3.Controls.Add(labelCustomer3Time);
            panelCustomer3.Location = new Point(20, 190);
            panelCustomer3.Margin = new Padding(0);
            panelCustomer3.Name = "panelCustomer3";
            panelCustomer3.Size = new Size(370, 50);
            panelCustomer3.TabIndex = 5;
            // 
            // labelCustomer3Name
            // 
            labelCustomer3Name.Dock = DockStyle.Left;
            labelCustomer3Name.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCustomer3Name.ForeColor = Color.White;
            labelCustomer3Name.ImageAlign = ContentAlignment.MiddleRight;
            labelCustomer3Name.Location = new Point(0, 0);
            labelCustomer3Name.Margin = new Padding(0);
            labelCustomer3Name.Name = "labelCustomer3Name";
            labelCustomer3Name.Size = new Size(267, 50);
            labelCustomer3Name.TabIndex = 3;
            labelCustomer3Name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCustomer3Time
            // 
            labelCustomer3Time.Dock = DockStyle.Right;
            labelCustomer3Time.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCustomer3Time.ForeColor = Color.White;
            labelCustomer3Time.Location = new Point(270, 0);
            labelCustomer3Time.Name = "labelCustomer3Time";
            labelCustomer3Time.Size = new Size(100, 50);
            labelCustomer3Time.TabIndex = 3;
            labelCustomer3Time.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelCalendar
            // 
            panelCalendar.Dock = DockStyle.Fill;
            panelCalendar.Location = new Point(0, 100);
            panelCalendar.Margin = new Padding(0);
            panelCalendar.Name = "panelCalendar";
            panelCalendar.Padding = new Padding(20);
            panelCalendar.Size = new Size(530, 700);
            panelCalendar.TabIndex = 3;
            // 
            // DashboardPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            Controls.Add(panelCalendar);
            Controls.Add(flpanelDailyReports);
            Controls.Add(panelHeader);
            Margin = new Padding(0);
            Name = "DashboardPage";
            Size = new Size(980, 800);
            panelHeader.ResumeLayout(false);
            flpanelTodaySummary.ResumeLayout(false);
            panelTotalReservation.ResumeLayout(false);
            panelTotalIncome.ResumeLayout(false);
            panelAvailableCourt.ResumeLayout(false);
            flpanelDailyReports.ResumeLayout(false);
            flpanelUpcomingReservation.ResumeLayout(false);
            panelCustomer1.ResumeLayout(false);
            panelCustomer2.ResumeLayout(false);
            panelCustomer3.ResumeLayout(false);
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
        private Label labelAvailableCourt;
        private Label labelAvailableCourtCount;
        private FlowLayoutPanel flpanelDailyReports;
        private FlowLayoutPanel flpanelUpcomingReservation;
        private Label labelUpcomingReservation;
        private Panel panelCustomer1;
        private Label labelCustomer1Name;
        private Label labelCustomer1Time;
        private Panel panelCustomer2;
        private Label labelCustomer2Name;
        private Label labelCustomer2Time;
        private Panel panelCustomer3;
        private Label labelCustomer3Name;
        private Label labelCustomer3Time;
        private Panel panelCalendar;
    }
}

namespace CourtZoneTPS
{
    partial class ReportsPage
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
            labelReports = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panelDateRange = new Panel();
            comboBoxDateRange = new ComboBox();
            labelDateRange = new Label();
            panelGenerate = new Panel();
            buttonGenerateReport = new Button();
            panel1 = new Panel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label6 = new Label();
            dataGridViewBasketball = new DataGridView();
            flowLayoutPanel7 = new FlowLayoutPanel();
            label7 = new Label();
            dataGridViewVolleyball = new DataGridView();
            flowLayoutPanel8 = new FlowLayoutPanel();
            label8 = new Label();
            dataGridViewBadminton = new DataGridView();
            flowLayoutPanel9 = new FlowLayoutPanel();
            label9 = new Label();
            dataGridViewTennis = new DataGridView();
            dataGridViewSports = new DataGridView();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flpanelTodaySummary = new FlowLayoutPanel();
            labelTodaySummary = new Label();
            panelTotalReservation = new Panel();
            labelOpenCourt = new Label();
            labelOpenCourtIncome = new Label();
            panelTotalIncome = new Panel();
            labelTotalIncome = new Label();
            labelCoveredCourtIncome = new Label();
            panelAvailableCourt = new Panel();
            labelAvailableCourt = new Label();
            labelAirconditionedCourtIncome = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label2 = new Label();
            panel2 = new Panel();
            emplloyee1Income = new Label();
            panel3 = new Panel();
            employee2Income = new Label();
            panelHeader.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panelDateRange.SuspendLayout();
            panelGenerate.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBasketball).BeginInit();
            flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVolleyball).BeginInit();
            flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBadminton).BeginInit();
            flowLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTennis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSports).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            flpanelTodaySummary.SuspendLayout();
            panelTotalReservation.SuspendLayout();
            panelTotalIncome.SuspendLayout();
            panelAvailableCourt.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(labelReports);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20);
            panelHeader.Size = new Size(980, 100);
            panelHeader.TabIndex = 2;
            // 
            // labelReports
            // 
            labelReports.BackColor = Color.Transparent;
            labelReports.Dock = DockStyle.Left;
            labelReports.FlatStyle = FlatStyle.Flat;
            labelReports.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelReports.ForeColor = Color.FromArgb(30, 58, 138);
            labelReports.Location = new Point(20, 20);
            labelReports.Margin = new Padding(0);
            labelReports.Name = "labelReports";
            labelReports.Size = new Size(284, 60);
            labelReports.TabIndex = 0;
            labelReports.Text = "Income Report";
            labelReports.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 100);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20);
            flowLayoutPanel1.Size = new Size(980, 700);
            flowLayoutPanel1.TabIndex = 3;
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
            label1.TabIndex = 1;
            label1.Text = "Select a date range and a report type";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panelDateRange);
            flowLayoutPanel2.Controls.Add(panelGenerate);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(20, 70);
            flowLayoutPanel2.Margin = new Padding(0, 0, 0, 20);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(940, 70);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // panelDateRange
            // 
            panelDateRange.Controls.Add(comboBoxDateRange);
            panelDateRange.Controls.Add(labelDateRange);
            panelDateRange.Location = new Point(0, 0);
            panelDateRange.Margin = new Padding(0, 0, 20, 0);
            panelDateRange.Name = "panelDateRange";
            panelDateRange.Size = new Size(250, 70);
            panelDateRange.TabIndex = 0;
            // 
            // comboBoxDateRange
            // 
            comboBoxDateRange.Dock = DockStyle.Bottom;
            comboBoxDateRange.Font = new Font("Segoe UI", 10F);
            comboBoxDateRange.FormattingEnabled = true;
            comboBoxDateRange.Location = new Point(0, 39);
            comboBoxDateRange.Margin = new Padding(0);
            comboBoxDateRange.Name = "comboBoxDateRange";
            comboBoxDateRange.Size = new Size(250, 31);
            comboBoxDateRange.TabIndex = 5;
            // 
            // labelDateRange
            // 
            labelDateRange.Dock = DockStyle.Top;
            labelDateRange.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDateRange.Location = new Point(0, 0);
            labelDateRange.Margin = new Padding(0);
            labelDateRange.Name = "labelDateRange";
            labelDateRange.Size = new Size(250, 28);
            labelDateRange.TabIndex = 3;
            labelDateRange.Text = "Range";
            // 
            // panelGenerate
            // 
            panelGenerate.Controls.Add(buttonGenerateReport);
            panelGenerate.Location = new Point(270, 0);
            panelGenerate.Margin = new Padding(0, 0, 20, 0);
            panelGenerate.Name = "panelGenerate";
            panelGenerate.Size = new Size(200, 70);
            panelGenerate.TabIndex = 4;
            // 
            // buttonGenerateReport
            // 
            buttonGenerateReport.BackColor = Color.FromArgb(30, 58, 138);
            buttonGenerateReport.Dock = DockStyle.Bottom;
            buttonGenerateReport.FlatAppearance.BorderSize = 0;
            buttonGenerateReport.FlatStyle = FlatStyle.Flat;
            buttonGenerateReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonGenerateReport.ForeColor = Color.White;
            buttonGenerateReport.Location = new Point(0, 39);
            buttonGenerateReport.Margin = new Padding(0, 0, 0, 20);
            buttonGenerateReport.Name = "buttonGenerateReport";
            buttonGenerateReport.Size = new Size(200, 31);
            buttonGenerateReport.TabIndex = 3;
            buttonGenerateReport.Text = "Generate";
            buttonGenerateReport.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = new Size(0, 650);
            panel1.Controls.Add(flowLayoutPanel5);
            panel1.Controls.Add(flowLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(20, 160);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(940, 520);
            panel1.TabIndex = 3;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoScroll = true;
            flowLayoutPanel5.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel5.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel5.Controls.Add(flowLayoutPanel8);
            flowLayoutPanel5.Controls.Add(flowLayoutPanel9);
            flowLayoutPanel5.Controls.Add(dataGridViewSports);
            flowLayoutPanel5.Dock = DockStyle.Fill;
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(330, 0);
            flowLayoutPanel5.Margin = new Padding(0);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(589, 650);
            flowLayoutPanel5.TabIndex = 3;
            flowLayoutPanel5.WrapContents = false;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(label6);
            flowLayoutPanel6.Controls.Add(dataGridViewBasketball);
            flowLayoutPanel6.Location = new Point(0, 0);
            flowLayoutPanel6.Margin = new Padding(0, 0, 0, 10);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(550, 120);
            flowLayoutPanel6.TabIndex = 0;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(0, 0);
            label6.Margin = new Padding(0, 0, 0, 5);
            label6.Name = "label6";
            label6.Size = new Size(550, 25);
            label6.TabIndex = 0;
            label6.Text = "Basketball";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewBasketball
            // 
            dataGridViewBasketball.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBasketball.Dock = DockStyle.Top;
            dataGridViewBasketball.Location = new Point(0, 30);
            dataGridViewBasketball.Margin = new Padding(0);
            dataGridViewBasketball.Name = "dataGridViewBasketball";
            dataGridViewBasketball.RowHeadersWidth = 51;
            dataGridViewBasketball.ScrollBars = ScrollBars.None;
            dataGridViewBasketball.Size = new Size(550, 100);
            dataGridViewBasketball.TabIndex = 1;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(label7);
            flowLayoutPanel7.Controls.Add(dataGridViewVolleyball);
            flowLayoutPanel7.Location = new Point(0, 130);
            flowLayoutPanel7.Margin = new Padding(0, 0, 0, 10);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(550, 120);
            flowLayoutPanel7.TabIndex = 1;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(0, 0);
            label7.Margin = new Padding(0, 0, 0, 5);
            label7.Name = "label7";
            label7.Size = new Size(550, 25);
            label7.TabIndex = 0;
            label7.Text = "Volleyball";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewVolleyball
            // 
            dataGridViewVolleyball.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVolleyball.Dock = DockStyle.Top;
            dataGridViewVolleyball.Location = new Point(0, 30);
            dataGridViewVolleyball.Margin = new Padding(0);
            dataGridViewVolleyball.Name = "dataGridViewVolleyball";
            dataGridViewVolleyball.RowHeadersWidth = 51;
            dataGridViewVolleyball.ScrollBars = ScrollBars.None;
            dataGridViewVolleyball.Size = new Size(550, 100);
            dataGridViewVolleyball.TabIndex = 1;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Controls.Add(label8);
            flowLayoutPanel8.Controls.Add(dataGridViewBadminton);
            flowLayoutPanel8.Location = new Point(0, 260);
            flowLayoutPanel8.Margin = new Padding(0, 0, 0, 10);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(550, 120);
            flowLayoutPanel8.TabIndex = 2;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(0, 0);
            label8.Margin = new Padding(0, 0, 0, 5);
            label8.Name = "label8";
            label8.Size = new Size(550, 25);
            label8.TabIndex = 0;
            label8.Text = "Badminton";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewBadminton
            // 
            dataGridViewBadminton.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBadminton.Dock = DockStyle.Top;
            dataGridViewBadminton.Location = new Point(0, 30);
            dataGridViewBadminton.Margin = new Padding(0);
            dataGridViewBadminton.Name = "dataGridViewBadminton";
            dataGridViewBadminton.RowHeadersWidth = 51;
            dataGridViewBadminton.ScrollBars = ScrollBars.None;
            dataGridViewBadminton.Size = new Size(550, 100);
            dataGridViewBadminton.TabIndex = 1;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Controls.Add(label9);
            flowLayoutPanel9.Controls.Add(dataGridViewTennis);
            flowLayoutPanel9.Location = new Point(0, 390);
            flowLayoutPanel9.Margin = new Padding(0, 0, 0, 10);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(550, 120);
            flowLayoutPanel9.TabIndex = 3;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(0, 0);
            label9.Margin = new Padding(0, 0, 0, 5);
            label9.Name = "label9";
            label9.Size = new Size(550, 25);
            label9.TabIndex = 0;
            label9.Text = "Tennis";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTennis
            // 
            dataGridViewTennis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTennis.Dock = DockStyle.Top;
            dataGridViewTennis.Location = new Point(0, 30);
            dataGridViewTennis.Margin = new Padding(0, 0, 0, 5);
            dataGridViewTennis.Name = "dataGridViewTennis";
            dataGridViewTennis.RowHeadersWidth = 51;
            dataGridViewTennis.ScrollBars = ScrollBars.None;
            dataGridViewTennis.Size = new Size(550, 100);
            dataGridViewTennis.TabIndex = 1;
            // 
            // dataGridViewSports
            // 
            dataGridViewSports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSports.Location = new Point(0, 520);
            dataGridViewSports.Margin = new Padding(0);
            dataGridViewSports.Name = "dataGridViewSports";
            dataGridViewSports.RowHeadersWidth = 51;
            dataGridViewSports.ScrollBars = ScrollBars.None;
            dataGridViewSports.Size = new Size(550, 100);
            dataGridViewSports.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(flpanelTodaySummary);
            flowLayoutPanel3.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Margin = new Padding(0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(330, 650);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // flpanelTodaySummary
            // 
            flpanelTodaySummary.BackColor = Color.FromArgb(30, 58, 138);
            flpanelTodaySummary.Controls.Add(labelTodaySummary);
            flpanelTodaySummary.Controls.Add(panelTotalReservation);
            flpanelTodaySummary.Controls.Add(panelTotalIncome);
            flpanelTodaySummary.Controls.Add(panelAvailableCourt);
            flpanelTodaySummary.FlowDirection = FlowDirection.TopDown;
            flpanelTodaySummary.Location = new Point(0, 0);
            flpanelTodaySummary.Margin = new Padding(0, 0, 0, 70);
            flpanelTodaySummary.Name = "flpanelTodaySummary";
            flpanelTodaySummary.Padding = new Padding(20, 10, 20, 10);
            flpanelTodaySummary.Size = new Size(310, 250);
            flpanelTodaySummary.TabIndex = 0;
            flpanelTodaySummary.WrapContents = false;
            // 
            // labelTodaySummary
            // 
            labelTodaySummary.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelTodaySummary.ForeColor = Color.White;
            labelTodaySummary.Location = new Point(20, 10);
            labelTodaySummary.Margin = new Padding(0, 0, 0, 20);
            labelTodaySummary.Name = "labelTodaySummary";
            labelTodaySummary.Size = new Size(280, 50);
            labelTodaySummary.TabIndex = 0;
            labelTodaySummary.Text = "Court Type Report";
            labelTodaySummary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTotalReservation
            // 
            panelTotalReservation.Controls.Add(labelOpenCourt);
            panelTotalReservation.Controls.Add(labelOpenCourtIncome);
            panelTotalReservation.Location = new Point(20, 80);
            panelTotalReservation.Margin = new Padding(0);
            panelTotalReservation.Name = "panelTotalReservation";
            panelTotalReservation.Size = new Size(280, 50);
            panelTotalReservation.TabIndex = 1;
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
            // panelTotalIncome
            // 
            panelTotalIncome.Controls.Add(labelTotalIncome);
            panelTotalIncome.Controls.Add(labelCoveredCourtIncome);
            panelTotalIncome.Location = new Point(20, 130);
            panelTotalIncome.Margin = new Padding(0);
            panelTotalIncome.Name = "panelTotalIncome";
            panelTotalIncome.Size = new Size(280, 50);
            panelTotalIncome.TabIndex = 2;
            // 
            // labelTotalIncome
            // 
            labelTotalIncome.Dock = DockStyle.Left;
            labelTotalIncome.Font = new Font("Segoe UI", 10.8F);
            labelTotalIncome.ForeColor = Color.White;
            labelTotalIncome.Location = new Point(0, 0);
            labelTotalIncome.Name = "labelTotalIncome";
            labelTotalIncome.Size = new Size(179, 50);
            labelTotalIncome.TabIndex = 0;
            labelTotalIncome.Text = "Covered Court";
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
            // panelAvailableCourt
            // 
            panelAvailableCourt.Controls.Add(labelAvailableCourt);
            panelAvailableCourt.Controls.Add(labelAirconditionedCourtIncome);
            panelAvailableCourt.Location = new Point(20, 180);
            panelAvailableCourt.Margin = new Padding(0);
            panelAvailableCourt.Name = "panelAvailableCourt";
            panelAvailableCourt.Size = new Size(280, 50);
            panelAvailableCourt.TabIndex = 3;
            // 
            // labelAvailableCourt
            // 
            labelAvailableCourt.Dock = DockStyle.Left;
            labelAvailableCourt.Font = new Font("Segoe UI", 10.8F);
            labelAvailableCourt.ForeColor = Color.White;
            labelAvailableCourt.Location = new Point(0, 0);
            labelAvailableCourt.Name = "labelAvailableCourt";
            labelAvailableCourt.Size = new Size(179, 50);
            labelAvailableCourt.TabIndex = 0;
            labelAvailableCourt.Text = "Airconditioned Court";
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
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.FromArgb(30, 58, 138);
            flowLayoutPanel4.Controls.Add(label2);
            flowLayoutPanel4.Controls.Add(panel2);
            flowLayoutPanel4.Controls.Add(panel3);
            flowLayoutPanel4.Dock = DockStyle.Bottom;
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(0, 320);
            flowLayoutPanel4.Margin = new Padding(0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(20, 10, 20, 10);
            flowLayoutPanel4.Size = new Size(310, 200);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 10);
            label2.Name = "label2";
            label2.Size = new Size(277, 50);
            label2.TabIndex = 0;
            label2.Text = "Employee Report";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(emplloyee1Income);
            panel2.Location = new Point(20, 60);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 50);
            panel2.TabIndex = 1;
            // 
            // emplloyee1Income
            // 
            emplloyee1Income.Dock = DockStyle.Right;
            emplloyee1Income.Font = new Font("Segoe UI", 10.8F);
            emplloyee1Income.ForeColor = Color.White;
            emplloyee1Income.Location = new Point(0, 0);
            emplloyee1Income.Name = "emplloyee1Income";
            emplloyee1Income.Size = new Size(280, 50);
            emplloyee1Income.TabIndex = 1;
            emplloyee1Income.Text = "0";
            emplloyee1Income.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(employee2Income);
            panel3.Location = new Point(20, 110);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 50);
            panel3.TabIndex = 2;
            // 
            // employee2Income
            // 
            employee2Income.Dock = DockStyle.Right;
            employee2Income.Font = new Font("Segoe UI", 10.8F);
            employee2Income.ForeColor = Color.White;
            employee2Income.Location = new Point(0, 0);
            employee2Income.Name = "employee2Income";
            employee2Income.Size = new Size(280, 50);
            employee2Income.TabIndex = 1;
            employee2Income.Text = "0";
            employee2Income.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ReportsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelHeader);
            Margin = new Padding(0);
            Name = "ReportsPage";
            Size = new Size(980, 800);
            panelHeader.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panelDateRange.ResumeLayout(false);
            panelGenerate.ResumeLayout(false);
            panel1.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBasketball).EndInit();
            flowLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVolleyball).EndInit();
            flowLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBadminton).EndInit();
            flowLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTennis).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSports).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flpanelTodaySummary.ResumeLayout(false);
            panelTotalReservation.ResumeLayout(false);
            panelTotalIncome.ResumeLayout(false);
            panelAvailableCourt.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelReports;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panelDateRange;
        private Label labelDateRange;
        private Button buttonGenerateReport;
        private ComboBox comboBoxDateRange;
        private Panel panelGenerate;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flpanelTodaySummary;
        private Label labelTodaySummary;
        private Panel panelTotalReservation;
        private Label labelOpenCourt;
        private Label labelOpenCourtIncome;
        private Panel panelTotalIncome;
        private Label labelTotalIncome;
        private Label labelCoveredCourtIncome;
        private Panel panelAvailableCourt;
        private Label labelAvailableCourt;
        private Label labelAirconditionedCourtIncome;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label2;
        private Panel panel2;
        private Label emplloyee1Income;
        private Panel panel3;
        private Label employee2Income;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label6;
        private DataGridView dataGridViewBasketball;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label7;
        private DataGridView dataGridViewVolleyball;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label label8;
        private DataGridView dataGridViewBadminton;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label label9;
        private DataGridView dataGridViewTennis;
        private DataGridView dataGridViewSports;
    }
}

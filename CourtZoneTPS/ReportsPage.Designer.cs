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
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            label2 = new Label();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            panelHeader.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
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
            labelReports.Text = "Reports";
            labelReports.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
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
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(20, 70);
            flowLayoutPanel2.Margin = new Padding(0, 0, 0, 20);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(940, 70);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0, 0, 20, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 70);
            panel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Bottom;
            comboBox2.Font = new Font("Segoe UI", 10F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly", "Yearly" });
            comboBox2.Location = new Point(0, 39);
            comboBox2.Margin = new Padding(0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 31);
            comboBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(250, 28);
            label2.TabIndex = 3;
            label2.Text = "Range";
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(270, 0);
            panel3.Margin = new Padding(0, 0, 20, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 70);
            panel3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Bottom;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Reservation Report", "Income Report" });
            comboBox1.Location = new Point(0, 39);
            comboBox1.Margin = new Padding(0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 31);
            comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(250, 28);
            label4.TabIndex = 3;
            label4.Text = "Report Type";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 58, 138);
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(540, 15);
            button1.Margin = new Padding(0, 0, 0, 20);
            button1.Name = "button1";
            button1.Size = new Size(200, 35);
            button1.TabIndex = 3;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(20, 160);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 478);
            panel2.TabIndex = 3;
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
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelReports;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private ComboBox comboBox1;
        private Label label4;
        private Button button1;
        private ComboBox comboBox2;
        private Panel panel2;
    }
}

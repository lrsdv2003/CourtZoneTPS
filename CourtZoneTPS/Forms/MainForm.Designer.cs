namespace CourtZoneTPS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            labelSystemName = new Label();
            buttonDashboard = new Button();
            buttonAddReservation = new Button();
            flpanelButtonSidebar = new FlowLayoutPanel();
            buttonEditReservation = new Button();
            buttonReports = new Button();
            buttonLogout = new Button();
            panelSidebar = new Panel();
            panelContainer = new Panel();
            flpanelButtonSidebar.SuspendLayout();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // labelSystemName
            // 
            labelSystemName.BackColor = Color.Transparent;
            labelSystemName.Dock = DockStyle.Top;
            labelSystemName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSystemName.ForeColor = Color.White;
            labelSystemName.Location = new Point(0, 0);
            labelSystemName.Margin = new Padding(0, 0, 0, 40);
            labelSystemName.Name = "labelSystemName";
            labelSystemName.Size = new Size(300, 100);
            labelSystemName.TabIndex = 0;
            labelSystemName.Text = "CourtZone TPS";
            labelSystemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.Transparent;
            buttonDashboard.Dock = DockStyle.Top;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Image = (Image)resources.GetObject("buttonDashboard.Image");
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(20, 40);
            buttonDashboard.Margin = new Padding(0, 0, 0, 20);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(260, 60);
            buttonDashboard.TabIndex = 0;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // buttonAddReservation
            // 
            buttonAddReservation.BackColor = Color.Transparent;
            buttonAddReservation.FlatAppearance.BorderSize = 0;
            buttonAddReservation.FlatStyle = FlatStyle.Flat;
            buttonAddReservation.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAddReservation.ForeColor = Color.White;
            buttonAddReservation.Image = (Image)resources.GetObject("buttonAddReservation.Image");
            buttonAddReservation.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddReservation.Location = new Point(20, 120);
            buttonAddReservation.Margin = new Padding(0, 0, 0, 20);
            buttonAddReservation.Name = "buttonAddReservation";
            buttonAddReservation.Size = new Size(260, 60);
            buttonAddReservation.TabIndex = 1;
            buttonAddReservation.Text = "Add Reservation";
            buttonAddReservation.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddReservation.UseVisualStyleBackColor = false;
            buttonAddReservation.Click += buttonAddReservation_Click;
            // 
            // flpanelButtonSidebar
            // 
            flpanelButtonSidebar.BackColor = Color.FromArgb(30, 58, 138);
            flpanelButtonSidebar.Controls.Add(buttonDashboard);
            flpanelButtonSidebar.Controls.Add(buttonAddReservation);
            flpanelButtonSidebar.Controls.Add(buttonEditReservation);
            flpanelButtonSidebar.Controls.Add(buttonReports);
            flpanelButtonSidebar.Controls.Add(buttonLogout);
            flpanelButtonSidebar.Dock = DockStyle.Bottom;
            flpanelButtonSidebar.FlowDirection = FlowDirection.TopDown;
            flpanelButtonSidebar.Location = new Point(0, 100);
            flpanelButtonSidebar.Margin = new Padding(0);
            flpanelButtonSidebar.Name = "flpanelButtonSidebar";
            flpanelButtonSidebar.Padding = new Padding(20, 40, 20, 10);
            flpanelButtonSidebar.Size = new Size(300, 700);
            flpanelButtonSidebar.TabIndex = 3;
            // 
            // buttonEditReservation
            // 
            buttonEditReservation.BackColor = Color.Transparent;
            buttonEditReservation.FlatAppearance.BorderSize = 0;
            buttonEditReservation.FlatStyle = FlatStyle.Flat;
            buttonEditReservation.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditReservation.ForeColor = Color.White;
            buttonEditReservation.Image = (Image)resources.GetObject("buttonEditReservation.Image");
            buttonEditReservation.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEditReservation.Location = new Point(20, 200);
            buttonEditReservation.Margin = new Padding(0, 0, 0, 20);
            buttonEditReservation.Name = "buttonEditReservation";
            buttonEditReservation.Size = new Size(260, 60);
            buttonEditReservation.TabIndex = 2;
            buttonEditReservation.Text = "Edit Reservation";
            buttonEditReservation.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditReservation.UseVisualStyleBackColor = false;
            buttonEditReservation.Click += buttonEditReservation_Click;
            // 
            // buttonReports
            // 
            buttonReports.BackColor = Color.Transparent;
            buttonReports.FlatAppearance.BorderSize = 0;
            buttonReports.FlatStyle = FlatStyle.Flat;
            buttonReports.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReports.ForeColor = Color.White;
            buttonReports.Image = (Image)resources.GetObject("buttonReports.Image");
            buttonReports.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReports.Location = new Point(20, 280);
            buttonReports.Margin = new Padding(0, 0, 0, 300);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new Size(260, 60);
            buttonReports.TabIndex = 3;
            buttonReports.Text = "Reports";
            buttonReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReports.UseVisualStyleBackColor = false;
            buttonReports.Click += buttonReports_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Transparent;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Image = (Image)resources.GetObject("buttonLogout.Image");
            buttonLogout.ImageAlign = ContentAlignment.MiddleRight;
            buttonLogout.Location = new Point(20, 640);
            buttonLogout.Margin = new Padding(0);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(260, 30);
            buttonLogout.TabIndex = 4;
            buttonLogout.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 58, 138);
            panelSidebar.Controls.Add(labelSystemName);
            panelSidebar.Controls.Add(flpanelButtonSidebar);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(300, 800);
            panelSidebar.TabIndex = 4;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(300, 0);
            panelContainer.Margin = new Padding(0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(980, 800);
            panelContainer.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1280, 800);
            Controls.Add(panelContainer);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            flpanelButtonSidebar.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label labelSystemName;
        private Button buttonDashboard;
        private Button buttonAddReservation;
        private FlowLayoutPanel flpanelButtonSidebar;
        private Button buttonEditReservation;
        private Button buttonReports;
        private Panel panelSidebar;
        private Button buttonLogout;
        private Panel panelContainer;
    }
}

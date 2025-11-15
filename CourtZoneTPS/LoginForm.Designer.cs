namespace CourtZoneTPS
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLoginFom = new Panel();
            panelLogo = new Panel();
            panelLogin = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            flpanelEmployee = new FlowLayoutPanel();
            labelCustomerName = new Label();
            textBoxEmployeeNumber = new TextBox();
            flpanelPassword = new FlowLayoutPanel();
            label2 = new Label();
            textBoxPassword = new TextBox();
            checkBoxShowPassword = new CheckBox();
            buttonLogin = new Button();
            labelError = new Label();
            CourtZone = new Label();
            panelLoginFom.SuspendLayout();
            panelLogin.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flpanelEmployee.SuspendLayout();
            flpanelPassword.SuspendLayout();
            SuspendLayout();
            // 
            // panelLoginFom
            // 
            panelLoginFom.BackColor = Color.White;
            panelLoginFom.Controls.Add(panelLogo);
            panelLoginFom.Controls.Add(panelLogin);
            panelLoginFom.Dock = DockStyle.Fill;
            panelLoginFom.Location = new Point(150, 100);
            panelLoginFom.Margin = new Padding(0);
            panelLoginFom.Name = "panelLoginFom";
            panelLoginFom.Size = new Size(980, 600);
            panelLoginFom.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Transparent;
            panelLogo.Dock = DockStyle.Left;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(50);
            panelLogo.Size = new Size(490, 600);
            panelLogo.TabIndex = 0;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.Transparent;
            panelLogin.Controls.Add(flowLayoutPanel1);
            panelLogin.Controls.Add(CourtZone);
            panelLogin.Dock = DockStyle.Right;
            panelLogin.Location = new Point(490, 0);
            panelLogin.Margin = new Padding(0);
            panelLogin.Name = "panelLogin";
            panelLogin.Padding = new Padding(40);
            panelLogin.Size = new Size(490, 600);
            panelLogin.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(flpanelEmployee);
            flowLayoutPanel1.Controls.Add(flpanelPassword);
            flowLayoutPanel1.Controls.Add(buttonLogin);
            flowLayoutPanel1.Controls.Add(labelError);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(40, 160);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(410, 400);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0, 0, 0, 20);
            label1.Name = "label1";
            label1.Size = new Size(410, 50);
            label1.TabIndex = 0;
            label1.Text = "Employee Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpanelEmployee
            // 
            flpanelEmployee.Controls.Add(labelCustomerName);
            flpanelEmployee.Controls.Add(textBoxEmployeeNumber);
            flpanelEmployee.FlowDirection = FlowDirection.TopDown;
            flpanelEmployee.Location = new Point(0, 70);
            flpanelEmployee.Margin = new Padding(0);
            flpanelEmployee.Name = "flpanelEmployee";
            flpanelEmployee.Padding = new Padding(0, 10, 0, 10);
            flpanelEmployee.Size = new Size(410, 100);
            flpanelEmployee.TabIndex = 3;
            // 
            // labelCustomerName
            // 
            labelCustomerName.Dock = DockStyle.Left;
            labelCustomerName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelCustomerName.ForeColor = Color.FromArgb(30, 58, 138);
            labelCustomerName.Location = new Point(0, 10);
            labelCustomerName.Margin = new Padding(0, 0, 0, 10);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(400, 30);
            labelCustomerName.TabIndex = 1;
            labelCustomerName.Text = "Employee Number";
            labelCustomerName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxEmployeeNumber
            // 
            textBoxEmployeeNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmployeeNumber.Dock = DockStyle.Left;
            textBoxEmployeeNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmployeeNumber.Location = new Point(0, 50);
            textBoxEmployeeNumber.Margin = new Padding(0);
            textBoxEmployeeNumber.Name = "textBoxEmployeeNumber";
            textBoxEmployeeNumber.Size = new Size(407, 34);
            textBoxEmployeeNumber.TabIndex = 2;
            // 
            // flpanelPassword
            // 
            flpanelPassword.Controls.Add(label2);
            flpanelPassword.Controls.Add(textBoxPassword);
            flpanelPassword.Controls.Add(checkBoxShowPassword);
            flpanelPassword.FlowDirection = FlowDirection.TopDown;
            flpanelPassword.Location = new Point(0, 170);
            flpanelPassword.Margin = new Padding(0, 0, 0, 20);
            flpanelPassword.Name = "flpanelPassword";
            flpanelPassword.Padding = new Padding(0, 10, 0, 10);
            flpanelPassword.Size = new Size(410, 130);
            flpanelPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(30, 58, 138);
            label2.Location = new Point(0, 10);
            label2.Margin = new Padding(0, 0, 0, 10);
            label2.Name = "label2";
            label2.Size = new Size(400, 30);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Dock = DockStyle.Left;
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(0, 50);
            textBoxPassword.Margin = new Padding(0);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(407, 34);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.ImageAlign = ContentAlignment.MiddleLeft;
            checkBoxShowPassword.Location = new Point(3, 87);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.RightToLeft = RightToLeft.Yes;
            checkBoxShowPassword.Size = new Size(404, 30);
            checkBoxShowPassword.TabIndex = 5;
            checkBoxShowPassword.Text = "show password";
            checkBoxShowPassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(30, 58, 138);
            buttonLogin.Dock = DockStyle.Fill;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 11F);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(0, 320);
            buttonLogin.Margin = new Padding(0);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(410, 50);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelError
            // 
            labelError.ForeColor = Color.FromArgb(220, 38, 38);
            labelError.Location = new Point(3, 370);
            labelError.Name = "labelError";
            labelError.Size = new Size(404, 25);
            labelError.TabIndex = 6;
            labelError.Visible = false;
            // 
            // CourtZone
            // 
            CourtZone.Dock = DockStyle.Top;
            CourtZone.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourtZone.Location = new Point(40, 40);
            CourtZone.Margin = new Padding(0);
            CourtZone.Name = "CourtZone";
            CourtZone.Size = new Size(410, 80);
            CourtZone.TabIndex = 0;
            CourtZone.Text = "COURTZONE";
            CourtZone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(1280, 800);
            Controls.Add(panelLoginFom);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Padding = new Padding(150, 100, 150, 100);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CourtZone-Login";
            panelLoginFom.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flpanelEmployee.ResumeLayout(false);
            flpanelEmployee.PerformLayout();
            flpanelPassword.ResumeLayout(false);
            flpanelPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLoginFom;
        private Panel panelLogo;
        private Panel panelLogin;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label CourtZone;
        private Label label1;
        private FlowLayoutPanel flpanelEmployee;
        private Label labelCustomerName;
        private TextBox textBoxEmployeeNumber;
        private FlowLayoutPanel flpanelPassword;
        private Label label2;
        private TextBox textBoxPassword;
        private CheckBox checkBoxShowPassword;
        private Button buttonLogin;
        private Label labelError;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourtZoneTPS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxEmployeeNumber.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (username == "" || password == "")
            {
                labelError.Text = "Please enter both username and password.";
                labelError.Visible = true;
                return;
            }

            // Temporary check (replace with DB check later)
            if (username == "admin" && password == "1234")
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                labelError.Text = "Invalid username or password.";
                labelError.Visible = true;
            }
        }
    }
}

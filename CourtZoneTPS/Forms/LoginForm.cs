using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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
            string employeeNumber = textBoxEmployeeNumber.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(employeeNumber) || string.IsNullOrEmpty(password))
            {
                labelError.Text = "Please enter both username and password.";
                labelError.Visible = true;
                return;
            }

            try
            {
                if (UserHelper.LoginUser(employeeNumber, password))
                {
                    this.Hide();
                    MainForm main = new MainForm();
                    main.Show();
                }
                else
                {
                    labelError.Text = "Invalid username or password.";
                    labelError.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Check the Path!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public string GetUsernameByEmployeeNumber()
        {
            string employeeNumber = textBoxEmployeeNumber.Text;
            string dbPath = @"C:\Users\EJ Ridge\OneDrive - STI College Ortigas-Cainta\Desktop\CourtZoneTPS_DB\CourtZoneTpsDB.db";
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT employeeNumber FROM loginInfo WHERE employeeNumber = @employeeNumber";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@employeeNumber", employeeNumber);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        return result.ToString();
                    else
                        return null;
                }
            }
        }

    }
}

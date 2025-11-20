using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace CourtZoneTPS
{
    public partial class DashboardPage : UserControl
    {
        private string dbPath = @"C:\Users\jm\OneDrive\Desktop\Database\CourtZoneTpsDB.db";
        private string connectionString;
        public DashboardPage()
        {
            connectionString = $"Data Source={dbPath};Version=3;";
            InitializeComponent();
            LoadUpcomingReservations();
            LoadSummary();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDashboardDateTime.Text = DateTime.Now.ToString("dd / MM / yyyy| hh:mm tt");
        }
        private void LoadUpcomingReservations()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT customerName, time, date " +
                               "FROM ReservationInfo " +
                               "WHERE date = @today " +
                               "ORDER BY date ASC, time ASC " +
                               "LIMIT 3";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@today", DateTime.Now.ToString("dd/MM/yyyy"));

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        Label[] nameLabels = { labelCustomer1Name, labelCustomer2Name, labelCustomer3Name };
                        Label[] timeLabels = { labelCustomer1Time, labelCustomer2Time, labelCustomer3Time };

                        int index = 0;

                        while (reader.Read() && index < 3)
                        {
                            nameLabels[index].Text = reader["customerName"].ToString();
                            timeLabels[index].Text = reader["time"].ToString();
                            index++;
                        }
                        while (index < 3)
                        {
                            nameLabels[index].Text = "";
                            timeLabels[index].Text = "";
                            index++;
                        }
                    }
                }
            }
        }
        private void LoadSummary()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string today = DateTime.Now.ToString("dd/MM/yyyy");
                string query = "SELECT COUNT(*) FROM ReservationInfo WHERE date = @today";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@today", today);
                    int totalReservations = Convert.ToInt32(cmd.ExecuteScalar());
                    labelTotalReservationCount.Text = totalReservations.ToString();
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtZoneTPS
{
    public static class UserHelper
    {
        public static string CurrentUsername { get; private set; }
        public static string CurrentEmployeeNumber { get; private set; }

        public static bool LoginUser(string employeeNumber, string password)
        {
            string username = GetUsernameByEmployeeNumber(employeeNumber);

            if (!string.IsNullOrEmpty(username))
            {
                CurrentUsername = username;
                CurrentEmployeeNumber = employeeNumber;
                return true;
            }

            return false; 
        }

        public static string GetUsernameByEmployeeNumber(string employeeNumber)
        {
            string dbPath = @"C:\Users\jm\OneDrive\Desktop\Database\CourtZoneTpsDB.db";
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT employeeNumber FROM loginInfo WHERE employeeNumber = @employeeNumber";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@employeeNumber", employeeNumber);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString(); 
                }
            }
        }
    }
}

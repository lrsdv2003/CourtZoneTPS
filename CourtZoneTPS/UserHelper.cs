using System;
using System.Data.SQLite;

namespace CourtZoneTPS
{
    public static class UserHelper
    {
        public static int CurrentUserId { get; private set; }
        public static string CurrentEmployeeNumber { get; private set; }

        private static readonly string dbPath =
            @"C:\Users\EJ Ridge\OneDrive - STI College Ortigas-Cainta\Desktop\CourtZoneTPS_DB\CourtZoneTpsDB.db";

        private static readonly string connectionString =
            $"Data Source={dbPath};Version=3;";

        // ==================================================
        // LOGIN VALIDATION (employeeNumber + password)
        // ==================================================
        public static bool LoginUser(string employeeNumber, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT user_Id 
                    FROM LoginInfo 
                    WHERE employeeNumber = @employeeNumber 
                    AND password = @password
                    LIMIT 1
                ";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@employeeNumber", employeeNumber);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        CurrentUserId = Convert.ToInt32(result);
                        CurrentEmployeeNumber = employeeNumber;
                        return true;
                    }
                }
            }

            return false;
        }

        // Returns ONLY employeeNumber if needed
        public static string GetEmployeeNumber(string employeeNumber)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT employeeNumber FROM LoginInfo WHERE employeeNumber = @employeeNumber";

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

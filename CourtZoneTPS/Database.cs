using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtZoneTPS
{
    public static class Database
    {
        private static string connectionString = @"Data Source=CourtZoneTpsDB.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}


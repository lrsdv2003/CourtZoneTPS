using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;

namespace CourtZoneTPS.Services
{
    /// <summary>
    /// Service class for all Reservation related DB operations.
    /// Matches schema:
    ///  - CourtPricing(courtType TEXT PRIMARY KEY, pricePerSlot REAL)
    ///  - LoginInfo(user_Id INTEGER PRIMARY KEY, employeeNumber TEXT, password TEXT)
    ///  - ReservationInfo(reservation_Id, user_Id, customerName, contactNumber, sportsType, courtType, date, timeSlot, paymentStatus, paymentAmount, createdAt)
    /// Date strings in DB are stored as "yyyy-MM-dd".
    /// </summary>
    public class ReservationService
    {
        private readonly string connectionString;

        public ReservationService()
        {
            // Path you provided earlier — adjust if your DB location is different.
            string dbPath = @"C:\Users\EJ Ridge\OneDrive - STI College Ortigas-Cainta\Desktop\CourtZoneTPS_DB\CourtZoneTpsDB.db";
            connectionString = $"Data Source={dbPath};Version=3;";
        }
        // returns a list of (sportsType, courtType, total)
        public List<(string SportsType, string CourtType, decimal Total)> GetSumsBySportAndCourt(DateTime from, DateTime to)
        {
            var list = new List<(string, string, decimal)>();
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"
            SELECT sportsType, courtType, IFNULL(SUM(paymentAmount),0) AS total
            FROM ReservationInfo
            WHERE date BETWEEN @from AND @to
            GROUP BY sportsType, courtType
            ORDER BY sportsType, courtType;
        ";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@from", from.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@to", to.ToString("yyyy-MM-dd"));
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            string sport = r["sportsType"].ToString();
                            string court = r["courtType"].ToString();
                            decimal total = r["total"] == DBNull.Value ? 0m : Convert.ToDecimal(r["total"]);
                            list.Add((sport, court, total));
                        }
                    }
                }
            }
            return list;
        }

        // returns total income per sport
        public Dictionary<string, decimal> GetTotalBySport(DateTime from, DateTime to)
        {
            var dict = new Dictionary<string, decimal>();
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"
            SELECT sportsType, IFNULL(SUM(paymentAmount),0) as total
            FROM ReservationInfo
            WHERE date BETWEEN @from AND @to
            GROUP BY sportsType;
        ";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@from", from.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@to", to.ToString("yyyy-MM-dd"));
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            dict[r["sportsType"].ToString()] = r["total"] == DBNull.Value ? 0m : Convert.ToDecimal(r["total"]);
                        }
                    }
                }
            }
            return dict;
        }

        // returns total income per court type (across all sports)
        public Dictionary<string, decimal> GetTotalByCourtType(DateTime from, DateTime to)
        {
            var dict = new Dictionary<string, decimal>();
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"
            SELECT courtType, IFNULL(SUM(paymentAmount),0) AS total
            FROM ReservationInfo
            WHERE date BETWEEN @from AND @to
            GROUP BY courtType;
        ";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@from", from.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@to", to.ToString("yyyy-MM-dd"));
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            dict[r["courtType"].ToString()] = r["total"] == DBNull.Value ? 0m : Convert.ToDecimal(r["total"]);
                        }
                    }
                }
            }
            return dict;
        }

        // returns list of (user_Id, employeeNumber, totalIncome)
        public List<(int UserId, string EmployeeNumber, decimal Total)> GetIncomeByEmployee(DateTime from, DateTime to)
        {
            var list = new List<(int, string, decimal)>();
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"
            SELECT r.user_Id, l.employeeNumber, IFNULL(SUM(r.paymentAmount),0) AS total
            FROM ReservationInfo r
            LEFT JOIN LoginInfo l ON r.user_Id = l.user_Id
            WHERE r.date BETWEEN @from AND @to
            GROUP BY r.user_Id, l.employeeNumber
            ORDER BY total DESC;
        ";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@from", from.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@to", to.ToString("yyyy-MM-dd"));
                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            int userId = r["user_Id"] == DBNull.Value ? 0 : Convert.ToInt32(r["user_Id"]);
                            string emp = r["employeeNumber"]?.ToString() ?? "Unknown";
                            decimal total = r["total"] == DBNull.Value ? 0m : Convert.ToDecimal(r["total"]);
                            list.Add((userId, emp, total));
                        }
                    }
                }
            }
            return list;
        }


        // -------------------------
        // Helper: Parse DB date string -> DateTime
        // -------------------------
        private DateTime ParseDbDate(string dbDate)
        {
            if (DateTime.TryParseExact(dbDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt))
                return dt;

            if (DateTime.TryParse(dbDate, out dt))
                return dt;

            // fallback - should not normally happen
            return DateTime.MinValue;
        }

        // -------------------------
        // Get court price
        // -------------------------
        public decimal GetCourtPrice(string courtType)
        {
            if (string.IsNullOrWhiteSpace(courtType))
                return 0m;

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT pricePerSlot FROM CourtPricing WHERE courtType = @courtType LIMIT 1";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@courtType", courtType);
                    object val = cmd.ExecuteScalar();
                    if (val != null && decimal.TryParse(val.ToString(), out decimal price))
                        return price;
                }
            }
            return 0m;
        }

        // -------------------------
        // Check availability (string date) — matches existing form calls
        // -------------------------
        public bool CheckAvailability(string courtType, string dateString, string timeSlot, int ignoreReservationId = 0)
        {
            // Expecting dateString to be "yyyy-MM-dd". If caller passed DateTime.ToString("yyyy-MM-dd") this will match DB.
            if (string.IsNullOrWhiteSpace(courtType) || string.IsNullOrWhiteSpace(dateString) || string.IsNullOrWhiteSpace(timeSlot))
                return false;

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT COUNT(*) FROM ReservationInfo 
                               WHERE courtType = @court AND date = @date AND timeSlot = @time"
                           + (ignoreReservationId > 0 ? " AND reservation_Id != @ignoreId" : "");

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@court", courtType);
                    cmd.Parameters.AddWithValue("@date", dateString);
                    cmd.Parameters.AddWithValue("@time", timeSlot);
                    if (ignoreReservationId > 0)
                        cmd.Parameters.AddWithValue("@ignoreId", ignoreReservationId);

                    object result = cmd.ExecuteScalar();
                    int count = Convert.ToInt32(result ?? 0);
                    return count == 0;
                }
            }
        }

        // -------------------------
        // Check availability (DateTime overload)
        // -------------------------
        public bool CheckAvailability(string courtType, DateTime date, string timeSlot, int ignoreReservationId = 0)
        {
            string dateString = date.ToString("yyyy-MM-dd");
            return CheckAvailability(courtType, dateString, timeSlot, ignoreReservationId);
        }

        // -------------------------
        // Insert reservation (explicit parameters) — matches your AddReservationForm call
        // -------------------------
        public bool InsertReservation(int currentUserId,
                                      string customerName,
                                      string contactNumber,
                                      string sportsType,
                                      string courtType,
                                      DateTime date,
                                      string timeSlot,
                                      string paymentStatus,
                                      decimal paymentAmount)
        {
            // basic validation
            if (string.IsNullOrWhiteSpace(customerName) ||
                string.IsNullOrWhiteSpace(contactNumber) ||
                string.IsNullOrWhiteSpace(sportsType) ||
                string.IsNullOrWhiteSpace(courtType) ||
                string.IsNullOrWhiteSpace(timeSlot) ||
                string.IsNullOrWhiteSpace(paymentStatus))
                return false;

            // ensure not double-booked (final guard)
            if (!CheckAvailability(courtType, date, timeSlot))
                return false;

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                    INSERT INTO ReservationInfo
                    (user_Id, customerName, contactNumber, sportsType, courtType, date, timeSlot, paymentStatus, paymentAmount, createdAt)
                    VALUES
                    (@userId, @customerName, @contactNumber, @sportsType, @courtType, @date, @timeSlot, @paymentStatus, @paymentAmount, CURRENT_TIMESTAMP)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", currentUserId);
                    cmd.Parameters.AddWithValue("@customerName", customerName.Trim());
                    cmd.Parameters.AddWithValue("@contactNumber", contactNumber.Trim());
                    cmd.Parameters.AddWithValue("@sportsType", sportsType.Trim());
                    cmd.Parameters.AddWithValue("@courtType", courtType.Trim());
                    cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@timeSlot", timeSlot.Trim());
                    cmd.Parameters.AddWithValue("@paymentStatus", paymentStatus.Trim());
                    cmd.Parameters.AddWithValue("@paymentAmount", paymentAmount);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // convenience overload: InsertReservation(Reservation)
        public bool InsertReservation(Reservation r)
        {
            if (r == null) return false;
            return InsertReservation(r.UserID, r.CustomerName, r.ContactNumber, r.SportsType, r.CourtType, r.Date, r.TimeSlot, r.PaymentStatus, r.PaymentAmount);
        }

        // -------------------------
        // Get reservation by id
        // -------------------------
        public Reservation GetReservationById(int reservationId)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM ReservationInfo WHERE reservation_Id = @id LIMIT 1";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", reservationId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return MapReaderToReservation(reader);
                    }
                }
            }
            return null;
        }

        // -------------------------
        // Get reservations by date
        // -------------------------
        public List<Reservation> GetReservationsByDate(DateTime date)
        {
            var list = new List<Reservation>();
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM ReservationInfo WHERE date = @date ORDER BY timeSlot";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(MapReaderToReservation(reader));
                        }
                    }
                }
            }
            return list;
        }

        // -------------------------
        // Search reservations by name / contact (simple)
        // -------------------------
        public List<Reservation> SearchReservations(string keyword)
        {
            var list = new List<Reservation>();
            if (keyword == null) keyword = string.Empty;

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                    SELECT * FROM ReservationInfo
                    WHERE customerName LIKE @kw OR contactNumber LIKE @kw
                    ORDER BY date, timeSlot";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword.Trim() + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(MapReaderToReservation(reader));
                        }
                    }
                }
            }
            return list;
        }

        // -------------------------
        // Update reservation
        // -------------------------
        public bool UpdateReservation(int reservationId,
                                      string customerName,
                                      string contactNumber,
                                      string sportsType,
                                      string courtType,
                                      DateTime date,
                                      string timeSlot,
                                      string paymentStatus,
                                      decimal paymentAmount)
        {
            if (reservationId <= 0) return false;

            // ensure not double-booked excluding this reservation
            if (!CheckAvailability(courtType, date, timeSlot, reservationId))
                return false;

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                    UPDATE ReservationInfo
                    SET customerName = @customerName,
                        contactNumber = @contactNumber,
                        sportsType = @sportsType,
                        courtType = @courtType,
                        date = @date,
                        timeSlot = @timeSlot,
                        paymentStatus = @paymentStatus,
                        paymentAmount = @paymentAmount
                    WHERE reservation_Id = @id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", reservationId);
                    cmd.Parameters.AddWithValue("@customerName", customerName.Trim());
                    cmd.Parameters.AddWithValue("@contactNumber", contactNumber.Trim());
                    cmd.Parameters.AddWithValue("@sportsType", sportsType.Trim());
                    cmd.Parameters.AddWithValue("@courtType", courtType.Trim());
                    cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@timeSlot", timeSlot.Trim());
                    cmd.Parameters.AddWithValue("@paymentStatus", paymentStatus.Trim());
                    cmd.Parameters.AddWithValue("@paymentAmount", paymentAmount);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // convenience overload: UpdateReservation(Reservation)
        public bool UpdateReservation(Reservation r)
        {
            if (r == null) return false;
            return UpdateReservation(r.ReservationID, r.CustomerName, r.ContactNumber, r.SportsType, r.CourtType, r.Date, r.TimeSlot, r.PaymentStatus, r.PaymentAmount);
        }

        // -------------------------
        // Delete by id
        // -------------------------
        public bool DeleteReservationById(int reservationId)
        {
            if (reservationId <= 0) return false;

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM ReservationInfo WHERE reservation_Id = @id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", reservationId);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // -------------------------
        // Income report (range)
        // -------------------------
        public decimal GetIncomeTotal(DateTime from, DateTime to)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT SUM(paymentAmount) FROM ReservationInfo WHERE date BETWEEN @from AND @to";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@from", from.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@to", to.ToString("yyyy-MM-dd"));
                    object val = cmd.ExecuteScalar();
                    if (val != null && decimal.TryParse(val.ToString(), out decimal total))
                        return total;
                }
            }
            return 0m;
        }

        // -------------------------
        // Map SQLiteDataReader -> Reservation
        // -------------------------
        private Reservation MapReaderToReservation(SQLiteDataReader r)
        {
            var res = new Reservation();

            res.ReservationID = r["reservation_Id"] == DBNull.Value ? 0 : Convert.ToInt32(r["reservation_Id"]);
            res.UserID = r["user_Id"] == DBNull.Value ? 0 : Convert.ToInt32(r["user_Id"]);
            res.CustomerName = r["customerName"]?.ToString() ?? string.Empty;
            res.ContactNumber = r["contactNumber"]?.ToString() ?? string.Empty;
            res.SportsType = r["sportsType"]?.ToString() ?? string.Empty;
            res.CourtType = r["courtType"]?.ToString() ?? string.Empty;

            string dbDate = r["date"]?.ToString() ?? string.Empty;
            res.Date = ParseDbDate(dbDate);

            res.TimeSlot = r["timeSlot"]?.ToString() ?? string.Empty;
            res.PaymentStatus = r["paymentStatus"]?.ToString() ?? string.Empty;
            res.PaymentAmount = r["paymentAmount"] == DBNull.Value ? 0m : Convert.ToDecimal(r["paymentAmount"]);

            // createdAt may be a full timestamp
            res.CreatedAt = DateTime.TryParse(r["createdAt"]?.ToString(), out DateTime created) ? created : DateTime.MinValue;

            return res;
        }
    }
}

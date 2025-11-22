using System;

namespace CourtZoneTPS
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int UserID { get; set; }
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public string SportsType { get; set; }
        public string CourtType { get; set; }
        public DateTime Date { get; set; }      // use DateTime in code
        public string TimeSlot { get; set; }
        public string PaymentStatus { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

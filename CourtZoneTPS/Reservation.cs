using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtZoneTPS
{
    public class Reservation
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string SportsType { get; set; }
        public string Date {  get; set; }  
        public string PaymentStatus {  get; set; }
        public string ContactNumber { get; set; }
        public string CourtType {  get; set; }
        public string  Time{ get; set; }
    }
}

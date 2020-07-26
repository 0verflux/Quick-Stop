using QuickStop.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Domain.Models
{
    public class Reservation
    {
        public string Reference { get; set; }
        public int HotelID { get; set; }
        public int GuestCount { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalCost { get; set; }
    }
}

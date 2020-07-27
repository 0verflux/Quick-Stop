using System;

namespace QuickStop.Domain.Models
{
    public class HotelBook
    {
        public string Reference { get; set; }
        public int HotelID { get; set; }
        public int GuestCount { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalCost { get; set; }
    }
}

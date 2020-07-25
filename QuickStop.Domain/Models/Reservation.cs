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
        public Hotel Hotel { get; set; }
        public DateTime? CheckIn { get; set; }
        public ushort DurationOfStay { get; set; }
        public decimal TotalCost { get; set; }
    }
}

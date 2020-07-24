using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Domain.Models
{
    public class Reservation : IEntity
    {
        public int ID { get; set; }
        public Hotel Hotel { get; set; }
        public DateTime? CheckIn { get; set; }
        public ushort DurationOfStay { get; set; }
        public decimal TotalCost { get; set; }
    }
}

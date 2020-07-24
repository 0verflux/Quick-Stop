using QuickStop.Domain.Contracts;
using QuickStop.Domain.Enums;
using System.Drawing;

namespace QuickStop.Domain.Models
{
    public class Hotel : IEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public Bitmap Icon { get; set; }
        public Bitmap Room { get; set; }
        public decimal Price { get; set; }
        public ushort Ratings { get; set; }
        public Location Location { get; set; }
        public bool IsAvailable { get; set; }
    }
}

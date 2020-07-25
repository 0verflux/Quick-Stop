using QuickStop.Domain.Contracts;
using QuickStop.Domain.Enums;
using System;
using System.Drawing;

namespace QuickStop.Domain.Models
{
    public class Hotel
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ushort Ratings { get; set; }
        public Location Location { get; set; }
        public int MinGuestCount { get; set; }
        public int MaxGuestCount { get; set; }
        public DateTime? DateUntilAvailable { get; set; }
        public string Icon { get; set; }    // base64 string
        public string Room { get; set; }    //base64 string

        public bool IsAvailable
        {
            get
            {
                bool output = false; 

                if(DateUntilAvailable != null)
                {
                    if((output = DateUntilAvailable == DateTime.Now) == true)
                    {
                        DateUntilAvailable = null;
                    }
                }

                return output;
            }
        }
    }
}

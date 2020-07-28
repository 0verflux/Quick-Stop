using QuickStop.Domain.Enums;
using System;

namespace QuickStop.Domain.Models
{
    /// <summary>
    /// A Model class for a Hotel Room.
    /// </summary>
    public class HotelRoom
    {
        /// <summary>
        /// The Hotel ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The Name of the Hotel.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Description provided of the Hotel.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The cost per Night of the Hotel.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The current ratings of the Hotel.
        /// </summary>
        public ushort Ratings { get; set; }

        /// <summary>
        /// The current Location of the Hotel.
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// The minimumm amount of guests allowed in the Hotel.
        /// </summary>
        public int MinGuestCount { get; set; }

        /// <summary>
        /// The maximum amount of guests allowed in the Hotel.
        /// </summary>
        public int MaxGuestCount { get; set; }

        /// <summary>
        /// The Date till this Hotel becomes available for booking.
        /// </summary>
        public DateTime? DateUntilAvailable { get; set; }

        /// <summary>
        /// The base-64 converted Image of the Hotel Icon.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// The base-65 converted Image of the Hotel Room.
        /// </summary>
        public string Room { get; set; }

        /// <summary>
        /// A state when the Hotel is Available for Booking.
        /// </summary>
        public bool IsAvailable
        {
            get
            {
                bool output = true; 

                if(DateUntilAvailable != null)
                {
                    if((output = DateTime.Now >= DateUntilAvailable) == true)
                    {
                        DateUntilAvailable = null;
                    }
                }

                return output;
            }
        }
    }
}

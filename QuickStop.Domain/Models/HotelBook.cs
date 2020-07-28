using System;

namespace QuickStop.Domain.Models
{
    /// <summary>
    /// A Model Class for Hotel Room Booking Details.
    /// </summary>
    public class HotelBook
    {
        /// <summary>
        /// The Reference Key of a Booked Hotel Room.
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// The Id of a selected <see cref="HotelRoom"/>.
        /// </summary>
        public int HotelID { get; set; }

        /// <summary>
        /// The number of guests in a <see cref="HotelRoom"/>.
        /// </summary>
        public int GuestCount { get; set; }

        /// <summary>
        /// The date to check-in a <see cref="HotelRoom"/>
        /// </summary>
        public DateTime CheckIn { get; set; }

        /// <summary>
        /// The date to check-out in a <see cref="HotelRoom"/>
        /// </summary>
        public DateTime CheckOut { get; set; }

        /// <summary>
        /// The total cost from booking in a <see cref="HotelRoom"/>.
        /// </summary>
        public decimal TotalCost { get; set; }
    }
}

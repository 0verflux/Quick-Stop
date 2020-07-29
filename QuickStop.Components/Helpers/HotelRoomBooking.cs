using System;

namespace QuickStop.Components.Helpers
{
    /// <summary>
    /// Provides Total Price Calculation of <see cref="Domain.Models.HotelBook"/>.
    /// </summary>
    public static class HotelRoomBooking
    {
        /// <summary>
        /// Calculates the Total Price of a <see cref="Domain.Models.HotelBook"/>.
        /// </summary>
        /// <param name="hotelPrice">The Current <see cref="Domain.Models.HotelRoom"/> Price.</param>
        /// <param name="guestCount">The Amount of Guests in the <see cref="Domain.Models.HotelBook"/>.</param>
        /// <param name="minGuestCount">The Minimum Guest Count of the <see cref="Domain.Models.HotelRoom"/>.</param>
        /// <param name="maxGuestCount">The Maximum Guest Count of the <see cref="Domain.Models.HotelRoom"/>.</param>
        /// <param name="checkIn">The check-in date.</param>
        /// <param name="checkOut">The check=out date.</param>
        /// <returns>A Total Cost to Book a <see cref="Domain.Models.HotelRoom"/>.</returns>
        public static decimal CalculateTotalPrice(decimal hotelPrice, int guestCount, int minGuestCount, int maxGuestCount, DateTime checkIn, DateTime checkOut)
        {
            return hotelPrice * (1 + ((decimal)(guestCount - minGuestCount) / (maxGuestCount - minGuestCount))) * (decimal)Math.Round((checkOut - checkIn).TotalDays);
        }
    }
}

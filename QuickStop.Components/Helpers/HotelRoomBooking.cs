using System;

namespace QuickStop.Components.Helpers
{
    public static class HotelRoomBooking
    {
        public static decimal CalculateTotalPrice(decimal hotelPrice, int guestCount, int minGuestCount, int maxGuestCount, DateTime checkIn, DateTime checkOut)
        {
            return hotelPrice * (1 + ((guestCount - minGuestCount) / (maxGuestCount - minGuestCount))) * (checkOut - checkIn).Days;
        }
    }
}

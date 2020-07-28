using System;

namespace QuickStop.Components.Exceptions
{
    public class HotelRoomNotFoundException : Exception
    {
        public HotelRoomNotFoundException() : base("Hotel Room not Found!")
        {

        }
    }
}

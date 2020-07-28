using System;

namespace QuickStop.Components.Exceptions
{
    public class HotelRoomParsingException : Exception
    {
        public HotelRoomParsingException() : base("Failed to parse current hotel; hotel will be removed")
        {

        }
    }
}

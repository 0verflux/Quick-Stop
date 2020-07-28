using System;

namespace QuickStop.Components.Exceptions
{
    public class HotelDataNotFoundException : Exception
    {
        public HotelDataNotFoundException() : base("Hotel Data is not Found! File will now be recovered...")
        {

        }
    }
}

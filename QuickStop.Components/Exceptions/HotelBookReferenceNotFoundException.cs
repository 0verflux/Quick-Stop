using System;
namespace QuickStop.Components.Exceptions
{
    public class HotelBookReferenceNotFoundException : Exception
    {
        public HotelBookReferenceNotFoundException() : base("Hotel Book Reference not Found! Are you sure you're entering it correctly?")
        {

        }
    }
}

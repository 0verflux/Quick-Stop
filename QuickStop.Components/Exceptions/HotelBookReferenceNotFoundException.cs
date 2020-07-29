using System;
namespace QuickStop.Components.Exceptions
{
    /// <summary>
    /// Represents a reference not found on Hotel Book exception.
    /// </summary>
    public class HotelBookReferenceNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new Instance of <see cref="HotelBookReferenceNotFoundException"/>
        /// </summary>
        public HotelBookReferenceNotFoundException() : base("Hotel Book Reference not Found! Are you sure you're entering it correctly?")
        {

        }
    }
}

using System;

namespace QuickStop.Components.CustomEventArgs
{
    /// <summary>
    /// Provides reference key data for finding a Booked Hotel Room event.
    /// </summary>
    public class BookReferenceEventArgs : EventArgs
    {
        public string Reference { get; private set; }

        /// <summary>
        /// Initializes a new Instance of <see cref="BookReferenceEventArgs"/>
        /// </summary>
        /// <param name="reference">The reference key of a booked hotel room.</param>
        public BookReferenceEventArgs(string reference) : base()
        {
            Reference = reference;
        }
    }
}

using System;

namespace QuickStop.Components.CustomEventArgs
{
    /// <summary>
    /// Provides the index data for a selected <see cref="Domain.Models.HotelRoom"/> event.
    /// </summary>
    public class HotelSelectedEventArgs : EventArgs
    {
        public int Index { get; private set; }

        /// <summary>
        /// Initializes a new Instance of <see cref="HotelSelectedEventArgs"/>
        /// </summary>
        /// <param name="index">The Hotel Room Index.</param>
        public HotelSelectedEventArgs(int index) : base()
        {
            Index = index;
        }
    }
}

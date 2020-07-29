using QuickStop.Domain.Enums;
using System;

namespace QuickStop.Components.CustomEventArgs
{
    /// <summary>
    /// Provides Filter data for filtering event.
    /// </summary>
    public class HotelFilterEventArgs : EventArgs
    {
        public Location Location { get; private set; }
        public int GuestCount { get; private set; }
        public Sort Sort { get; private set; }

        /// <summary>
        /// Initializes a new Instance of <see cref="HotelFilterEventArgs"/>.
        /// </summary>
        /// <param name="location">The Location to filter.</param>
        /// <param name="guestCount">The amount of guests to filter.</param>
        /// <param name="sort">The type of sort to use.</param>
        public HotelFilterEventArgs(Location location, int guestCount, Sort sort) : base()
        {
            Location = location;
            GuestCount = guestCount;
            Sort = sort;
        }
    }
}

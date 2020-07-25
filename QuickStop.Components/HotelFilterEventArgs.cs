using QuickStop.Domain.Enums;
using System;

namespace QuickStop.Components
{
    public class HotelFilterEventArgs : EventArgs
    {
        public Location Location { get; private set; }
        public int GuestCount { get; private set; }
        public bool SortMode { get; private set; }

        public HotelFilterEventArgs(Location location, int guestCount, bool sortMode) : base()
        {
            Location = location;
            GuestCount = guestCount;
            SortMode = sortMode;
        }
    }
}

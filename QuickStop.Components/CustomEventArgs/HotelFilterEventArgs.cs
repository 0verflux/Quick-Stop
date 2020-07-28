using QuickStop.Domain.Enums;
using System;

namespace QuickStop.Components.CustomEventArgs
{
    public class HotelFilterEventArgs : EventArgs
    {
        public Location Location { get; private set; }
        public int GuestCount { get; private set; }
        public Sort Sort { get; private set; }

        public HotelFilterEventArgs(Location location, int guestCount, Sort sort) : base()
        {
            Location = location;
            GuestCount = guestCount;
            Sort = sort;
        }
    }
}

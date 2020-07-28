using System;

namespace QuickStop.Components.CustomEventArgs
{
    public class HotelSelectedEventArgs : EventArgs
    {
        public int Index { get; private set; }

        public HotelSelectedEventArgs(int index) : base()
        {
            Index = index;
        }
    }
}

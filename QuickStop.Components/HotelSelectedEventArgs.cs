using System;

namespace QuickStop.Components
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

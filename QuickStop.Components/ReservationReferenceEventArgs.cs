using System;

namespace QuickStop.Components
{
    public class ReservationReferenceEventArgs : EventArgs
    {
        public string Reference { get; private set; }

        public ReservationReferenceEventArgs(string reference) : base()
        {
            Reference = reference;
        }
    }
}

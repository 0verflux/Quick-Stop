using System;

namespace QuickStop.Components.CustomEventArgs
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

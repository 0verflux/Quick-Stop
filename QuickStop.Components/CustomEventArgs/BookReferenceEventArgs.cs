using System;

namespace QuickStop.Components.CustomEventArgs
{
    public class BookReferenceEventArgs : EventArgs
    {
        public string Reference { get; private set; }

        public BookReferenceEventArgs(string reference) : base()
        {
            Reference = reference;
        }
    }
}

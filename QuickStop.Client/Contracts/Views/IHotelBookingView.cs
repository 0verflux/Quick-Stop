using QuickStop.Client.ViewModels;
using System;

namespace QuickStop.Client.Contracts.Views
{
    public interface IHotelBookingView : IView
    {
        event EventHandler RequestCreateHotelBooking;

        HotelBookingViewModel HotelBookingViewModel { get; set; }

        void DisplayHotelBooking(bool isReadOnly = false);
        void FinalizeHotelBooking(string reference);
    }
}

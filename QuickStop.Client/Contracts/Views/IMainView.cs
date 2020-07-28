using QuickStop.Components.CustomEventArgs;
using QuickStop.Domain.Models;
using System;
using System.Collections.Generic;

namespace QuickStop.Client.Contracts.Views
{
    public interface IMainView : IView
    {
        event EventHandler<HotelSelectedEventArgs> RequestViewHotelRoomDetails;
        event EventHandler<HotelFilterEventArgs> RequestLoadHotels;
        event EventHandler<BookReferenceEventArgs> RequestViewHotelBooking;
        event EventHandler RequestSaveData;

        void LoadHotels(IEnumerable<HotelRoom> hotels);
    }
}

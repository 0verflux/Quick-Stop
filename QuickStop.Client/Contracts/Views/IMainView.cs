using QuickStop.Components.CustomEventArgs;
using QuickStop.Domain.Models;
using System;
using System.Collections.Generic;

namespace QuickStop.Client.Contracts.Views
{
    public interface IMainView : IView
    {
        event EventHandler<HotelSelectedEventArgs> RequestViewHotelDetails;
        event EventHandler<HotelFilterEventArgs> RequestLoadHotels;
        event EventHandler<ReservationReferenceEventArgs> RequestViewReservation;
        event EventHandler RequestSaveData;

        void LoadHotels(IEnumerable<HotelRoom> hotels);
    }
}

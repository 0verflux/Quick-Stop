using QuickStop.Components.CustomEventArgs;
using QuickStop.Domain.Models;
using System;
using System.Collections.Generic;

namespace QuickStop.Client.Contracts.Views
{
    /// <summary>
    /// Represents the View for <see cref="Client.Views.MainForm"/>.
    /// </summary>
    public interface IMainView : IView
    {
        #region Events
        /// <summary>
        /// Occurs when the user requests to view Hotel Room Details.
        /// </summary>
        event EventHandler<HotelSelectedEventArgs> RequestViewHotelRoomDetails;

        /// <summary>
        /// Occurs when the user requests to Load Hotels in the UI.
        /// </summary>
        event EventHandler<HotelFilterEventArgs> RequestLoadHotels;

        /// <summary>
        /// Occurs when the user requests to view A Booked Hotel Room.
        /// </summary>
        event EventHandler<BookReferenceEventArgs> RequestViewHotelBooking;

        /// <summary>
        /// Occurs when the Form Closes, requesting to Save Changes in a Collection of <see cref="HotelRoom"/>.
        /// </summary>
        event EventHandler RequestSaveData;
        #endregion

        /// <summary>
        /// Populates a Collection of <see cref="HotelRoom"/> in the UI.
        /// </summary>
        /// <param name="hotels">The Hotel to be displayed.</param>
        void LoadHotels(IEnumerable<HotelRoom> hotels);
    }
}

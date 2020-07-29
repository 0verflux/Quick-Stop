using QuickStop.Components.CustomEventArgs;
using QuickStop.Domain.Models;
using System;

namespace QuickStop.Client.Contracts.Views
{
    /// <summary>
    /// Represents the View for <see cref="Client.Views.HotelRoomDetailsForm"/>.
    /// </summary>
    public interface IHotelRoomDetailsView : IView
    {
        #region Events
        /// <summary>
        /// Occurs when the user requests to Book this <see cref="HotelRoom"/>.
        /// </summary>
        event EventHandler<HotelSelectedEventArgs> RequestHotelBooking;
        #endregion

        /// <summary>
        /// Displays the Full Hotel Room Details.
        /// </summary>
        /// <param name="hotel">The <see cref="HotelRoom"/> to be viewed.</param>
        void DisplayHotelRoom(HotelRoom hotel);
    }
}

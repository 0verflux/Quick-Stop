using QuickStop.Client.ViewModels;
using System;

namespace QuickStop.Client.Contracts.Views
{
    /// <summary>
    /// Represents the View for <see cref="Client.Views.HotelBookingForm"/>.
    /// </summary>
    public interface IHotelBookingView : IView
    {
        #region Events
        /// <summary>
        /// Occurs when the user has Booked the selected Hotel Room.
        /// </summary>
        event EventHandler RequestCreateHotelBooking;
        #endregion

        /// <summary>
        /// Provides a Two-Way Interaction of <see cref="ViewModels.HotelBookingViewModel"/> from the View and Presenter.
        /// </summary>
        HotelBookingViewModel HotelBookingViewModel { get; set; }

        /// <summary>
        /// Displays the Hotel Room Booking Details.
        /// </summary>
        /// <param name="isReadOnly">A state whether the form should be a read-only or not.</param>
        void DisplayHotelBooking(bool isReadOnly = false);

        /// <summary>
        /// Closes the View.
        /// </summary>
        void CloseView();
    }
}

using QuickStop.Client.Contracts.Views;
using QuickStop.Client.DTO;
using System;

namespace QuickStop.Client.Views
{
    /// <summary>
    /// Represents the View for <see cref="HotelBookingForm"/>.
    /// </summary>
    public partial class HotelBookingForm : IHotelBookingView
    {
        #region Events
        private event EventHandler RequestCreateReservation;

        event EventHandler IHotelBookingView.RequestCreateHotelBooking
        {
            add { RequestCreateReservation += value; }
            remove { RequestCreateReservation -= value; }
        }
        #endregion

        public HotelBookDTO HotelBookDTO { get; set; }


        void IHotelBookingView.DisplayHotelBooking(bool isReadOnly)
        {
            GuestCountPicker.Enabled = !isReadOnly;
            CheckOutDatePicker.Enabled = !isReadOnly;
            CheckInDatePicker.Enabled = !isReadOnly;
            ReserveButton.Visible = !isReadOnly;
            label2.Visible = !isReadOnly;

            ShowDialog();
        }

        void IHotelBookingView.CloseView()
        {
            Close();
        }
    }
}

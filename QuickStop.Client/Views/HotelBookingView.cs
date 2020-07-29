using QuickStop.Client.Contracts.Views;
using QuickStop.Client.ViewModels;
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

        public HotelBookingViewModel HotelBookingViewModel { get; set; }


        void IHotelBookingView.DisplayHotelBooking(bool isReadOnly)
        {
            numericUpDown1.Enabled = !isReadOnly;
            dateTimePicker1.Enabled = !isReadOnly;
            dateTimePicker2.Enabled = !isReadOnly;
            button1.Visible = !isReadOnly;
            label2.Visible = !isReadOnly;

            ShowDialog();
        }

        void IHotelBookingView.CloseView()
        {
            Close();
        }
    }
}

using QuickStop.Client.Contracts.Views;
using QuickStop.Client.ViewModels;
using System;

namespace QuickStop.Client.Views
{
    public partial class ReservationForm : IHotelBookingView
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

#pragma warning disable CS1066 // The default value specified will have no effect because it applies to a member that is used in contexts that do not allow optional arguments
        void IHotelBookingView.DisplayHotelBooking(bool isReadOnly = false)
#pragma warning restore CS1066 // The default value specified will have no effect because it applies to a member that is used in contexts that do not allow optional arguments
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

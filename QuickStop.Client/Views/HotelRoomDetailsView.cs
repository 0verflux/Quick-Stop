using QuickStop.Client.Contracts.Views;
using QuickStop.Components.CustomEventArgs;
using QuickStop.Components.Helpers;
using QuickStop.Domain.Models;
using System;

namespace QuickStop.Client.Views
{
    /// <summary>
    /// Represents the View for <see cref="HotelRoomDetailsForm"/>.
    /// </summary>
    public partial class HotelRoomDetailsForm : IHotelRoomDetailsView
    {
        #region Events
        private event EventHandler<HotelSelectedEventArgs> RequestReservation;

        event EventHandler<HotelSelectedEventArgs> IHotelRoomDetailsView.RequestHotelBooking
        {
            add { RequestReservation += value; }
            remove { RequestReservation -= value; }
        }
        #endregion

        void IHotelRoomDetailsView.DisplayHotelRoom(HotelRoom hotel)
        {
            Tag = hotel.ID.ToString();

            label1.Text = hotel.Name;
            label2.Text = hotel.Description;
            label4.Text = $"{hotel.Price:C2}/Night";
            label5.Text = $"{new string('★', hotel.Ratings)}{new string('☆', 5-hotel.Ratings)}";
            label7.Text = hotel.Location.ToString();
            label8.Text = $"{hotel.MinGuestCount} - {hotel.MaxGuestCount} guests";
            pictureBox1.Image = hotel.Room.ConvertToImage();

            ShowDialog();
        }
    }
}

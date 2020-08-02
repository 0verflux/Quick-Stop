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

            HotelRoomName.Text = hotel.Name;
            HotelRoomDescription.Text = hotel.Description;
            HotelRoomPrice.Text = $"{hotel.Price:C2}/Night";
            HotelRatings.Text = $"{new string('★', hotel.Ratings)}{new string('☆', 5-hotel.Ratings)}";
            HotelRoomLocation.Text = hotel.Location.ToString();
            HotelRoomGuestCount.Text = $"{hotel.MinGuestCount} - {hotel.MaxGuestCount} guests";
            HotelRoomImage.Image = hotel.Room.ConvertToImage();

            ShowDialog();
        }
    }
}

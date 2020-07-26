using QuickStop.Client.Contracts.Views;
using QuickStop.Components;
using QuickStop.Domain.Models;
using System;

namespace QuickStop.Client.Views
{
    public partial class HotelDetailsForm : IHotelDetailsView
    {
        #region Events
        private event EventHandler<HotelSelectedEventArgs> RequestReservation;

        event EventHandler<HotelSelectedEventArgs> IHotelDetailsView.RequestReservation
        {
            add { RequestReservation += value; }
            remove { RequestReservation -= value; }
        }
        #endregion

        void IHotelDetailsView.DisplayHotel(Hotel hotel)
        {
            Tag = hotel.ID.ToString();

            label1.Text = hotel.Name;
            label2.Text = hotel.Description;
            label4.Text = hotel.Price.ToString("C2");
            label5.Text = $"{new string('★', hotel.Ratings)}{new string('☆', 5-hotel.Ratings)}";
            label7.Text = hotel.Location.ToString();
            label8.Text = $"({hotel.MinGuestCount} - {hotel.MaxGuestCount})\rGuests";
            pictureBox1.Image = hotel.Room.ConvertToImage();

            ShowDialog();
        }
    }
}

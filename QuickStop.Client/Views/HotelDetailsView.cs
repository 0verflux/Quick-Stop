using QuickStop.Components;
using QuickStop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Client.Views
{
    public partial class HotelDetailsForm : IHotelDetailsView
    {
        private event EventHandler<HotelSelectedEventArgs> HotelSelected;

        event EventHandler<HotelSelectedEventArgs> IHotelDetailsView.HotelSelected
        {
            add { HotelSelected += value; }
            remove { HotelSelected -= value; }
        }

        void IHotelDetailsView.DisplayHotel(Hotel hotel)
        {
            Tag = hotel.ID.ToString();

            label1.Text = hotel.Name;
            label2.Text = hotel.Description;
            label4.Text = hotel.Price.ToString("C2");
            label5.Text = hotel.Ratings.ToString();
            label7.Text = hotel.Location.ToString();
            // TODO: Load Images from base64 string

            ShowDialog();
        }
    }
}

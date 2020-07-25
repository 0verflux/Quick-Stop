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
            // TODO: Update Controls

            ShowDialog();
        }
    }
}

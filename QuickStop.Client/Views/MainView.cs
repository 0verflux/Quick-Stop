using QuickStop.Components;
using QuickStop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Client.Views
{
    public partial class MainForm : IMainView
    {
        private event EventHandler<HotelSelectedEventArgs> HotelSelected;
        private event EventHandler<HotelFilterEventArgs> LoadFilteredHotel;

        event EventHandler<HotelSelectedEventArgs> IMainView.HotelSelected
        {
            add { HotelSelected += value; }
            remove { HotelSelected -= value; }
        }
        event EventHandler<HotelFilterEventArgs> IMainView.LoadFilteredHotel
        {
            add { LoadFilteredHotel += value; }
            remove { LoadFilteredHotel -= value; }
        }

        void IMainView.PopulateHotels(IEnumerable<Hotel> hotels)
        {
            //TODO: Populate FlowLayoutPanel
        }
    }
}

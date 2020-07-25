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
        private event EventHandler HotelFiltered;
        private event EventHandler HotelSorted;

        event EventHandler<HotelSelectedEventArgs> IMainView.HotelSelected
        {
            add { HotelSelected += value; }
            remove { HotelSelected -= value; }
        }
        event EventHandler IMainView.HotelFiltered
        {
            add { HotelFiltered += value; }
            remove { HotelFiltered -= value; }
        }
        event EventHandler IMainView.HotelSorted
        {
            add { HotelSorted += value; }
            remove { HotelSorted -= value; }
        }

        void IMainView.PopulateHotels(IEnumerable<Hotel> hotels)
        {
            //TODO: Populate FlowLayoutPanel
        }

        void IMainView.ViewHotelDetails(Hotel hotel)
        {
            //View Hotel Details Form
        }
    }
}

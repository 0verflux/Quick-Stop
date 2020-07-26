using QuickStop.Client.Contracts.Views;
using QuickStop.Client.Controls;
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
        private event EventHandler SaveData;

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

        event EventHandler IMainView.SaveData
        {
            add { SaveData += value; }
            remove { SaveData -= value; }
        }

        void IMainView.PopulateHotels(IEnumerable<Hotel> hotels)
        {
            SuspendLayout();
            
            flowLayoutPanel1.Controls.Clear();

            if (hotels == null) return;
            
            foreach(Hotel hotel in hotels)
            {
                HotelCard hotelCard = new HotelCard(hotel);
                hotelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                hotelCard.HotelSelected += ViewSelectedHotel;

                flowLayoutPanel1.Controls.Add(hotelCard);
            }

            ResumeLayout(true);
        }
    }
}

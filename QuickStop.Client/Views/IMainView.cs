using QuickStop.Components;
using QuickStop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Client.Views
{
    public interface IMainView
    {
        event EventHandler<HotelSelectedEventArgs> HotelSelected;
        event EventHandler HotelFiltered;
        event EventHandler HotelSorted;
        
        void PopulateHotels(IEnumerable<Hotel> hotels);
        void ViewHotelDetails(Hotel hotel);
    }
}

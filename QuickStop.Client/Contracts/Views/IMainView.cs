using QuickStop.Client.Contracts;
using QuickStop.Components;
using QuickStop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Client.Contracts.Views
{
    public interface IMainView : IView
    {
        event EventHandler<HotelSelectedEventArgs> HotelSelected;
        event EventHandler<HotelFilterEventArgs> LoadFilteredHotel;
        
        void PopulateHotels(IEnumerable<Hotel> hotels);
    }
}

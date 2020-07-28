
using QuickStop.Components.CustomEventArgs;
using QuickStop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickStop.Client.Contracts.Views
{
    public interface IHotelRoomDetailsView : IView
    {
        event EventHandler<HotelSelectedEventArgs> RequestHotelBooking;

        void DisplayHotelRoom(HotelRoom hotel);
    }
}

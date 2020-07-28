using System.Windows.Forms;

namespace QuickStop.Client.Contracts.Presenters
{
    public interface IHotelBookingPresenter
    {
        void RequestHotelBooking(int hotelIndex);
        void RequestViewHotelBooking(string reference);
    }
}
using System.Windows.Forms;

namespace QuickStop.Client.Contracts.Presenters
{
    public interface IHotelDetailsPresenter
    {
        void RequestViewHotelDetails(int hotelIndex);
    }
}
using System.Windows.Forms;

namespace QuickStop.Client.Contracts.Presenters
{
    public interface IHotelRoomDetailsPresenter
    {
        void RequestViewHotelRoomDetails(int hotelIndex);
    }
}
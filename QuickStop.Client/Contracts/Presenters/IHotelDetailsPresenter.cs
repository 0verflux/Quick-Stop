using System.Windows.Forms;

namespace QuickStop.Client.Contracts.Presenters
{
    public interface IHotelDetailsPresenter
    {
        DialogResult ShowHotelDetails(int hotelIndex);
    }
}
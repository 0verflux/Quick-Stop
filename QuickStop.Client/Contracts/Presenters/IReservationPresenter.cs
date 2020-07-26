using System.Windows.Forms;

namespace QuickStop.Client.Contracts.Presenters
{
    public interface IReservationPresenter
    {
        DialogResult ProceedReservation(int hotelIndex);
    }
}
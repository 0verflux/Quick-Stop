using System.Windows.Forms;

namespace QuickStop.Client.Contracts.Presenters
{
    public interface IReservationPresenter
    {
        void ProceedReservation(int hotelIndex);
    }
}
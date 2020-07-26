using QuickStop.Client.Base;
using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Components;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Contracts;
using System.Windows.Forms;

namespace QuickStop.Client.Presenters
{
    public sealed class HotelDetailsPresenter : PresenterBase<IHotelDetailsView>, IHotelDetailsPresenter
    {
        private readonly IHotelRepository hotelRepository;
        private readonly IReservationPresenter reservationPresenter;

        public HotelDetailsPresenter(IHotelDetailsView hotelDetailsView, IHotelRepository hotelRepository, IReservationPresenter reservationPresenter) : base(hotelDetailsView)
        {
            this.hotelRepository = hotelRepository;
            this.reservationPresenter = reservationPresenter;

            view.HotelSelected += HotelSelected;
        }

        private void HotelSelected(object s, HotelSelectedEventArgs e)
        {
            reservationPresenter.ProceedReservation(e.Index);
        }

        void IHotelDetailsPresenter.ShowHotelDetails(int hotelIndex)
        {
            Hotel selectedHotel = hotelRepository.FindHotelByID(hotelIndex);

            view.DisplayHotel(selectedHotel);
        }
    }
}

using QuickStop.Client.Base;
using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Components;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Contracts;

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

            view.RequestReservation += RequestReservation;
        }

        #region Hotel Details Logic
        void IHotelDetailsPresenter.RequestViewHotelDetails(int hotelIndex)
        {
            Hotel selectedHotel = hotelRepository.FindHotelByID(hotelIndex);

            view.DisplayHotel(selectedHotel);
        }
        #endregion

        #region Navigation
        //
        // Hotel Details -> Reservation
        //
        private void RequestReservation(object s, HotelSelectedEventArgs e)
        {
            reservationPresenter.RequestReservation(e.Index);
        }
        #endregion
    }
}


using QuickStop.Client.Base;
using QuickStop.Client.Views;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Client.Presenters
{
    public sealed class ReservationPresenter : PresenterBase<IReservationView>, IReservationPresenter
    {
        private readonly IHotelRepository hotelRepository;
        private readonly IReservationRepository reservationRepository;

        public ReservationPresenter(IReservationView reservationView, IHotelRepository hotelRepository, IReservationRepository reservationRepository) : base(reservationView)
        {
            this.hotelRepository = hotelRepository;
            this.reservationRepository = reservationRepository;

            view.CreateReservation += CreateReservation;
        }

        void IReservationPresenter.ProceedReservation(int hotelIndex)
        {
            Hotel selectedHotel = hotelRepository.FindHotelByID(hotelIndex);

            view.ShowReservation(selectedHotel, new Reservation());
        }

        private void CreateReservation(object s, EventArgs e)
        {
            Reservation reservation = view.GetReservation();

            // TODO: Validation for Reservation

            reservationRepository.CreateReservation(reservation);
        }
    }
}

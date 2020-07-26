
using QuickStop.Client.Base;
using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Components;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            view.UpdateReservation += UpdateReservation;
        }

        DialogResult IReservationPresenter.ProceedReservation(int hotelIndex)
        {
            Hotel selectedHotel = hotelRepository.FindHotelByID(hotelIndex);

            return view.ShowReservation(selectedHotel, new Reservation());
        }

        private void CreateReservation(object s, EventArgs e)
        {
            Reservation reservation = view.GetReservation();
            Hotel hotel = hotelRepository.FindHotelByID(reservation.HotelID);

            // TODO: Validation

            reservation.Reference = ReferenceGenerator.Generate(6);
            reservation.TotalCost = CalculateTotalCost(hotel.Price, reservation.GuestCount, (reservation.CheckOut - reservation.CheckIn).Days);

            reservationRepository.CreateReservation(reservation);
            hotelRepository.SetHotelInavailablity(reservation.HotelID, reservation.CheckOut);

            view.FinalizeReservation(reservation.Reference);
        }

        private void UpdateReservation(object s, EventArgs e)
        {
            var reservation = view.GetReservation();
            var hotel = hotelRepository.FindHotelByID(reservation.HotelID);

            reservation.TotalCost = CalculateTotalCost(hotel.Price, reservation.GuestCount, (reservation.CheckOut - reservation.CheckIn).Days);

            view.RefreshView(reservation);
        }

        private decimal CalculateTotalCost(decimal price, int count, int days)
        {
            return price * count * days;
        }
    }
}

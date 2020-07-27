using QuickStop.Client.Base;
using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Client.ViewModels;
using QuickStop.Components.Helpers;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Contracts;
using System;
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

            view.RequestCreateReservation += RequestCreateReservation;
        }

        void IReservationPresenter.RequestReservation(int hotelIndex)
        {
            Hotel selectedHotel = hotelRepository.FindHotelByID(hotelIndex);

            view.ReservationViewModel = new ReservationViewModel(hotelIndex)
            {
                HotelName = selectedHotel.Name,
                Cost = selectedHotel.Price,
                HotelDescription = selectedHotel.Description,
                HotelLocation = selectedHotel.Location.ToString(),
                HotelRoomImage = selectedHotel.Room.ConvertToImage(),
                MinimumGuestCount = selectedHotel.MinGuestCount,
                MaximumGuestCount = selectedHotel.MaxGuestCount,
                GuestCount = selectedHotel.MinGuestCount,
                TotalCost = selectedHotel.Price,
                CheckIn = DateTime.Now,
                CheckOut = DateTime.Now.AddDays(1)
            };

            view.DisplayReservation();
        }

        void IReservationPresenter.RequestViewReservation(string reference)
        {
            try
            {
                Reservation reservation = reservationRepository.GetReservation(reference);
                Hotel hotel = hotelRepository.FindHotelByID(reservation.HotelID);

                view.ReservationViewModel = new ReservationViewModel(hotel.ID)
                {
                    HotelName = hotel.Name,
                    HotelDescription = hotel.Description,
                    HotelLocation = hotel.Location.ToString(),
                    HotelRoomImage = hotel.Room.ConvertToImage(),
                    MinimumGuestCount = hotel.MinGuestCount,
                    MaximumGuestCount = hotel.MaxGuestCount,
                    GuestCount = reservation.GuestCount,
                    CheckIn = reservation.CheckIn,
                    CheckOut = reservation.CheckOut,
                    TotalCost = reservation.TotalCost
                };

                view.DisplayReservation(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured!\r\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequestCreateReservation(object s, EventArgs e)
        {
            Reservation reservation = view.ReservationViewModel.Reservation;
            reservation.Reference = ReferenceGenerator.Generate(6);

            reservationRepository.CreateReservation(reservation);
            hotelRepository.SetHotelInavailablity(reservation.HotelID, reservation.CheckOut);

            view.FinalizeReservation(reservation.Reference);
        }
    }
}
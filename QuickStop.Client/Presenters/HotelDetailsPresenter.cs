﻿using QuickStop.Client.Base;
using QuickStop.Client.Views;
using QuickStop.Components;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Contracts;

namespace QuickStop.Client.Presenters
{
    public sealed class HotelDetailsPresenter : PresenterBase<IHotelDetailsView>, IHotelDetailsPresenter
    {
        private readonly IHotelRepository hotelRepository;
        private readonly IReservationPresenter reservationPresenter;

        public HotelDetailsPresenter(IHotelDetailsView hotelDetailsView, IHotelRepository hotelRepository) : base(hotelDetailsView)
        {
            this.hotelRepository = hotelRepository;

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

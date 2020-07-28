using QuickStop.Client.Base;
using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Client.ViewModels;
using QuickStop.Components.Exceptions;
using QuickStop.Components.Helpers;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Contracts;
using System;
using System.Windows.Forms;

namespace QuickStop.Client.Presenters
{
    public sealed class ReservationPresenter : PresenterBase<IHotelBookingView>, IHotelBookingPresenter
    {
        private readonly IHotelRoomRepository hotelRoomRepository;
        private readonly IHotelBookingRepository hotelBookingRepository;
        private readonly IReferenceView referenceView;

        public ReservationPresenter(IHotelBookingView hotelBookingView, IHotelRoomRepository hotelRoomRepository, IHotelBookingRepository hotelBookingRepository, IReferenceView referenceView) : base(hotelBookingView)
        {
            this.hotelRoomRepository = hotelRoomRepository;
            this.hotelBookingRepository = hotelBookingRepository;
            this.referenceView = referenceView;

            view.RequestCreateHotelBooking += RequestCreateHotelBooking;
        }

        void IHotelBookingPresenter.RequestHotelBooking(int hotelIndex)
        {
            HotelRoom selectedHotel = hotelRoomRepository.FindHotelByID(hotelIndex);

            view.HotelBookingViewModel = new HotelBookingViewModel(hotelIndex)
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

            view.DisplayHotelBooking();
        }

        void IHotelBookingPresenter.RequestViewHotelBooking(string reference)
        {
            try
            {
                HotelBook reservation = hotelBookingRepository.FindBookHotel(reference);
                HotelRoom hotel = hotelRoomRepository.FindHotelByID(reservation.HotelID);

                view.HotelBookingViewModel = new HotelBookingViewModel(hotel.ID)
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

                view.DisplayHotelBooking(true);
            }
            catch(Exception ex)
            {
                MessageBox.Show("An Error Occured!\r\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequestCreateHotelBooking(object s, EventArgs e)
        {
            HotelBook hotelBook = view.HotelBookingViewModel.HotelBook;
            hotelBook.Reference = ReferenceGenerator.Generate(6);

            hotelBookingRepository.BookHotel(hotelBook);
            hotelRoomRepository.SetHotelInavailablity(hotelBook.HotelID, hotelBook.CheckOut);

            if (referenceView.DisplayBookingReference(hotelBook.Reference) == DialogResult.OK)
            {
                view.CloseView();
            }
        }
    }
}
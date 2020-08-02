using QuickStop.Client.Base;
using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Client.DTO;
using QuickStop.Components.Helpers;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Contracts;
using System;
using System.Windows.Forms;

namespace QuickStop.Client.Presenters
{
    /// <summary>
    /// Represents the Presenter for <see cref="Views.HotelBookingForm"/>.
    /// </summary>
    public sealed class HotelBookingPresenter : PresenterBase<IHotelBookingView>, IHotelBookingPresenter
    {
        private readonly IHotelRoomRepository hotelRoomRepository;
        private readonly IHotelBookRepository hotelBookingRepository;
        private readonly IReferenceView referenceView;

        /// <summary>
        /// Initializes a new instance of <see cref="HotelBookingPresenter"/>.
        /// </summary>
        /// <param name="hotelBookingView">The view assigned for the presenter.</param>
        /// <param name="hotelRoomRepository">The repository used for accessing the Hotel Room Data.</param>
        /// <param name="hotelBookingRepository">The repository used for accessing the Booked Hotel Room Data.</param>
        /// <param name="referenceView">The view assigned to show the final output.</param>
        public HotelBookingPresenter(IHotelBookingView hotelBookingView, IHotelRoomRepository hotelRoomRepository, IHotelBookRepository hotelBookingRepository, IReferenceView referenceView) : base(hotelBookingView)
        {
            this.hotelRoomRepository = hotelRoomRepository;
            this.hotelBookingRepository = hotelBookingRepository;
            this.referenceView = referenceView;

            view.RequestCreateHotelBooking += RequestCreateHotelBooking;
        }

        void IHotelBookingPresenter.RequestHotelBooking(int hotelIndex)
        {
            HotelRoom selectedHotel = hotelRoomRepository.FindHotelByID(hotelIndex);

            // Assigns a new Instance of HotelBookDTO, and updates the Control's Value that is Binded for Hotel Booking Details Form.
            view.HotelBookDTO = new HotelBookDTO(hotelIndex);

            view.HotelBookDTO.HotelName = selectedHotel.Name;
            view.HotelBookDTO.Cost = selectedHotel.Price;
            view.HotelBookDTO.HotelDescription = selectedHotel.Description;
            view.HotelBookDTO.HotelLocation = selectedHotel.Location.ToString();
            view.HotelBookDTO.HotelRoomImage = selectedHotel.Room.ConvertToImage();
            view.HotelBookDTO.MinimumGuestCount = selectedHotel.MinGuestCount;
            view.HotelBookDTO.MaximumGuestCount = selectedHotel.MaxGuestCount;
            view.HotelBookDTO.GuestCount = selectedHotel.MinGuestCount;
            view.HotelBookDTO.TotalCost = selectedHotel.Price;
            view.HotelBookDTO.CheckIn = DateTime.Now;
            view.HotelBookDTO.CheckOut = DateTime.Now.AddDays(1);


            view.DisplayHotelBooking();
        }

        void IHotelBookingPresenter.RequestViewHotelBooking(string reference)
        {
            try
            {
                HotelBook reservation = hotelBookingRepository.FindBookHotel(reference);
                HotelRoom hotel = hotelRoomRepository.FindHotelByID(reservation.HotelID);

                // Creates a new Instance of HotelBooDTO, and updates the Control's Value for Hotel Booking Details Form.
                view.HotelBookDTO = new HotelBookDTO(hotel.ID);

                view.HotelBookDTO.HotelName = hotel.Name;
                view.HotelBookDTO.HotelDescription = hotel.Description;
                view.HotelBookDTO.HotelLocation = hotel.Location.ToString();
                view.HotelBookDTO.HotelRoomImage = hotel.Room.ConvertToImage();
                view.HotelBookDTO.MinimumGuestCount = hotel.MinGuestCount;
                view.HotelBookDTO.MaximumGuestCount = hotel.MaxGuestCount;
                view.HotelBookDTO.GuestCount = reservation.GuestCount;
                view.HotelBookDTO.CheckIn = reservation.CheckIn;
                view.HotelBookDTO.CheckOut = reservation.CheckOut;
                view.HotelBookDTO.TotalCost = reservation.TotalCost;
                

                view.DisplayHotelBooking(true);
            }
            catch(Exception ex) // Catches any exception and display the error message.
            {
                MessageBox.Show("An Error Occured!\r\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RequestCreateHotelBooking(object s, EventArgs e)
        {
            HotelBook hotelBook = view.HotelBookDTO.HotelBook;
            hotelBook.Reference = ReferenceGenerator.Generate(6);   // Generates 6-character reference key.

            hotelBookingRepository.BookHotel(hotelBook);
            hotelRoomRepository.SetHotelInavailablity(hotelBook.HotelID, hotelBook.CheckOut);

            referenceView.DisplayBookingReference(hotelBook.Reference);
            view.CloseView();
        }
    }
}
using QuickStop.Client.Base;
using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Components.CustomEventArgs;
using QuickStop.Infrastructure.Contracts;
using System;

namespace QuickStop.Client.Presenters
{
    public sealed class MainPresenter : PresenterBase<IMainView>, IMainPresenter
    {
        private readonly IHotelRoomRepository hotelRoomRepository;
        private readonly IHotelRoomDetailsPresenter hotelRoomDetailsPresenter;
        private readonly IHotelBookingPresenter hotelBookingPresenter;

        public MainPresenter(IMainView mainView, IHotelRoomRepository hotelRoomRepository, IHotelRoomDetailsPresenter hotelRoomDetailsPresenter, IHotelBookingPresenter hotelBookingPresenter) : base(mainView)
        {
            this.hotelRoomRepository = hotelRoomRepository;
            this.hotelRoomDetailsPresenter = hotelRoomDetailsPresenter;
            this.hotelBookingPresenter = hotelBookingPresenter;

            view.RequestViewHotelRoomDetails += RequestViewHotelRoomDetails;
            view.RequestViewHotelBooking += RequestViewHotelBooking;
            view.RequestLoadHotels += RequestLoadHotels;
            view.RequestSaveData += RequestSaveData;
        }

        #region Main Logic
        private void RequestLoadHotels(object s, HotelFilterEventArgs e)
        {
            var hotels = hotelRoomRepository.GetHotels(e.Location, e.GuestCount, e.Sort);

            view.LoadHotels(hotels);
        }

        private void RequestSaveData(object s, EventArgs e)
        {
            hotelRoomRepository.Save();
        }
        #endregion

        #region Navigation
        //
        // Main -> Hotel Details
        //
        private void RequestViewHotelRoomDetails(object s, HotelSelectedEventArgs e)
        {
            hotelRoomDetailsPresenter.RequestViewHotelRoomDetails(e.Index);
        }

        //
        // Main -> Reservation
        //
        private void RequestViewHotelBooking(object s, BookReferenceEventArgs e)
        {
            hotelBookingPresenter.RequestViewHotelBooking(e.Reference);
        }
        #endregion
    }
}

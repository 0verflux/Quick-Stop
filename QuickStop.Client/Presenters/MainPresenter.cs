using QuickStop.Client.Base;
using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Components.CustomEventArgs;
using QuickStop.Infrastructure.Contracts;
using System;

namespace QuickStop.Client.Presenters
{
    /// <summary>
    /// Represents the Presenter for <see cref="MainForm"/>.
    /// </summary>
    public sealed class MainPresenter : PresenterBase<IMainView>, IMainPresenter
    {
        private readonly IHotelRoomRepository hotelRoomRepository;
        private readonly IHotelRoomDetailsPresenter hotelRoomDetailsPresenter;
        private readonly IHotelBookingPresenter hotelBookingPresenter;

        /// <summary>
        /// Initializes a new instance of <see cref="MainPresenter"/>.
        /// </summary>
        /// <param name="mainView">The view assigned for the presenter.</param>
        /// <param name="hotelRoomRepository">The repository used for accessing Hotel Room Data.</param>
        /// <param name="hotelRoomDetailsPresenter">The presenter used to interact in <see cref="MainPresenter"/>.</param>
        /// <param name="hotelBookingPresenter">The presenter used to interact in <see cref="MainPresenter"/>.</param>
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

        private void RequestLoadHotels(object s, HotelFilterEventArgs e)
        {
            var hotels = hotelRoomRepository.GetHotels(e.Location, e.GuestCount, e.Sort);

            view.LoadHotels(hotels);
        }

        private void RequestSaveData(object s, EventArgs e)
        {
            hotelRoomRepository.Save();
        }

        private void RequestViewHotelRoomDetails(object s, HotelSelectedEventArgs e)
        {
            hotelRoomDetailsPresenter.RequestViewHotelRoomDetails(e.Index);
        }

        private void RequestViewHotelBooking(object s, BookReferenceEventArgs e)
        {
            hotelBookingPresenter.RequestViewHotelBooking(e.Reference);
        }
    }
}

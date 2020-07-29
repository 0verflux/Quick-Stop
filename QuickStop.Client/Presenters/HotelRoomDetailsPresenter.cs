using QuickStop.Client.Base;
using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Components.CustomEventArgs;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Contracts;

namespace QuickStop.Client.Presenters
{
    /// <summary>
    /// Represents the Presenter for <see cref="Views.HotelRoomDetailsForm"/>.
    /// </summary>
    public sealed class HotelRoomDetailsPresenter : PresenterBase<IHotelRoomDetailsView>, IHotelRoomDetailsPresenter
    {
        private readonly IHotelRoomRepository hotelRoomRepository;
        private readonly IHotelBookingPresenter hotelBookingPresenter;

        /// <summary>
        /// Initializes a new instance of <see cref="HotelRoomDetailsPresenter"/>.
        /// </summary>
        /// <param name="hotelRoomDetailsView">The view assigned for the presenter.</param>
        /// <param name="hotelRoomRepository">The repository used for accessing Hotel Room Data.</param>
        /// <param name="hotelBookingPresenter">The presenter used to interact in <see cref="HotelRoomDetailsPresenter"/>.</param>
        public HotelRoomDetailsPresenter(IHotelRoomDetailsView hotelRoomDetailsView, IHotelRoomRepository hotelRoomRepository, IHotelBookingPresenter hotelBookingPresenter) : base(hotelRoomDetailsView)
        {
            this.hotelRoomRepository = hotelRoomRepository;
            this.hotelBookingPresenter = hotelBookingPresenter;

            view.RequestHotelBooking += RequestHotelBooking;
        }

        void IHotelRoomDetailsPresenter.RequestViewHotelRoomDetails(int hotelIndex)
        {
            HotelRoom selectedHotel = hotelRoomRepository.FindHotelByID(hotelIndex);

            view.DisplayHotelRoom(selectedHotel);
        }

        private void RequestHotelBooking(object s, HotelSelectedEventArgs e)
        {
            hotelBookingPresenter.RequestHotelBooking(e.Index);
        }
    }
}

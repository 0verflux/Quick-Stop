using QuickStop.Client.Base;
using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Components.CustomEventArgs;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Contracts;

namespace QuickStop.Client.Presenters
{
    public sealed class HotelRoomDetailsPresenter : PresenterBase<IHotelRoomDetailsView>, IHotelRoomDetailsPresenter
    {
        private readonly IHotelRoomRepository hotelRoomRepository;
        private readonly IHotelBookingPresenter hotelBookingPresenter;

        public HotelRoomDetailsPresenter(IHotelRoomDetailsView hotelRoomDetailsView, IHotelRoomRepository hotelRoomRepository, IHotelBookingPresenter hotelBookingPresenter) : base(hotelRoomDetailsView)
        {
            this.hotelRoomRepository = hotelRoomRepository;
            this.hotelBookingPresenter = hotelBookingPresenter;

            view.RequestHotelBooking += RequestHotelBooking;
        }

        #region Hotel Details Logic
        void IHotelRoomDetailsPresenter.RequestViewHotelRoomDetails(int hotelIndex)
        {
            HotelRoom selectedHotel = hotelRoomRepository.FindHotelByID(hotelIndex);

            view.DisplayHotelRoom(selectedHotel);
        }
        #endregion

        #region Navigation
        //
        // Hotel Details -> Reservation
        //
        private void RequestHotelBooking(object s, HotelSelectedEventArgs e)
        {
            hotelBookingPresenter.RequestHotelBooking(e.Index);
        }
        #endregion
    }
}

using QuickStop.Client.Base;
using QuickStop.Client.Views;
using QuickStop.Components;
using QuickStop.Infrastructure.Contracts;

namespace QuickStop.Client.Presenters
{
    public sealed class MainPresenter : PresenterBase<IMainView>, IMainPresenter
    {
        private readonly IHotelRepository hotelRepository;
        private readonly IHotelDetailsPresenter hotelDetailsPresenter;

        public MainPresenter(IMainView mainView, IHotelRepository hotelRepository, IHotelDetailsPresenter hotelDetailsPresenter) : base(mainView)
        {
            this.hotelRepository = hotelRepository;
            this.hotelDetailsPresenter = hotelDetailsPresenter;

            view.HotelSelected += HotelSelected;
            view.LoadFilteredHotel += LoadFilteredHotel;
        }

        private void HotelSelected(object s, HotelSelectedEventArgs e)
        {
            hotelDetailsPresenter.ShowHotelDetails(e.Index);
        }

        private void LoadFilteredHotel(object s, HotelFilterEventArgs e)
        {
            var hotels = hotelRepository.GetHotels(e.Location, e.GuestCount, e.Sort);

            view.PopulateHotels(hotels);
        }
    }
}

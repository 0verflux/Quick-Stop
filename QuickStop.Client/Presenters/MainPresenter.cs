using QuickStop.Client.Base;
using QuickStop.Client.Views;
using QuickStop.Components;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Client.Presenters
{
    public sealed class MainPresenter : PresenterBase<IMainView>
    {
        private readonly IHotelRepository hotelRepository;

        public MainPresenter(IMainView mainView, IHotelRepository hotelRepository) : base(mainView)
        {
            this.hotelRepository = hotelRepository;

            view.HotelSelected += HotelSelected;
            view.LoadFilteredHotel += LoadFilteredHotel;
        }

        private void HotelSelected(object s, HotelSelectedEventArgs e)
        {
            var selectedHotel = hotelRepository.FindHotelByID(e.Index);

            view.ViewHotelDetails(selectedHotel);
        }

        private void LoadFilteredHotel(object s, HotelFilterEventArgs e)
        {
            var hotels = hotelRepository.GetHotels(e.Location, e.GuestCount, e.SortMode);

            view.PopulateHotels(hotels);
        }
    }
}

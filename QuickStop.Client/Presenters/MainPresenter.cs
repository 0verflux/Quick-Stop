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
    public sealed class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly IHotelRepository hotelRepository;

        public MainPresenter(IMainView mainView, IHotelRepository hotelRepository)
        {
            this.mainView = mainView;
            this.hotelRepository = hotelRepository;

            mainView.HotelSelected += HotelSelected;
            mainView.LoadFilteredHotel += LoadFilteredHotel;
        }

        private void HotelSelected(object s, HotelSelectedEventArgs e)
        {
            var selectedHotel = hotelRepository.FindHotelByID(e.Index);

            mainView.ViewHotelDetails(selectedHotel);
        }

        private void LoadFilteredHotel(object s, HotelFilterEventArgs e)
        {
            var hotels = hotelRepository.GetHotels(e.Location, e.GuestCount, e.SortMode);

            mainView.PopulateHotels(hotels);
        }
    }
}

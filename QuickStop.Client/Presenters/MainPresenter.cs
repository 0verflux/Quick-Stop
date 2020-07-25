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
            mainView.HotelFiltered += HotelFiltered;
            mainView.HotelSorted += HotelSorted;
            LoadHotels();
        }

        private void LoadHotels()
        {
            var hotels = hotelRepository.Hotels;

            mainView.PopulateHotels(hotels);
        }

        private void HotelSelected(object s, HotelSelectedEventArgs e)
        {
            var selectedHotel = hotelRepository.FindHotelByID(e.Index);

            mainView.ViewHotelDetails(selectedHotel);
        }

        private void HotelFiltered(object s, EventArgs e)
        {
            var hotels = new List<Hotel>(); // TODO: Hotel Filters

            mainView.PopulateHotels(hotels);
        }

        private void HotelSorted(object s, EventArgs e)
        {
            var hotels = new List<Hotel>(); // TODO: Hotel Sorts

            mainView.PopulateHotels(hotels);
        }
    }
}

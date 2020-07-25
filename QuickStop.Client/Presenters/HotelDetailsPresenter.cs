using QuickStop.Client.Base;
using QuickStop.Client.Views;
using QuickStop.Domain.Models;
using QuickStop.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Client.Presenters
{
    public sealed class HotelDetailsPresenter : PresenterBase<IHotelDetailsView>
    {
        private Hotel selectedHotel;
        private readonly IHotelRepository hotelRepository;

        public HotelDetailsPresenter(IHotelDetailsView hotelDetailsView) : base(hotelDetailsView)
        {

        }
        

    }
}

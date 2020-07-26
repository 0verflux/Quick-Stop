using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Client.Presenters;
using QuickStop.Client.Views;
using QuickStop.Infrastructure.Contracts;
using QuickStop.Infrastructure.Repositories;
using QuickStop.Infrastructure.Serializers;
using System;
using System.Windows.Forms;

namespace QuickStop.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string s = @"C:\Users\franc\Desktop";

            IMainView mainView = new MainForm();
            IHotelDetailsView hotelDetailsView = new HotelDetailsForm();
            IReservationView reservationView = new ReservationForm();

            IHotelSerializer hotelSerializer = new HotelSerializer(s);
            IReservationSerializer reservationSerializer = new ReservationSerializer(s);

            IHotelRepository hotelRepository = new HotelRepository(hotelSerializer);
            IReservationRepository reservationRepository = new ReservationRepository(reservationSerializer);

            
            IReservationPresenter reservationPresenter = new ReservationPresenter(reservationView, hotelRepository, reservationRepository);
            IHotelDetailsPresenter hotelDetailsPresenter = new HotelDetailsPresenter(hotelDetailsView, hotelRepository, reservationPresenter);
            IMainPresenter mainPresenter = new MainPresenter(mainView, hotelRepository, hotelDetailsPresenter);

            Application.Run(mainView as MainForm);
        }
    }
}

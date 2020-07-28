using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Client.Presenters;
using QuickStop.Client.Views;
using QuickStop.Infrastructure.Contracts;
using QuickStop.Infrastructure.Repositories;
using QuickStop.Infrastructure.Serializers;
using System;
using System.IO;
using System.Windows.Forms;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

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
            using(var container = Register(Path.GetDirectoryName(Application.ExecutablePath)))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                container.Resolve<IMainPresenter>(); // Initialize MainPresenter First

                Application.Run(container.Resolve<IMainView>() as MainForm);
                
            }
        }

        static IUnityContainer Register(string filePath)
        {
            return new UnityContainer()
                .AddExtension(new Diagnostic())
                .RegisterType<IHotelSerializer, HotelSerializer>(new InjectionConstructor(filePath))
                .RegisterType<IHotelBookSerializer, HotelBookingSerializer>(new InjectionConstructor(filePath))
                .RegisterType<IMainView, MainForm>(new ContainerControlledLifetimeManager())
                .RegisterType<IHotelRoomDetailsView, HotelRoomDetailsForm>(new ContainerControlledLifetimeManager())
                .RegisterType<IHotelBookingView, HotelBookingForm>(new ContainerControlledLifetimeManager())
                .RegisterType<IReferenceView, ReferenceForm>(new ContainerControlledLifetimeManager())
                .RegisterType<IHotelRoomRepository, HotelRoomRepository>(new ContainerControlledLifetimeManager())
                .RegisterType<IHotelBookingRepository, HotelBookingRepository>(new ContainerControlledLifetimeManager())
                .RegisterType<IHotelBookingPresenter, HotelBookingPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<IHotelRoomDetailsPresenter, HotelRoomDetailsPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<IMainPresenter, MainPresenter>(new ContainerControlledLifetimeManager());
        }
    }
}

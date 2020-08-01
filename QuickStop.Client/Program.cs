using QuickStop.Client.Contracts.Presenters;
using QuickStop.Client.Contracts.Views;
using QuickStop.Client.Presenters;
using QuickStop.Client.Views;
using QuickStop.Infrastructure.Contracts;
using QuickStop.Infrastructure.Repositories;
using QuickStop.Infrastructure.ModelStreams;
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

        /// <summary>
        /// Creates an <see cref="IUnityContainer"/> to handle Dependency Injection.
        /// </summary>
        /// <param name="baseDirectory">The base directory of a text file to be injected in a Serializer.</param>
        /// <returns><see cref="IUnityContainer"/></returns>
        static IUnityContainer Register(string baseDirectory)
        {
            return new UnityContainer()
#if DEBUG
                .AddExtension(new Diagnostic()) // Necessary if a Certain Dependency Fails to Resolve or something.
#endif
                .RegisterType<IHotelRoomModelStream, HotelRoomModelStream>(new InjectionConstructor(baseDirectory))
                .RegisterType<IHotelBookModelStream, HotelBookModelStream>(new InjectionConstructor(baseDirectory))
                .RegisterType<IMainView, MainForm>(new ContainerControlledLifetimeManager())
                .RegisterType<IHotelRoomDetailsView, HotelRoomDetailsForm>(new ContainerControlledLifetimeManager())
                .RegisterType<IHotelBookingView, HotelBookingForm>(new ContainerControlledLifetimeManager())
                .RegisterType<IReferenceView, ReferenceForm>(new ContainerControlledLifetimeManager())
                .RegisterType<IHotelRoomRepository, HotelRoomRepository>(new ContainerControlledLifetimeManager())
                .RegisterType<IHotelBookRepository, HotelBookRepository>(new ContainerControlledLifetimeManager())
                .RegisterType<IHotelBookingPresenter, HotelBookingPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<IHotelRoomDetailsPresenter, HotelRoomDetailsPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<IMainPresenter, MainPresenter>(new ContainerControlledLifetimeManager());
        }
    }
}

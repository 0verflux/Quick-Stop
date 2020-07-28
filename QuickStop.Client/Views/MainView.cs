using QuickStop.Client.Contracts.Views;
using QuickStop.Client.Controls;
using QuickStop.Components.CustomEventArgs;
using QuickStop.Domain.Enums;
using QuickStop.Domain.Models;
using System;
using System.Collections.Generic;

namespace QuickStop.Client.Views
{
    public partial class MainForm : IMainView
    {
        #region Events
        private event EventHandler<HotelSelectedEventArgs> RequestViewHotelDetails;
        private event EventHandler<HotelFilterEventArgs> RequestLoadHotels;
        private event EventHandler<BookReferenceEventArgs> RequestViewReservation;
        private event EventHandler RequestSaveData;

        event EventHandler<HotelSelectedEventArgs> IMainView.RequestViewHotelRoomDetails
        {
            add { RequestViewHotelDetails += value; }
            remove { RequestViewHotelDetails -= value; }
        }
        event EventHandler<HotelFilterEventArgs> IMainView.RequestLoadHotels
        {
            add { RequestLoadHotels += value; }
            remove { RequestLoadHotels -= value; }
        }
        event EventHandler<BookReferenceEventArgs> IMainView.RequestViewHotelBooking
        {
            add { RequestViewReservation += value; }
            remove { RequestViewReservation -= value; }
        }
        event EventHandler IMainView.RequestSaveData
        {
            add { RequestSaveData += value; }
            remove { RequestSaveData -= value; }
        }
        #endregion

        private Location selectedLocation;
        private Sort sort;

        void IMainView.LoadHotels(IEnumerable<HotelRoom> hotels)
        {
            SuspendLayout();
            
            flowLayoutPanel1.Controls.Clear();

            if (hotels == null) return;
            
            foreach(HotelRoom hotel in hotels)
            {
                HotelCard hotelCard = new HotelCard(hotel)
                {
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    Margin = new System.Windows.Forms.Padding(6,12,6,12)
                };
                hotelCard.HotelSelected += ViewSelectedHotel;

                flowLayoutPanel1.Controls.Add(hotelCard);
            }

            ResumeLayout(true);
        }
    }
}

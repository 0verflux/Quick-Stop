using QuickStop.Client.Contracts.Views;
using QuickStop.Client.Controls;
using QuickStop.Components;
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
        private event EventHandler<ReservationReferenceEventArgs> RequestViewReservation;
        private event EventHandler RequestSaveData;

        event EventHandler<HotelSelectedEventArgs> IMainView.RequestViewHotelDetails
        {
            add { RequestViewHotelDetails += value; }
            remove { RequestViewHotelDetails -= value; }
        }
        event EventHandler<HotelFilterEventArgs> IMainView.RequestLoadHotels
        {
            add { RequestLoadHotels += value; }
            remove { RequestLoadHotels -= value; }
        }
        event EventHandler<ReservationReferenceEventArgs> IMainView.RequestViewReservation
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

        void IMainView.LoadHotels(IEnumerable<Hotel> hotels)
        {
            SuspendLayout();
            
            flowLayoutPanel1.Controls.Clear();

            if (hotels == null) return;
            
            foreach(Hotel hotel in hotels)
            {
                HotelCard hotelCard = new HotelCard(hotel)
                {
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                };
                hotelCard.HotelSelected += ViewSelectedHotel;

                flowLayoutPanel1.Controls.Add(hotelCard);
            }

            ResumeLayout(true);
        }
    }
}

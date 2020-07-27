using QuickStop.Components.Helpers;
using QuickStop.Domain.Enums;
using QuickStop.Domain.Models;
using System;
using System.ComponentModel;
using System.Drawing;

namespace QuickStop.Client.ViewModels
{
    public class ReservationViewModel : INotifyPropertyChanged
    {
        private int minimumGuestCount;
        private int maximumGuestCount;
        private Image image;
        private string name;
        private string description;
        private string location;

        public HotelBook Reservation { get; }

        public ReservationViewModel() : this(new HotelBook())
        {

        }

        public ReservationViewModel(int hotelID) : this(new HotelBook { HotelID = hotelID })
        {

        }

        public ReservationViewModel(HotelBook reservation)
        {
            Reservation = reservation;
        }

        public string HotelName
        {
            get { return name; }
            set
            {
                if (Equals(name, value))
                {
                    return;
                }

                name = value;
                OnPropertyChanged("HotelName");
            }
        }

        public string HotelDescription
        {
            get { return description; }
            set
            {
                if (Equals(description, value))
                {
                    return;
                }

                description = value;
                OnPropertyChanged("HotelDescription");
            }
        }
        
        public string HotelLocation
        {
            get { return location; }
            set
            {
                if (Equals(location, value))
                {
                    return;
                }

                location = value;
                OnPropertyChanged("HotelLocation");
            }
        }

        public Image HotelRoomImage
        {
            get { return image; }
            set
            {
                if (Equals(image, value))
                {
                    return;
                }

                image = value;
                OnPropertyChanged("HotelRoomImage");
            }
        }

        public int MinimumGuestCount
        {
            get { return minimumGuestCount; }
            set
            {
                if (Equals(minimumGuestCount, value))
                {
                    return;
                }

                minimumGuestCount = value;
                OnPropertyChanged("MinimumGuestCount");
            }
        }

        public int MaximumGuestCount
        {
            get { return maximumGuestCount; }
            set
            {
                if (Equals(maximumGuestCount, value))
                {
                    return;
                }

                maximumGuestCount = value;
                OnPropertyChanged("MaximumGuestCount");
            }
        }

        public int GuestCount
        {
            get { return Reservation.GuestCount; }
            set
            {
                if (Equals(Reservation.GuestCount, value))
                {
                    return;
                }

                Reservation.GuestCount = value;
                OnPropertyChanged("GuestCount");
            }
        }

        public decimal TotalCost
        {
            get { return Reservation.TotalCost; }
            set
            {
                if (Equals(Reservation.TotalCost, value))
                {
                    return;
                }

                Reservation.TotalCost = value;
                OnPropertyChanged("TotalCost");
            }
        }

        public DateTime CheckIn
        {
            get { return Reservation.CheckIn; }
            set
            {
                if (Equals(Reservation.CheckIn, value))
                {
                    return;
                }

                Reservation.CheckIn = value;
                OnPropertyChanged("CheckIn");
            }
        }

        public DateTime CheckOut
        {
            get { return Reservation.CheckOut; }
            set
            {
                if (Equals(Reservation.CheckOut, value))
                {
                    return;
                }

                Reservation.CheckOut = value;
                OnPropertyChanged("CheckOut");
            }
        }

        public decimal Cost { get; set; }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

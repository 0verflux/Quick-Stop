using QuickStop.Domain.Models;
using System;
using System.ComponentModel;
using System.Drawing;

namespace QuickStop.Client.ViewModels
{
    public class HotelBookingViewModel : INotifyPropertyChanged
    {
        private int minimumGuestCount;
        private int maximumGuestCount;
        private Image image;
        private string name;
        private string description;
        private string location;

        public HotelBook HotelBook { get; }

        public HotelBookingViewModel() : this(new HotelBook())
        {

        }

        public HotelBookingViewModel(int hotelID) : this(new HotelBook { HotelID = hotelID })
        {

        }

        public HotelBookingViewModel(HotelBook hotelBook)
        {
            HotelBook = hotelBook;
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
            get { return HotelBook.GuestCount; }
            set
            {
                if (Equals(HotelBook.GuestCount, value))
                {
                    return;
                }

                HotelBook.GuestCount = value;
                OnPropertyChanged("GuestCount");
            }
        }

        public decimal TotalCost
        {
            get { return HotelBook.TotalCost; }
            set
            {
                if (Equals(HotelBook.TotalCost, value))
                {
                    return;
                }

                HotelBook.TotalCost = value;
                OnPropertyChanged("TotalCost");
            }
        }

        public DateTime CheckIn
        {
            get { return HotelBook.CheckIn; }
            set
            {
                if (Equals(HotelBook.CheckIn, value))
                {
                    return;
                }

                HotelBook.CheckIn = value;
                OnPropertyChanged("CheckIn");
            }
        }

        public DateTime CheckOut
        {
            get { return HotelBook.CheckOut; }
            set
            {
                if (Equals(HotelBook.CheckOut, value))
                {
                    return;
                }

                HotelBook.CheckOut = value;
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

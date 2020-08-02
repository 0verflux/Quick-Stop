using QuickStop.Domain.Models;
using System;
using System.ComponentModel;
using System.Drawing;

namespace QuickStop.Client.DTO
{
    /// <summary>
    /// A Data Transfer Object for <see cref="Domain.Models.HotelBook"/> to listen each time a property changes.
    /// </summary>
    public class HotelBookDTO : INotifyPropertyChanged
    {
        private int minimumGuestCount;
        private int maximumGuestCount;
        private Image image;
        private string name;
        private string description;
        private string location;

        /// <summary>
        /// The Hotel Book Model.
        /// </summary>
        public HotelBook HotelBook { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="HotelBookDTO"/>.
        /// </summary>
        public HotelBookDTO() : this(new HotelBook())
        {

        }

        /// <summary>
        /// Initializes a new instance of <see cref="HotelBookDTO"/>, provided with the Hotel ID.
        /// </summary>
        /// <param name="hotelID">The hotel ID to be booked.</param>
        public HotelBookDTO(int hotelID) : this(new HotelBook { HotelID = hotelID })
        {

        }

        /// <summary>
        /// Initializes a new instance of <see cref="HotelBookDTO"/>, with an existing <see cref="Domain.Models.HotelBook"/>.
        /// </summary>
        /// <param name="hotelBook">The <see cref="Domain.Models.HotelBook"/> to be assigned.</param>
        public HotelBookDTO(HotelBook hotelBook)
        {
            HotelBook = hotelBook;
        }

        /// <summary>
        /// The Hotel's Name.
        /// </summary>
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

        /// <summary>
        /// The Hotel's Description.
        /// </summary>
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
        
        /// <summary>
        /// The Hotel's Location.
        /// </summary>
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

        /// <summary>
        /// The Hotel's Room Image.
        /// </summary>
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

        /// <summary>
        /// The Minimum Guest Count for a Hotel Room.
        /// </summary>
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

        /// <summary>
        /// The Maximum Guest Count for a Hotel Room.
        /// </summary>
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

        /// <summary>
        /// The current guest count booked in a Hotel Room.
        /// </summary>
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

        /// <summary>
        /// The total cost for a booked Hotel Room.
        /// </summary>
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

        /// <summary>
        /// The Check-In Date for a Booked Hotel Room.
        /// </summary>
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

        /// <summary>
        /// The Check-Out Date for a Booked Hotel Room.
        /// </summary>
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

        /// <summary>
        /// Notifies all Data-Binded Controls that a certain Property has been changed.
        /// </summary>
        /// <param name="propertyName">The property name to be notified.</param>
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Occurs when a Property value has been Changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

using System;
using System.Windows.Forms;
using QuickStop.Domain.Models;
using QuickStop.Components.CustomEventArgs;
using QuickStop.Components.Helpers;

namespace QuickStop.Client.Controls
{
    /// <summary>
    /// Represents a placeholder to display a <see cref="HotelRoom"/>.
    /// </summary>
    public partial class HotelCard : UserControl
    {
        #region Events
        /// <summary>
        /// Occurs when the user Selected this <see cref="HotelCard"/>.
        /// </summary>
        public event EventHandler<HotelSelectedEventArgs> HotelSelected;
        #endregion

        private readonly int hotelID;

        /// <summary>
        /// Initializes a new Instance of <see cref="HotelCard"/>.
        /// </summary>
        public HotelCard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new Instance of <see cref="HotelCard"/>, with an assigned <see cref="HotelRoom"/>.
        /// </summary>
        /// <param name="hotel">The <see cref="HotelRoom"/> to be displayed.</param>
        public HotelCard(HotelRoom hotel) : this()
        {
            hotelID = hotel.ID;
            pictureBox1.Image = hotel.Icon.ConvertToImage();
            label1.Text = hotel.Name;
            label2.Text = $"{hotel.Price:C2}/Night";
            label3.Text = $"{new string('★', hotel.Ratings)}{new string('☆', 5 - hotel.Ratings)}";
        }

        private void ViewHotelOnClick(object sender, EventArgs e)
        {
            HotelSelected?.Invoke(this, new HotelSelectedEventArgs(hotelID));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickStop.Domain.Models;
using QuickStop.Components.CustomEventArgs;
using QuickStop.Components.Helpers;

namespace QuickStop.Client.Controls
{
    public partial class HotelCard : UserControl
    {
        private readonly int hotelID;
        public event EventHandler<HotelSelectedEventArgs> HotelSelected;

        public HotelCard()
        {
            InitializeComponent();
        }

        public HotelCard(Hotel hotel) : this()
        {
            hotelID = hotel.ID;
            pictureBox1.Image = hotel.Icon.ConvertToImage();
            label1.Text = hotel.Name;
            label2.Text = $"{hotel.Price:C2}\r\n per Night";
            label3.Text = $"{new string('★', hotel.Ratings)}{new string('☆', 5 - hotel.Ratings)}";
        }

        private void ViewHotelOnClick(object sender, EventArgs e)
        {
            HotelSelected?.Invoke(this, new HotelSelectedEventArgs(hotelID));
        }
    }
}

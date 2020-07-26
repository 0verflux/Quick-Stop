using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickStop.Client.Views
{
    public partial class HotelDetailsForm : Form
    {
        public HotelDetailsForm()
        {
            InitializeComponent();
        }

        private void BookHotelOnClick(object sender, EventArgs e)
        {
            HotelSelected?.Invoke(sender, new Components.HotelSelectedEventArgs(Convert.ToInt32(Tag)));
        }
    }
}

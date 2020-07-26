using QuickStop.Client.Controls;
using QuickStop.Components;
using QuickStop.Domain.Enums;
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
    public partial class MainForm : Form
    {
        private Location selectedLocation;
        private Sort sort;

        public MainForm()
        {
            InitializeComponent();
        }

        private void QueryHotels(object sender, EventArgs e)
        {
            LoadFilteredHotel?.Invoke(sender, new HotelFilterEventArgs(selectedLocation, (int)numericUpDown2.Value, sort));
        }

        private void ViewSelectedHotel(object sender, HotelSelectedEventArgs e)
        {
            HotelSelected?.Invoke(sender, e);
        }

        private void SelectedLocationChanged(object sender, EventArgs e)
        {
            var btn = sender as RadioToggleButton;

            if (btn.Checked)
            {
                selectedLocation = (Location)Enum.Parse(typeof(Location), btn.Tag.ToString());
            }
        }

        private void SelectedSortChanged(object sender, EventArgs e)
        {
            var btn = sender as RadioToggleButton;

            if(btn.Checked)
            {
                sort = (Sort)Enum.Parse(typeof(Sort), btn.Tag.ToString());
            }
        }
    }
}

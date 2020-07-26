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
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void NotifyInputChanged(object sender, EventArgs e)
        {
            UpdateReservation?.Invoke(sender, e);
        }

        private void BookOnClick(object sender, EventArgs e)
        {
            CreateReservation?.Invoke(sender, e);
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Models
{
    

    public class Hotel
    {
        #region Sort Filters

        decimal Price;
        float Rating;

        #endregion

        #region Hotel Filters

        Locations HotelLocation;

        public int MinGuestCount;
        public int MaxGuestCount;

        #endregion

        #region Private Members

        public bool IsAvailable;
        public int DurationOfStay;
        public DateTime CheckIn;

        #endregion
    }
}

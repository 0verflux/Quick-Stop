namespace QuickStop.Client.Contracts.Presenters
{
    /// <summary>
    /// Represents the Presenter for <see cref="Client.Views.HotelBookingForm"/>.
    /// </summary>
    public interface IHotelBookingPresenter
    {
        /// <summary>
        /// Requests this presenter to proceed with the hotel room booking details.
        /// </summary>
        /// <param name="hotelIndex">The Hotel Room to be booked.</param>
        void RequestHotelBooking(int hotelIndex);

        /// <summary>
        /// Requests this presenter to view a Booked Hotel Room.
        /// </summary>
        /// <param name="reference">The key to view the Booked Hotel Room.</param>
        void RequestViewHotelBooking(string reference);
    }
}
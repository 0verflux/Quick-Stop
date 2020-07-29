namespace QuickStop.Client.Contracts.Presenters
{
    /// <summary>
    /// Represents the Presenter for <see cref="Client.Views.HotelRoomDetailsForm"/>.
    /// </summary>
    public interface IHotelRoomDetailsPresenter
    {
        /// <summary>
        /// Requests this presenter to view Hotel Room Details.
        /// </summary>
        /// <param name="hotelIndex">The Hotel Room to be displayed.</param>
        void RequestViewHotelRoomDetails(int hotelIndex);
    }
}
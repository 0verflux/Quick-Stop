namespace QuickStop.Client.Contracts.Views
{
    /// <summary>
    /// Represents the View for <see cref="Client.Views.ReferenceForm"/>.
    /// </summary>
    public interface IReferenceView
    {
        /// <summary>
        /// Displays the form showing that the user has successfully booked a Hotel Room.
        /// </summary>
        /// <param name="reference">The Reference Key to be copied or viewed by the User.</param>
        /// <returns>Nothing. It just confirms that the form has successfully booked a Hotel Room.</returns>
        void DisplayBookingReference(string reference);
    }
}

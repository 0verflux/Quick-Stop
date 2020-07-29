using QuickStop.Client.Contracts;

namespace QuickStop.Client.Base
{
    /// <summary>
    /// Provides a base class for a Presenter.
    /// </summary>
    /// <typeparam name="TView"></typeparam>
    public abstract class PresenterBase<TView> where TView : IView
    {
        protected TView view;

        /// <summary>
        /// Initializes a new Instace of <see cref="PresenterBase{TView}"/>.
        /// </summary>
        /// <param name="view">The View to listen events.</param>
        protected PresenterBase(TView view)
        {
            this.view = view;
        }
    }
}

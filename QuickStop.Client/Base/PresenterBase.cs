using QuickStop.Client.Contracts;

namespace QuickStop.Client.Base
{
    public abstract class PresenterBase<TView> where TView : IView
    {
        public IView View { get; private set; }

        protected PresenterBase(IView view)
        {
            View = view;
        }
    }
}

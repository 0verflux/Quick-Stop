using QuickStop.Client.Contracts;

namespace QuickStop.Client.Base
{
    public abstract class PresenterBase<TView> where TView : IView
    {
        protected TView view;

        protected PresenterBase(TView view)
        {
            this.view = view;
        }
    }
}

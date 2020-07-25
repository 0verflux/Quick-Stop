using QuickStop.Client.Base;
using QuickStop.Client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStop.Client.Presenters
{
    public sealed class MainPresenter : PresenterBase<IMainView>, IMainPresenter
    {
        public MainPresenter(IMainView mainView) : base(mainView)
        {

        }
    }
}

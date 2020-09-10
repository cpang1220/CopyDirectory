using System;
using System.Collections.Generic;
using System.Text;
using CopyDomain;

namespace CopyDirectory.View
{
    public interface IMainView
    {
        Presenter.MainPresenter Presenter { set; }

        string CopyFileNameText { get; set; }
        string CopyFilePathText { get; set; }

        PreviewHandlerHost PreviewHandlerHst { get;  set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek.WPF.MVVM.Services
{
    public interface IWindowService
    {
        void Show<TViewModel>(TViewModel model);
        bool ShowDialog<TViewModel>(TViewModel model);
    }
}

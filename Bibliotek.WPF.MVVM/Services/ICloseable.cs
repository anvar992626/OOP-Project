using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek.WPF.MVVM.Services
{
    public interface ICloseable
    {
        void Close();
        bool? DialogResults { get; set; }
    }
}

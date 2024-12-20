using GalaSoft.MvvmLight.Threading;
using Go.Base;
using Go.DataBase;
using Go.Dispatcher;
using Go.Services;
using Go.View;
using Go.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go
{
    public static class Locator
    {
        internal static readonly object ViewService;

        public static GoViewModel GoViewModel => new GoViewModel();

    }
}

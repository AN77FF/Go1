using Go.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go.View
{

    public class  ViewService : IViewService
    {
        public void Show()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        void IViewService.ShowView<T>()
        {
            throw new NotImplementedException();
        }
    }
}


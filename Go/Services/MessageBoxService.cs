using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Go.Services
{
    public class MessageBoxService : IMessageBoxService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}


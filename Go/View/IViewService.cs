using Go.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go.View
{
        public interface IViewService
        {
            void ShowView<T>() where T : IViewModel;
        }
}


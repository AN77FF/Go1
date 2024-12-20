using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go.Dispatcher
{
        public interface IDispatcher
        {
            void DispatchCommand(string command);
        }
}


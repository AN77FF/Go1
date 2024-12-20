using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go.Messages
{
        public class CpuChangedMessage
        {
            public int NewCpuValue { get; set; }

            public CpuChangedMessage(int newCpuValue)
            {
                NewCpuValue = newCpuValue;
            }
        }
}


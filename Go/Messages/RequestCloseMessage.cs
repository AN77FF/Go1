using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go.Messages
{
        public class RequestCloseMessage
        {
            public string Message { get; set; }

            public RequestCloseMessage(string message)
            {
                Message = message;
            }
        }
}


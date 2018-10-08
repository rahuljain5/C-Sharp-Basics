using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemos
{
    class InvalidAmountException : ApplicationException
    {
        public InvalidAmountException(string msg = null, Exception inner = null) : base(msg, inner) {   }
    }
}

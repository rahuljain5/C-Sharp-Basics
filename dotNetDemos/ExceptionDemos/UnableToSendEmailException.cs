using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemos
{
    class UnableToSendEmailException: ApplicationException
    {
        public UnableToSendEmailException(string msg, Exception inner = null): base(msg, inner) { }
    }
}

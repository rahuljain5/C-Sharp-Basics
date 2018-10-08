using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement
{
    class AccountClosingFailedException : ApplicationException
    {
        public AccountClosingFailedException(string msg = null, Exception e = null) : base(msg, e) { }
    }
}

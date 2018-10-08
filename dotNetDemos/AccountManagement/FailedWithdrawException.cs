using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement
{
    class FailedWithdrawException : ApplicationException
    {
        public FailedWithdrawException(string msg = null, Exception e = null) : base(msg, e) { }
    }
}

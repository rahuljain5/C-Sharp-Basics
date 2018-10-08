using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement
{
    class FailedDepositException : ApplicationException
    {
        public FailedDepositException(string msg = null, Exception e = null) : base(msg, e) { }
    }
}

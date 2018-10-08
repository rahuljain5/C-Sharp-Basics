using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement
{
    class AccountOpeningFailedException: ApplicationException
    {
        public AccountOpeningFailedException(string msg = null, Exception e = null) : base(msg, e) { }
    }
}

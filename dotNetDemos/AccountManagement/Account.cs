using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement
{
    class Account
    {
        public string AccNo { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public string PIN { get; set; }
        public bool isActive { get; set; }
    }
}

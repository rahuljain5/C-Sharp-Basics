using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipApp
{
    class RegCustomer : Customer
    {
        public DateTime RegDate { get; set; }
        public Membership Membership { get; set; }
       
    }
}

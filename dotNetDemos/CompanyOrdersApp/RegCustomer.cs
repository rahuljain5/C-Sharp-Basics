using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrdersApp
{
    class RegCustomer : Customer
    {
        public double SplDiscount { get; set; }
        public override double GetCustomerValue()
        {
            double customerValue = base.GetCustomerValue();
            return ((1.0 - SplDiscount/100) * customerValue );
        }

    }
}

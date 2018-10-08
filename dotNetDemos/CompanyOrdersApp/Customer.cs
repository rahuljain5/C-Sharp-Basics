using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyOrdersApp
{
    public class Customer
    {
        public List<Order> Orders = new List<Order>();
        public virtual double GetCustomerValue() {
            double customerValue = 0;
            foreach(Order order in Orders)
            {
                customerValue += order.GetOrderValue();
            }
            return customerValue;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyOrdersApp
{
    public class Order
    {
        public List<OrderItem> orderItems = new List<OrderItem>();

        public double GetOrderValue()
        {
            double orderValue = 0;
            foreach(OrderItem oi in orderItems)
            {
                orderValue += oi.GetOrderItemValue();
            }
            return orderValue;
        }
    }
}
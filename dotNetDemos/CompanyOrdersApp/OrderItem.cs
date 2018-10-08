using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyOrdersApp
{
    public class OrderItem
    {
        public Item Item { get; set; }
        public int Qty { get ; set ; }
        public double GetOrderItemValue()
        {
            return Item.Rate * Qty;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSaleApp
{
    public class Sale
    {
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public SaleItem SaleItem { get; set; }
    }
}
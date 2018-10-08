using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSaleApp
{
    public class TaxCalculator
    {
        public double CalculateIST(double amount)
        {
            return .1 * amount;
        }
        public double CalculateCentralTax(double amount)
        {
            return .15 * amount;
        }
    }
}
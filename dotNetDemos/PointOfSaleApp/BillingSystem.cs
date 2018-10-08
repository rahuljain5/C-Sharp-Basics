using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSaleApp
{
    public class BillingSystem
    {
        public void GenerateBill(SaleList list)
        {
            double total = 0, i =1, amt;
            TaxCalculator calculator = new TaxCalculator();
            Console.WriteLine("Sl.No\tDescription\tRate\tQuantity\tDiscount\tAmount");
            foreach (Sale sale in list.Sales)
            {
                amt = (sale.Quantity * sale.SaleItem.Rate) -(sale.Discount * sale.Quantity * sale.SaleItem.Rate);
                Console.WriteLine($"{i++}\t{sale.SaleItem.Description}\t\t{sale.SaleItem.Rate}\t{sale.Quantity}\t\t{sale.Discount}\t\t{(amt)}");
                total += amt;
            }
            double stateTax = calculator.CalculateIST(total);
            double centralTax = calculator.CalculateCentralTax(total);
            Console.WriteLine("State Tax:\t\t\t" + stateTax);
            Console.WriteLine("Central Tax:\t\t\t" + centralTax);
            Console.WriteLine("Total:\t\t\t\t" + (total + stateTax + centralTax));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SaleList saleList = new SaleList();
            Sale sale = new Sale();
            Sale sale2 = new Sale();
            SaleItem item = new SaleItem { Description = "Pen", Rate = 100 };
            SaleItem item2 = new SaleItem { Description = "Pencil", Rate = 20 };
            sale.SaleItem = item;
            sale.Quantity = 5;
            sale.Discount = 0.02;
            saleList.Sales.Add(sale);
            sale2.SaleItem = item2;
            sale2.Quantity = 8;
            sale2.Discount = 0.01;
            saleList.Sales.Add(sale2);
            BillingSystem bs = new BillingSystem();
            bs.GenerateBill(saleList);
            //saleList.Sales.Add()
        }
    }
}

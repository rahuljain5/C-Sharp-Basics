using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrdersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            Item i1 = new Item { Desc = "pen", Rate = 15 };
            Item i2 = new Item { Desc = "pencil", Rate = 10 };
            Item i3 = new Item { Desc = "stencil", Rate = 25 };
            company.Items.Add(i1);
            company.Items.Add(i2);
            company.Items.Add(i3);

            RegCustomer reg1 = new RegCustomer { SplDiscount = 5 };
            Customer customer1 = new Customer();

            Order o1 = new Order();
            Order o2 = new Order();
            Order o3 = new Order();

            OrderItem oi1 = new OrderItem { Qty = 4,  Item = i1 };
            OrderItem oi2 = new OrderItem { Qty = 40, Item = i2 };
            OrderItem oi3 = new OrderItem { Qty = 14, Item = i1 };
            OrderItem oi4 = new OrderItem { Qty = 1,  Item = i3 };

            o1.orderItems.Add(oi1);
            o1.orderItems.Add(oi3);
            o2.orderItems.Add(oi1);
            o2.orderItems.Add(oi2);
            o2.orderItems.Add(oi3);
            o3.orderItems.Add(oi4);
            o3.orderItems.Add(oi2);

            customer1.Orders.Add(o1);
            customer1.Orders.Add(o3);
            reg1.Orders.Add(o2);
            reg1.Orders.Add(o1);
            reg1.Orders.Add(o3);

            company.Customers.Add(reg1);
            company.Customers.Add(customer1);

            Console.WriteLine(company.GetTotalWorthOfOrdersPlaced());


        }
    }
}

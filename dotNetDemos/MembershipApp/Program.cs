using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            Customer customer1 = new Customer { CustomerId = 111, Email = "c1@b.c", Name="Cust1"};
            Customer customer2 = new Customer { CustomerId = 112, Email = "c2@b.c", Name="Cust2"};
            RegCustomer reg1 = new RegCustomer
            {
                CustomerId = 101,
                Name = "Reg1",
                RegDate = DateTime.Now.AddMonths(-1),
                Email = "reg1@mail.com",
                Membership = MembershipFactory.Instance.GetMembership("silver")
            };
            RegCustomer reg2 = new RegCustomer
            {
                CustomerId = 102,
                Name = "Reg2",
                RegDate = DateTime.Now.AddMonths(-2),
                Email = "reg2@mail.com",
                Membership = MembershipFactory.Instance.GetMembership("silver")
    };
            RegCustomer reg3 = new RegCustomer
            {
                CustomerId = 103,
                Name = "Reg3",
                RegDate = DateTime.Now.AddMonths(-1),
                Email = "reg3@mail.com",
                Membership = MembershipFactory.Instance.GetMembership("gold")
            };
            RegCustomer reg4 = new RegCustomer
            {
                CustomerId = 104,
                Name = "Reg4",
                RegDate = DateTime.Now.AddMonths(-1),
                Email = "reg1@mail.com",
                Membership = MembershipFactory.Instance.GetMembership("platinum")
            };
            company.Customers.Add(customer1);
            company.Customers.Add(customer2);
            company.Customers.Add(reg1);
            company.Customers.Add(reg2);
            company.Customers.Add(reg3);
            company.Customers.Add(reg4);
            Console.WriteLine("Total Customers: "+company.GetTotalCustomersCount()); 
            Console.WriteLine("Total Registered Customers: "+company.GetTotalRegCustomerCount()); 
            Console.WriteLine("Total Revenue: "+company.GetTotalFeeCollected()); 
        }
    }
}

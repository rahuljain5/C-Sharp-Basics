using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyOrdersApp
{
    public class Company
    {
        public Company()
        {
            Items = new List<Item>(); ;
            Customers = new List<Customer>();
        }

        public List<Item> Items { get; set; }
        public List<Customer> Customers { get; set; }
        

        public double GetTotalWorthOfOrdersPlaced()
        {
            double amount = 0;
            foreach(Customer customer in Customers)
            {
                amount += customer.GetCustomerValue();
            }
            return amount;
        }
    }
}
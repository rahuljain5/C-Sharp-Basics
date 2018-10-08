using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipApp
{
    class Company
    {
        public Company()
        {
            Customers = new List<Customer>();
        }
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
        public int GetTotalCustomersCount()
        {
            return Customers.Count;
        }
        public int GetTotalRegCustomerCount()
        {
            int regCount = 0;
            foreach (Customer cust in Customers)
            {
                if (cust is RegCustomer)
                    regCount++;
            }
            return regCount;
        }
        public double GetTotalFeeCollected()
        {
            double regAmount = 0;
            foreach (Customer cust in Customers)
            {
                if (cust is RegCustomer)
                {
                    RegCustomer rCust = (RegCustomer)cust;
                    regAmount += rCust.Membership.Fee;
                }
            }
            return regAmount;
        }

    }
}

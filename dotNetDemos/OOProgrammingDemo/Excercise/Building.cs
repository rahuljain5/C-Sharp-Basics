using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo.Excercise
{
    class Building : Property
    {
        public Building(string name, double cost, int yearPurchased, double assessment, string addr) : base(name, cost, yearPurchased, assessment)
        {
            Address = addr;
        }

        public string Address { get; set; }

        new public void Print()
        {
            base.Print();
            Console.WriteLine($"Address : {Address}");
        }
    }
}

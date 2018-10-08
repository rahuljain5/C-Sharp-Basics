using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo.Excercise
{
    class Asset
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public int YearPurchased { get; set; }

        public Asset(string name, double cost, int yearPurchased)
        {
            Name = name;
            Cost = cost;
            YearPurchased = yearPurchased;
        }


        public double AmortizedCost(int currentYear)
        {
            return Cost / (currentYear - YearPurchased);
        }

        public double ComputeCost()
        {
            return Cost;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Cost: {Cost}, Year of Purchase: {YearPurchased}");
        }
    }
}

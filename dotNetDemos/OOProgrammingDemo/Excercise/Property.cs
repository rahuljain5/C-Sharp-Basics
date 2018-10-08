using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo.Excercise
{
    class Property : Asset
    {
        public Property(string name, double cost, int yearPurchased, double assessment) : base(name, cost, yearPurchased)
        {
            Assessment = assessment;
        }

        private double Assessment { get; set; }

        new public double ComputeCost()
        {
            return Assessment;
        }

        new public void Print()
        {
            base.Print();
            Console.WriteLine($"Assessment : {Assessment}");
            
        }
    }
}

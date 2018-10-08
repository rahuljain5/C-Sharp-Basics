using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo.Excercise
{
    class Stock : Asset
    {
        public Stock(string name, double cost, int yearPurchased, int shares, string symbol, double price) : base(name, cost, yearPurchased)
        {
            Shares = shares;
            Symbol = symbol;
            Price = price;
        }

        private int Shares { get; set; }
        private string Symbol { get; set; }
        private double Price { get; set; }

        new public double ComputeCost()
        {
            return Price*Shares;
        }

        new public void Print() 
        {
            base.Print();
            Console.WriteLine($"Shares: {Shares}, Symbol: {Symbol}, Price: {Price}");
        }
    }
}

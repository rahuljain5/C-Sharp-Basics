using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo.Excercise
{
    class Invest
    {
        public static void Main()
        {
            Stock microsoft = new Stock("Microsoft", 8000, 1994, 200, "MSFT", 56);
            Building beachHouse = new Building("Beach House", 9000, 1964, 35000, "123 seashore Ave");
            Art nightHawks = new Art("Night Hawks", 850, 1955, 7500, "Edward Hopper", 1942);

            Console.WriteLine("Amortized Costs Per Year:\n");

            Console.WriteLine($"Microsoft Stock {Math.Round(microsoft.AmortizedCost(2002), 3)}");
            Console.WriteLine($"Beach House Stock {Math.Round(beachHouse.AmortizedCost(2002), 3)}");
            Console.WriteLine($"Night Hawks Stock {Math.Round(nightHawks.AmortizedCost(2002), 3)}");
            PrintLine();

            Console.WriteLine("Valuations:\n");
            Console.WriteLine($"Microsoft Stock : {microsoft.ComputeCost()}");
            Console.WriteLine($"Beach House : {beachHouse.ComputeCost()}");
            Console.WriteLine($"Night Hawks : {nightHawks.ComputeCost()}");

            PrintLine();
            microsoft.Print();
            PrintLine();
            beachHouse.Print();
            PrintLine();
            nightHawks.Print();
            PrintLine();
        }

        public static void PrintLine()
        {
            Console.WriteLine("-------------------------------------------------------------------------------\n");
        }

    }
}

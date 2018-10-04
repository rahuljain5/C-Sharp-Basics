using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class Power
    {
        static void Main()
        {
            int x, y;
            Console.WriteLine("Base: ");
            x = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Power: ");
            y = (int.Parse(Console.ReadLine()));
            Console.WriteLine("X^y is : " + Math.Pow(x, y));
        }
    }
}

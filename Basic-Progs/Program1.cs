using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class Program1
    {
        static void Main()
        {
            Console.WriteLine("Program to find Odd or Even Number!");
            int number1 = 0;
            if (number1 != 0)
            {
                if (number1 % 2 == 0)
                {
                    Console.WriteLine(number1 + " is Even");
                }
                else Console.WriteLine(number1 + " is Odd");
            }       
        }
    }
}

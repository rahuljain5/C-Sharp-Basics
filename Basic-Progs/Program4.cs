using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class Program4
    {
        static void Main()
        {
            Console.WriteLine("Program to extract whole and Fractional value");
            double input = 1234.4567;
            int whole = 0;
            //byte ex = (byte)whole;
            double fractional = 0.0f;

            //Logic to extract Whole and Fractional values
            whole = (int)input;//Explicit Type Casting
            fractional = input - whole;
            Console.WriteLine("whole: {0}, fractional: {1}", whole, fractional);
        }
    }
}

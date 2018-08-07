using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class Factorial
    {
        static void Main()
        {
            int num = 6;
            Console.WriteLine("Factorial is: " + Fact(num));
        }
        static int Fact(int num)
        {
            int result = 1;
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else if (num < 0) Console.WriteLine("Cannot find factorial of Negative number");
            else
            {
                result = num * Fact(num - 1);
            }
            return result;
        }
    }
}

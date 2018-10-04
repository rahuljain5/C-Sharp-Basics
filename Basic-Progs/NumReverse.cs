using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class NumReverse
    {
        static void Main()
        {
            int num = 1234, reverse=0;
            //Console.WriteLine("Enter value of N");
            //num = (int.Parse(Console.ReadLine()));
            while (num != 0)
            {
                reverse = reverse * 10 + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Reverse is :" + reverse);
        }
    }
}

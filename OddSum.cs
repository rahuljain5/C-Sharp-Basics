using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class OddSum
    {
        static void Main()
        {
            int N, sum = 0;
            Console.WriteLine("Enter value of N");
            N = (int.Parse(Console.ReadLine()));
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum is :" + sum);
        }
    }
}

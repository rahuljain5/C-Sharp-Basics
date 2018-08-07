using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class PrimeSum
    {
        static void Main()
        {
            int n = 2, m = 20, sum =0;
            //Console.WriteLine("Prime Series");
            //bool flag = false;
            for (int i = n; i <= m; i++)
            {
                if (IsPrime(i)) sum += i;
            }
            Console.WriteLine("Sum is: " + sum);
        }
        static bool IsPrime(int number)
        {
            bool flag = false;
            for (int j = 2; j < number; j++)
            {
                if (number % j == 0) flag = true;
            }
            if (!flag)
            {
                Console.Write(number + ", ");
                return true;
            }
            else
                return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class Patterns2
    {
        static void Main()
        {
            int num;
            Console.WriteLine("enter N: ");
            num = int.Parse(Console.ReadLine());
            ColPyramid(num);
            RowPyramid(num);
            CounterPyramid(num);
            FiboPyramid(num);
        }
        static void ColPyramid(int Num)
        {
            for (int i = 1; i <= Num; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j+" ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void RowPyramid(int Num)
        {
            for (int i = 1; i <= Num; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(i + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void CounterPyramid(int Num)
        {
            int counter = 1;
            for (int i = 1; i <= Num; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(counter++ + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void FiboPyramid(int Num)
        {
             int fiboterm1 = 0, fiboterm2 = 1, tempRes = 1;
            //Console.WriteLine(tempRes);
            for (int i = 1; i <= Num; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    Console.Write(tempRes + " ");
                    tempRes = fiboterm1 + fiboterm2;
                    fiboterm1 = fiboterm2;
                    fiboterm2 = tempRes;
                }
                    
                Console.WriteLine();
            }
    }
}

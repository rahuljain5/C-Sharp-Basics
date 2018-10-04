using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class Series1
    {
        static void Main()
        {
            int N = 10;
            NumPlusSquares(N);
            Fibonacci(N);
            DualSeries(N);
            Tribonacci(N);
        }
        static void NumPlusSquares(int num)
        {
            int sum = 1;
            for (int i = 0; i<=num; i++)
            {
                sum = sum + i * i;
                if (i % 2 == 0)
                    Console.Write(sum + ", ");
                else Console.Write(-1 * sum + ", ");
            }
            Console.WriteLine("\n");
        }
        static void Fibonacci(int num)
        {
            int fiboterm1 = 0, fiboterm2 = 1, tempRes = 1;
            //Console.WriteLine(tempRes);
            for (int i = 1; i <= num; i++)
            {
                    Console.Write(tempRes + ", ");
                    tempRes = fiboterm1 + fiboterm2;
                    fiboterm1 = fiboterm2;
                    fiboterm2 = tempRes;
             }
            Console.WriteLine("\n");    
            }
        static void DualSeries(int num)
        {
            int counter = 0;
            for(int i=1, j=-2; counter<=num; counter+=2)
            {
                Console.Write(i + ", ");
                Console.Write(j + ", ");
                i += 3; j -= 4;
            }
            Console.WriteLine("\n");
        }
        static void Tribonacci(int num)
        {
            int first = 1, second = 5, third = 8, number;
            Console.Write(first + ", " + second + ", " + third);
            for (int i = 4; i <= num; i++)
            {
                number = first + second + third;
                first = second;
                second = third;
                third = number;
                Console.Write(", " + number);
            }
            Console.WriteLine("\n");
        }
        }
    }

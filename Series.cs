using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class Series
    {
        static void Main()
        {
            int N = 10;
            NumPowers(N);
            NegativePositive(N);
            IndexPower(N);
            Tribonacci(N);
            Squares(N);
            Primes(N);
        }
        static void NumPowers(int n)
        {
            Console.WriteLine(" Power of 2 Series");
            int number = 4;
            for (int i = 1; i<n; i++)
            {
                Console.Write(number + ", ");
                number *= 2;
            }
            Console.WriteLine();
        }
        static void NegativePositive(int n)
        {
            Console.WriteLine("Negative Positive Series");
            for (int i = 1; i < n; i++)
            {
                Console.Write(i * (int)Math.Pow(-1,i-1) + ", ");
            }
            Console.WriteLine();
        }
        static void IndexPower(int n)
        {
            Console.WriteLine("Index Power Series");
            for (int i = 1; i < n; i++)
            {
                Console.Write((Int64)Math.Pow(i, i) + ", "); ;
            }
            Console.WriteLine();
        }
        static void Squares(int n)
        {
            Console.WriteLine("Square Series");
            for (int i = 1; i < n; i++)
            {
                if(i%4 != 0)
                {
                    Console.Write((int)Math.Pow(i, 2) + ", ");
                }
            }
            Console.WriteLine();
        }
        static void Primes(int n)
        {
            int count = 1;
            Console.WriteLine("Prime Series");
            for (int i = 1; count <= n; i++)
            {
                bool flag = false;
                for (int j=2; j<i; j++)
                {
                    if (i % j == 0) flag = true;
                }
                if (!flag)
                {
                    count++;
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();
        }
        static void Tribonacci(int n)
        {
            Console.WriteLine("Tribonacci Series");
            int first = 1, second = 4, third = 7, number;
            Console.Write(first + ", " + second + ", " + third);
            for (int i = 4; i<=n; i++)
            {
                number = first + second + third;
                first = second;
                second = third;
                third = number;
                Console.Write(", " + number);
            }
            Console.WriteLine();
        }
    }
}

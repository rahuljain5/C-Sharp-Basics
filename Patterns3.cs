using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class Patterns3
    {
        //lollipops r the best
        static void Main()
        {
            int num;
            Console.WriteLine("enter N: ");
            num = int.Parse(Console.ReadLine());
            SquaresPyramid(num);
            FactorialPyramid(num);
            StarPyramid(num);
            RightStarPyramid(num);
        }
        static void SquaresPyramid(int num)
        {
            int count = 1;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                    if(count %2 != 0)
                    Console.Write(count*count++ + " ");
                    else Console.Write(-count * count++ + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void FactorialPyramid(int num)
        {
            int fact = 1, count = 1 ;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count * fact + " ");
                    fact = count++ * fact;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void StarPyramid(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <=num-i ; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k<=i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void RightStarPyramid(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = num - i; k < num; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class Pattens
    {
        static void Main()
        {
            int num;
            Console.WriteLine("enter N: ");
            num = int.Parse(Console.ReadLine());
            Stars(num);
            Numbers(num);
            ColNumbers(num);
            StarPyramid(num);
        }
        static void Stars(int Num)
        {
            for (int i=1; i<=Num; i++)
            {
                Console.WriteLine("* * * * *");
            }
            Console.WriteLine();
        }
        static void Numbers(int Num)
        {
            for (int i = 1; i <= Num; i++)
            {
                Console.WriteLine(i + " " + i + " " + i + " " + i + " " +i);
            }
            Console.WriteLine();
        }
        static void ColNumbers(int Num)
        {
            for (int i = 1; i <= Num; i++)
            {
                for(int j=1; j<=5; j++)
                    Console.Write(j + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void StarPyramid(int Num)
        {
            for (int i = 1; i <= Num; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}

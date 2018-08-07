using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class StringReverse
    {
        static void Main()
        {
            string input;
            Console.WriteLine("enter String: ");
            input = Console.ReadLine();
            Console.WriteLine("Reverse is : ");
            for(int i = input.Length-1; i>=0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}

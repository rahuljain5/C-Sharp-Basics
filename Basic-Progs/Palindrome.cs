using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class Palindrome
    {
        static void Main()
        {
            string input, reverse ="";
            Console.WriteLine("enter String: ");
            input = Console.ReadLine();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }
            if(reverse == input)
            {
                Console.WriteLine("String is a plaindrome!");
            }
            else Console.WriteLine("String is not a plaindrome!");
        }
    }
}

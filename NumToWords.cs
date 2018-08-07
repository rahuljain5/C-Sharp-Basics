using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class NumToWords
    {
        static void Main()
        {
            int num = 270176, remainder, reverse=0, temp;
            temp = num;
            string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" }; 
            string inWords = "";
            //Console.WriteLine("Enter value of N");
            //N = (int.Parse(Console.ReadLine()));
            while (temp != 0)
            {
                reverse = reverse * 10 + temp % 10;
                temp = temp / 10;
            }
            while (reverse != 0)
            {
                remainder = reverse % 10;
                inWords = inWords + " " + words[remainder];
                reverse = reverse / 10;
            }
            Console.WriteLine("Reverse is :" + inWords);
        }
    }
}

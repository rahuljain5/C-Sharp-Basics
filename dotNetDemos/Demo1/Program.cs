using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] i = { { 10, 6 }, { 7, 3 } };
            //LINQ Expression
            
            var evens = from int number in i
                        where number % 2 == 0
                        select number;
            foreach(var x in evens)
            {
                Console.WriteLine(x);
            }
            
        }
    }
}

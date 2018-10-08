using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class EvenSum
    {
        //Get Sum of All Even Numbers
        public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 4, 6, 7, 3, 7, 8, 4, 3, 6, 8, 0 };
            
            Console.WriteLine(numbers.Where(i => i % 2 == 0 ).Sum());
        }
    }
}

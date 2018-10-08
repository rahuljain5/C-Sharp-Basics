using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Demo
{
    class UniqueNumber
    {
        public static void Main()
        {
            Random random = new Random();
            HashSet<int> numbers = new HashSet<int>();
            while( numbers.Count<=100 )
            {
                int num = random.Next(100);
                numbers.Add(num);
                //Console.WriteLine(numbers[i]);
            }
        }
    }
}

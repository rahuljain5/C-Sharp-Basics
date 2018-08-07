using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string num = "1001";
            Console.WriteLine("Decimal is: " + Convert.ToInt32(num, 2));
        }
    }
}

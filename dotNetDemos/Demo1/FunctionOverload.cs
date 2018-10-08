using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class FunctionOverload
    {
        public static void Main()
        {
            Sum(5);
            Sum(5, 6);
            print("SomeFile.doc", color: "color"); // can be in any order
            int x = 10;
            //Pass By Reference
            change(ref x);

            //For Multi return Function
            int max, sum, a = 9, b = 5;
            GetMaxAndSum(a, b, out max,out  sum);
            Console.WriteLine("The Max is: {0}, Sum is {1}", max, sum);
        }
        static int Sum(int a, int b = 0, int c = 0, int d = 0)
        {
            return a + b + c + d;
        }
        static void print(string doc, int copies = 1, string color = "gray")
        {

        }
        static void change(ref int a)
        {
            a = 100;
        }
        static void GetMaxAndSum(int a, int b, out int m, out int s)
        {
            m = ((a > b) ? a: b);
            s = a + b;
        }
    }
}

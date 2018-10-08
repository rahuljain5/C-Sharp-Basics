using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLengthSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();
            strings.Add("Hi");
            strings.Add("A");
            strings.Add("Hijhkffj");
            strings.Add("Hidksjkfds");
            strings.Add("Hii");
            
            foreach(var x in strings.OrderBy(str => str.Length))
            {
                Console.WriteLine(x);
            }
        }
    }
}

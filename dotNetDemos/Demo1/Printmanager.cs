using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Printmanager
    {
        public readonly static Printmanager Instance = new Printmanager();
        static public bool Status { get; private set; }
        private Printmanager()
        {

        }
        public void Print(string doc)
        {
            Console.WriteLine("Printing....." + doc);
        }
    }
    class Program2
    {
        public static void Main()
        {
            //Printmanager p1 = Printmanager.CreateInstance();
            Console.WriteLine(Printmanager.Instance.GetHashCode());
            Printmanager.Instance.Print("Invoice.doc");


            //Printmanager p2 = Printmanager.CreateInstance();
            //Console.WriteLine(p2.GetHashCode());
            Printmanager.Instance.Print("Resume.doc");
            //else Console.WriteLine("Printer is Busy");
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleClass ec = new ExampleClass();
            dynamic d = ec.exampleMethod();
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());

            //Console.WriteLine(ec.exampleMethod(10));
            //Console.WriteLine(ec.exampleMethod("value"));


            // The following line causes a compiler error because exampleMethod
            // takes only one argument.
            //Console.WriteLine(ec.exampleMethod(10, 4));

            dynamic dynamic_ec = new ExampleClass();
            Console.WriteLine(dynamic_ec.exampleMethod(10));

            // Because dynamic_ec is dynamic, the following call to exampleMethod
            // with two arguments does not produce an error at compile time.
            // However, itdoes cause a run-time error. 
            //Console.WriteLine(dynamic_ec.exampleMethod(10, 4));
        }
    }
    class ExampleClass
    {
        static dynamic field;
        dynamic prop { get; set; }

        public dynamic exampleMethod()
        {
            List<dynamic> dynamics = new List<dynamic>();
            dynamics.Add("akjska");
            dynamics.Add(6767);
            Random rnd = new Random();
            return dynamics[rnd.Next(2)];

        }
    }
}

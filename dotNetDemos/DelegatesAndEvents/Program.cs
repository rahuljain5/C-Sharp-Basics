using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    //Delegate Declaration
    delegate void MyType(string s);

    class Program
    {
        static void Main(string[] args)
        {
            //Delegates - Function Pointers in C++ (Safe)
            //It holds address of a function
            MyType myType = new MyType(Greet);
            Program p = new Program();
            myType += p.Hi;                 //Subscribe
            myType -= Greet;                //Unsubscribe
            //Invocation
            myType.Invoke("HellO");
            myType("Cool");
            
        }
        static void Greet(string msg)
        {
            Console.WriteLine(msg);
        }
        void Hi(string msg) { Console.WriteLine("Hi, i ignored the parameter, HAAHAHAHAHAHHAS"); }
    }
}

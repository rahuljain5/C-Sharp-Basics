using System;
using IronPython.Hosting;
using IronPython.Runtime;
using IronPython;
using Microsoft.Scripting.Hosting;
using Microsoft.Scripting;
using System.IO;

namespace DynamicTypes
{
    class DynamicObjectExample
    {
        public static void Main()
        {

            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            var ops = engine.Operations;
            string source = new StreamReader("C:\\Users\\Rahul Jain\\Desktop\\Progs\\Example.py").ReadToEnd();
            engine.Execute(source, scope);
            var pythonType = scope.GetVariable("Hello");
            dynamic instance = ops.CreateInstance(pythonType);
            var value = instance.add(10, 20);
            Console.WriteLine(value);

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}

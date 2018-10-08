using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Sequential");
            Stopwatch w = Stopwatch.StartNew();
            //Console.WriteLine("In Main");
            //Method1();
            //Console.WriteLine($"back In Main {Thread.CurrentThread.ManagedThreadId}");
            //Method2(100);
            //Console.WriteLine($"back In Main {Thread.CurrentThread.ManagedThreadId}");
            //Console.WriteLine("Time Elapsed: "+ w.ElapsedMilliseconds);
            //w.Restart();
            Console.WriteLine("In Parallel");
            //ThreadStart threadStart = new ThreadStart(Method1);
            //Thread t1 = new Thread(Method1);
            //t1.Start();
            //Thread t2 = new Thread(Method2);
            //t2.Start();
            Parallel.Invoke(Method1, Method2);
            Console.WriteLine("End of App");
            //t1.Join();
            //t2.Join();
            Console.WriteLine("Time Elapsed: " + w.ElapsedMilliseconds);
            //Console.WriteLine("Cores:"+Environment.ProcessorCount);
            w.Restart();
            Parallel.Invoke(Method11, Method22);
        Console.WriteLine("Time Elapsed: " + w.ElapsedMilliseconds);
        }
        static void Method11()
        {
            Parallel.For(1, 100, i => {  Thread.Sleep(100); });
            //Console.WriteLine($"In method 1 - {Thread.CurrentThread.ManagedThreadId}");
            //Thread.Sleep(5000);
            
        }
        static void Method22()
        {
            Parallel.For(1, 100, (i => Thread.Sleep(100)));
            //Console.WriteLine($"In method 1 - {Thread.CurrentThread.ManagedThreadId}");
            //Thread.Sleep(5000);
            
        }
        static void Method1()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
            }
            //obj = (int)obj;
            //Console.WriteLine($"In method 2 - {Thread.CurrentThread.ManagedThreadId}");
            //Thread.Sleep(5000);
        }static void Method2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
            }
            //obj = (int)obj;
            //Console.WriteLine($"In method 2 - {Thread.CurrentThread.ManagedThreadId}");
            //Thread.Sleep(5000);
        }
    }
}

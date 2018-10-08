using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Example1
    {
        //Introduction to Delegates and Events, Display all Processes by applying filter
        public static void Main()
        {
            Example1 ex = new Example1();
            ProcessMonitor processMonitor = new ProcessMonitor();
            
            // Call Type 1:
            Filter filter = new Filter(ex.FilterByName);
            processMonitor.ShowProcess(filter);

            //Call Type 2:
            processMonitor.ShowProcess(ex.FilterBySize);

            //Alternatively, Call by Anonymous Method / Delegate
            processMonitor.ShowProcess(delegate(Process p) { return (p.WorkingSet64 >= 60 * 1024 * 1024); });

            //Lambda => Simplified Syntax for Anonymous delegates
            //lambda - statements, Expressions
            processMonitor.ShowProcess((Process p) => { return (p.WorkingSet64 >= 60 * 1024 * 1024); }); //Statements - Contains Symbols, Keyword, Operators

            processMonitor.ShowProcess(p => (p.WorkingSet64 >= 60 * 1024 * 1024)); //Expression 



        }

        public bool FilterBySize(Process p)
        {
            return (p.WorkingSet64 >= 10*1024*1024);
        }

        public bool FilterByName(Process p)
        {
            return (p.ProcessName.StartsWith("A"));
        }

    }

    delegate bool Filter(Process P);

    class ProcessMonitor
    {
        public void ShowProcess(Filter filter)
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (filter(p))
                    Console.WriteLine(p.ProcessName);
            }
        }
    }
    
}
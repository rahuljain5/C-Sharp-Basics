using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class StackProb
    {

        public static void Main()
        {
            //DataStore.FillData();
            //DataStore.FillData();

            Parallel.Invoke(DataStore.FillData, DataStore.FillData);
            Console.WriteLine(DataStore.data.Count);
        }
    }
    class DataStore
    {
        public static ConcurrentStack<int> data = new ConcurrentStack<int>();
        //[MethodImpl(MethodImplOptions.Synchronized)]
        public static void FillData()
        {
            
            for (int i = 1; i <= 500000; i++)
            {
                //Monitor.Enter(obj);
                //lock (data)
                //{
                    data.Push(i);
                //} 
                //Monitor.Exit(obj);
                
            }
        }
    }

}

using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class ProducerConsumerProblem
    {
        public static void Main()
        {
            OrderManager om = new OrderManager();
            Parallel.Invoke(om.Writer, om.Reader);
        }
    }
    class OrderManager
    {
        public ConcurrentQueue<int> q = new ConcurrentQueue<int>();
        public void Writer()
        {
            Random random = new Random();
            for (int i = 0; i <= 100; i++)
            {
                q.Enqueue(random.Next());
                lock (q)
                {
                    Monitor.Pulse(q);
                }
                Thread.Sleep(10);
            }
            Console.WriteLine("Writer Done!");
        }
        public void Reader()
        {
            int count = 0;
            int data;
            while (count <= 100)
            {
                Console.WriteLine("Waiting for Queue");
                lock (q)
                {
                    Monitor.Wait(q);
                }
                q.TryDequeue(out data);
                Console.WriteLine(data);
                count++;
               }
            Console.WriteLine("Reader Done!");
        }
    }
}


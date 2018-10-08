using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, Classname> items = new Dictionary<int, Classname>();    
            Stack<int> numbers = new Stack<int>();
    
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            
            foreach(var x in numbers)
            {
                Console.WriteLine(x);
                //temp.Push(numbers.Pop());
            }

            Queue<int> q = new Queue<int>();
            q.Enqueue(100);
            int crap = q.Dequeue();

            LinkedList<int> llist = new LinkedList<int>();
            llist.AddFirst(10);
            llist.AddBefore(llist.Find(10),20);

            HashSet<int> vs = new HashSet<int>();

        }
        static void Sort<T>(T[] numbers)
        {

        }
    }

    //Custom Collection - dynamic Array
    //Generic Types
    class DynamicArray<idontknow> 
    {
        private idontknow[] localArray = new idontknow[4];
        private int index =0;
        public void add(idontknow data)
        {
            if(index == localArray.Length - 1)
            {
                Array.Resize(ref localArray, localArray.Length * 2);
            }
            localArray[index++] = data;
        }
        public idontknow Get(int i)
        {
            return localArray[i];
        }
        public int Length { get { return index; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> set = new SortedDictionary<string, int>();
            
            foreach (var word in args)
            {
                if (set.ContainsKey(word)) set[word]++;
                else set.Add(word, 1);
            }
            
            foreach (var key in set.Keys)
                Console.WriteLine($"{key} : {set[key]}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class LinearSearch
    {
        static void Main()
        {
            int[] array1 = {1, 2, 3, 6, 5, 88, 9};
            int key;
            bool flag = false;
            Console.WriteLine("Enter Key to be found.");
            key = int.Parse(Console.ReadLine());
            for (int i=0; i< array1.Length; i++)
            {
                if (key == array1[i])
                {
                    Console.WriteLine("Key Found at location:" + i);
                    flag = true;
                }
                    
            }
            if(!flag)
            Console.WriteLine("Key not found!");
        }
    }
}

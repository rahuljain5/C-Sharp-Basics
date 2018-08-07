using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class BinarySearch
    {
        static void Main()
        {
            int[] array1 = { 1, 2, 3, 6, 5, 88, 9 };
            int key;
            bool flag = false;
            Console.WriteLine("Enter Key to be found.");
            key = int.Parse(Console.ReadLine());
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j=i;j<array1.Length-1; j++)
                {
                    if(array1[j+1] < array1[j])
                    {
                        array1[j+1] = (array1[j] + array1[j+1]);
                        array1[j] = (array1[j+1] - array1[j]);
                        array1[j+1] = (array1[j+1] - array1[j]);
                    }
                }
            }
            int low = 0, high = array1.Length, mid = 0;
            while (!flag && low<=high)
            {
                mid = (low + high) / 2;
                if (array1[mid] == key) flag = true;
                else if (array1[mid] > key) high = mid - 1;
                else low = mid + 1;
            }
            if (flag) Console.WriteLine("Key Found at: " + mid);
                else Console.WriteLine("Key not found!");
        }
    }
}

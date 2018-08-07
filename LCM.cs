using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class LCM
    {
        static void Main()
        {
            int[] array1 = new int[5];
            array1[0] = 2;
            array1[1] = 3;
            array1[2] = 4;
            array1[3] = 5;
            array1[4] = 6;
            DisplayArray(array1);
            Console.WriteLine(GetLcm(array1));
        }
        static int GetLcm(int[] arr)
        {
            bool flag = false;
            int offset = 0, num = 0;
            for(int i = 1; i< arr.Length; i++)
            {
                if (arr[i] > offset) offset = arr[i];
            }
            while (!flag)
            {
                num = num + offset;
                flag = true;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (num % arr[i] != 0) flag = false;
                }
                if(flag)
                {
                    Console.WriteLine(num);
                    return num;
                }
            }
            return -1;
        }
        static void DisplayArray(int[] arr)
        {
            for(int i = 0; i< arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "\t");
            }
        }
    }
}
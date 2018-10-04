using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class SymmetricMatrix
    {
        static void Main()
        {
            int[,] matrix = { { 2, 3, 4 }, { 3, 5, 6 }, { 4, 6, 8 } };
            bool flag = true;
            Console.WriteLine("The Matrix is:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] != matrix[j, i]) flag = false;
            }
            if (flag) Console.WriteLine("Symmetric Matrix");
            else Console.WriteLine("ASymmetric Matrix");
        }
    }
}

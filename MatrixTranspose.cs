using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class MatrixTranspose
    {
        static void Main()
        {
            int[,] matrix = { { 2, 3, 4 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("The Matrix is:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i,j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine("The Transposed Matrix is:");
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[j, i] + " ");
                Console.WriteLine();
            }
        }
    }
}

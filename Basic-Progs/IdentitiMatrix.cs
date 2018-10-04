using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class IdentitiMatrix
    {
        static void Main()
        {
            int[,] matrix = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            bool flag = true;
            Console.WriteLine("The Matrix is:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
            if(matrix.GetLength(0) == matrix.GetLength(1))
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        if(i == j)
                        {
                            if (matrix[i, j] != 1) flag = false;
                        }
                    else
                            if(matrix[i, j] != 0) flag = false;
                    
                }
                if (flag)
                    Console.WriteLine("Matrix is an Identity matrix!");
                else Console.WriteLine("Matrix is not an Identity matrix!");
            }
            
        }
    }
}

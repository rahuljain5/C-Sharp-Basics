using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {

            int COLS = 500, ROWS = 500;
            int[,] matrix1 = new int[ROWS, COLS];
            int[,] matrix2 = new int[ROWS, COLS];
            Init(matrix1, matrix2);

            Console.WriteLine("Sequential: ");
            MatrixMultiplication(matrix1, matrix2);
            MatrixAddition(matrix1, matrix2);

            Console.WriteLine("Using Parallel: ");

            Parallel.Invoke(() => { MatrixMultiplication(matrix1, matrix2); }, () => { MatrixAddition(matrix1, matrix2); });

            //Does not return a value
            Task task = Task.Factory.StartNew(() => { MatrixMultiplication(matrix1, matrix2); });
            task.Wait();
            //task.Start();

            //Task 
            ////Task task = new Task(method);
            ////task.Start()

            //If a Method returns a value
            //Task<Type> t4 = Task.Factory.StartNew(() => { return Sum(10, 20) });
            //t4.Result;

        }
        static void Init(int[,] matrix1, int[,] matrix2)
        {
            Random random = new Random();
              
            Parallel.For(0, matrix1.GetLength(0) - 1, new ParallelOptions { MaxDegreeOfParallelism = 3 }, i =>
              {
                  //for (int j = 0; j < matrix1.GetLength(0) - 1; j++)
                  //{
                  Parallel.For(0, matrix1.GetLength(1) - 1, j =>
                  {
                      matrix1[i, j] = random.Next(50);
                      matrix2[i, j] = random.Next(50);

                  });
                  //}
              });

        }
        static void MatrixMultiplication(int[,] matrix1, int[,] matrix2)
        {

            int[,] resmatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            Stopwatch w = new Stopwatch();
            w.Start();
            Parallel.For(0, matrix1.GetLength(0), i =>
            {
                for (int j = 0; j < matrix1.GetLength(0); j++)
                {
                    for (int k = 0; k < matrix1.GetLength(0) - 1; k++)
                    {
                        resmatrix[i, j] += matrix1[i, k] * matrix1[k, j];
                    }
                }
            });
            Console.WriteLine("For Multiplication: " + w.ElapsedMilliseconds);
        }
        static void MatrixAddition(int[,] matrix1, int[,] matrix2)
        {
            Stopwatch w = new Stopwatch();
            w.Start();
            int[,] resmatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            Parallel.For(0, matrix2.GetLength(0) - 1, i =>
            {
                for (int j = 0; j < matrix1.GetLength(1) - 1; j++)
                {
                    resmatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
                //Parallel.For(0, matrix2.GetLength(0) - 1, j =>
                //{

                //});
            });
            //Console.WriteLine(resmatrix[2,2]);
            Console.WriteLine("For Addition: " + w.ElapsedMilliseconds);
        }
    }
}

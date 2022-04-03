using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_19_Thread_Varian_6
{
    class Program
    {
        static int N = 0; // Размерность матриц nxn

        // array 
        static int[,] Aarray;
        static int[,] Barray;

        // end array 
        // static int[,] Carray = new int[N, N];

        public static void Main()
        {
            // read array
            Console.Write("Write size N: ");
            // N = Convert.ToInt32(Console.ReadLine());
            N = 3;

            // initialization arrays
            Aarray = new int[,] { {3, -1, 2}, {2, 3, 0}, {2, 4, 6} };
            Barray = new int[,] { {5, 3, 2}, {-5, 6, 0}, {2, 5, 9} };


            // print array 
            Console.WriteLine("Array A:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine($"Aarray[{i}][{j}]: {Aarray[i,j]}");
                }
            }

            Console.WriteLine("Array B:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine($"Barray[{i}][{j}]: {Barray[i, j]}");
                }
            }

            // Массив потоков; На каждую строку свой поток
            Thread[] threads = new Thread[N];

            // Передача индекса и массивов в функцию в потоке
            for (int i = 0; i < N; i++)
            {
                threads[i] = new Thread(Return_C);
                threads[i].Start();
            }

            // Thread 
            //Thread th1 = new Thread(return_C);
            //Thread th2 = new Thread(return_C);
            //Thread th3 = new Thread(return_C);

            //th1.Start();
            //th2.Start();
            //th3.Start();


            // Создать n потоков и в них вычислять по строки

            // если NxN тогда возможно передть матрицу

        }

        static void Return_C(object o) // Принимаю элементы матрицы A и B
        {
            // accumulate & print
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    // Carray[i, j] = Aarray[i, j] + Barray[i, j];
                    Console.Write(Aarray[i, j] + Barray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Work comlete!!!");
        }
    }
}
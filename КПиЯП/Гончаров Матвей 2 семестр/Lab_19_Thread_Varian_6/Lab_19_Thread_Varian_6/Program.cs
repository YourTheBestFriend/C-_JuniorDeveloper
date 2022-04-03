using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_19_Thread_Varian_6
{
    class Program
    {
        protected static readonly object MyLock = new object();
        static int N = 0; // Размерность матриц nxn

        // array 
        static int[,] Aarray;
        static int[,] Barray;

        // end array 
        static int[,] Carray;

        public static void Main()
        {
            // read array
            //Console.Write("Write size N: ");
            // N = Convert.ToInt32(Console.ReadLine());
            N = 3;
            // C array size 
            Carray = new int[N, N];

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

            Console.WriteLine("\nArray B:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine($"Barray[{i}][{j}]: {Barray[i, j]}");
                }
            }
            Console.WriteLine();
            // Массив потоков; На каждую строку свой поток
            Thread[] threads = new Thread[N];

            // Передача индекса и массивов в функцию в потоке
            for (int i = 0; i < N; i++)
            {
                // передаю номер потока и он будет соответсвовать номеру строки
                threads[i] = new Thread(new ParameterizedThreadStart(Return_C));
                threads[i].Start(i); // сам параметн
            }

            /* Для себя
            // Create Thread вручную
            //Thread th1 = new Thread(return_C);
            //Thread th2 = new Thread(return_C);
            //Thread th3 = new Thread(return_C);

            //th1.Start();
            //th2.Start();
            //th3.Start();


            // Создать n потоков и в них вычислять по строки

            // если NxN тогда возможно передть матрицу
            */
        }

        static void Return_C(object string_index_J) // Принимаю элементы матрицы A и B
        {
            // lock (MyLock) { } // Если залочить то тогда поток посчитает всю строку и потом другой другую, в общем последовательно
            // accumulate & print
            for (int i = 0; i < Carray.GetLength(0); i++)
            {
                Thread.Sleep(3000);
                // Определеный поток считает совю строку
                Carray[i, (int)string_index_J] = Aarray[i, (int)string_index_J] + Barray[i, (int)string_index_J]; // Считаю элемент
                Console.WriteLine($"C[{i + 1}][{(int)string_index_J + 1}] = {Carray[i, (int)string_index_J]}");
            }
            Console.WriteLine($"Work comlete for string number {(int)string_index_J + 1}");
        }
    }
}
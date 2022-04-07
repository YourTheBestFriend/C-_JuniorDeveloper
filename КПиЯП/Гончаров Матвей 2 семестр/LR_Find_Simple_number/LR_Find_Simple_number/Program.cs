using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_Find_Simple_number
{
    class Program
    {
        protected static readonly object MyLock = new object();
        static int N = 100; // Первые 100 простых чисел
        static int size = 3; // Кол-во потоков
        static int countFindInThred = 0;
        static int[] array = new int[N];

        // Проверка числа на простое
        static bool Simple_or_not(decimal x)
        {
            for (decimal i = 2; i <= (decimal)Math.Sqrt((double)x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // find for range threads
        static void Find_for_range_threads(object index_thread)
        {
            lock (MyLock)
            {
                Thread.Sleep(3000);
                int index = (int)index_thread + 1; // Какой по счету
                decimal N_range = N / size; // Length each of range

                // Range
                decimal start = (decimal)(N_range * (int)index), end = (decimal)(N_range * ((int)index + 1));

                for (decimal i = start; i < end; i++)
                {
                    if (Simple_or_not(i))
                    {
                        Console.WriteLine($"thread[{index_thread}] = {i}");
                    }
                }
            }
        }

        // Последовательное решение
        static int[] Get_Simple_number_of_N(int[] array, int N)
        {
            for (int i = 2, index = 0; index != N; i++)
            {
                if (Simple_or_not(i))
                {
                    array[index] = i;
                    index++;
                }
            }
            return array;
        }

        // Параллельное решение
        static void Get_Simple_number_of_N_VIA_Threads(int size) // size - кол-во потоков и кол-во секций (как в первом варианте декомпозиция по данным)
        {
            Thread[] threads = new Thread[size];

            for (int i = 0; i < size; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(Find_for_range_threads));
                threads[i].Start(i);
            }
        }

        public static void Main()
        {
            array = Get_Simple_number_of_N(array, N);

            // print array
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            // В общем работает, правда получается что находит не N кол-во простых, а из тех диапазонов
            Get_Simple_number_of_N_VIA_Threads(size); // 3 - потока и 3 диапазона
        }
    }
}
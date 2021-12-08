using System;
using static System.Math;

namespace Исключения
{
    class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.WriteLine("Task 1");
            
            // Диагонали
            double d1 = 5, d2 = 4, x, S;

            // S = d1 * d2 * sin(x)
            Console.Write("Input x (в радианах): ");
            x = Convert.ToDouble(Console.ReadLine());
            try
            {
                x = x * 180.0 / PI; // Вычисляю градусы
                if (x > 90)  // т.к 1.5 - 90 градусов а значит уже прямаугольник 
                {
                    throw new Exception("Вы впревысили границу");
                }
                S = d1 * d2 * x;
                Console.WriteLine($"S = {S}, x = {x}");
            }
            catch (Exception ex2)
            {
                Console.WriteLine($"Искллючение {ex2.Message}");
            }
            // finally - в любом случае выполнится 
            finally
            {
                Console.WriteLine("Программа попала в finally");
            }

            // task 2
            Console.WriteLine("\nTask 2");

            int[,] array = new int[3, 3] { {5,2,3}, {3,5,3}, {9,3,7} };
            int index_max_stroki = 0;
            int max_elem = 0;
            try
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i,j] % 2 == 0)
                        {
                            throw new Exception($"Элемент в массиве не может быть четным - index i = {i}, index j = {j} element {array[i,j]}");
                        }
                    } 
                }
                int i_ = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    max_elem += array[i_, j];
                }
                int reserve = 0;
                for (int i = 1; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        reserve += array[i, j];     
                    }
                    if (max_elem < reserve)
                    {
                        max_elem = reserve;
                        index_max_stroki = i;
                    }
                    reserve = 0;
                }
            }
            catch (Exception ex2)
            {
                Console.WriteLine($"Искллючение {ex2.Message}");
            }
            
            // task 3
            Console.WriteLine("\nTask 3");




        }
    }
}

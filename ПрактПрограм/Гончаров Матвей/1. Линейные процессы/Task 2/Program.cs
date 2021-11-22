using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 2
            // V = S*h - объема прямой призмы (S - основания призмы)
            Console.WriteLine("Введите сторону a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту h");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("V = " + (a*b/2)*h); // (a * b / 2) - Площадь основания в даном случает основание это треугольник 
            Console.ReadLine();
        }
    }
}

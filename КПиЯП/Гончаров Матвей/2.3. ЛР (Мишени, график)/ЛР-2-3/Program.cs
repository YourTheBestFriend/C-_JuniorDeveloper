using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_2_3
{
    class Program
    {
        static double Task1_1(double x, double r)
        {
            double raznica = r - 3;
            if (x < -5 - raznica)
            {
                return -3;
            }
            if (x >= -5- raznica && x < -3 - raznica)
            {
                return x - (-3 - raznica);
            }
            if (-r <= x && x <= r)
            {
                return Sqrt(Pow(r, 2) - Pow(x, 2));
            }
            if (x > 3 + raznica && x < 8 + raznica)
            {
                return r / 5 * (x - r); // r / 5 - угол наклона k
            }
            if (x >= 8 + raznica)
            {
                return 3 + raznica;
            }
            return 0;
        }
 
        //    // y = 3 - radius;
        //    //Если окружность с центром в начале координат - y = Sqrt(Pow(r, 2) - Pow(x + a, 2)) + b - для верхней полуокружности(или с минусом перед корнем для нижней)
        //    if (Sqrt(Pow(-3 - r, 2) + Pow(3 + r, 2)) <= (r + 3) * (r + 3)) // + 3 т.к в r уже не полный радиус а разница 
        //    {
        //        return Sqrt(Pow((r + 3), 2) - Pow(x - r, 2)) + r;
        //    }
 

        // Task 1.2
        
        static void Task1_2(double x, double y, double r)
        {
            if (x >= 0 && y >= 0 && Pow(x - r, 2) + Pow(y, 2) <= r * r) // y minus 0
            {
                Console.WriteLine("Входит в серую область I четверти");
            }
            else if (Abs(x) <= r && Abs(y) <= r && x <= 0 && y <= 0 && (Pow(x - r, 2) + Pow(y - r, 2)) > r*r)  // (x < 0) and (y > 0) and ((x+r)*(x+r) + (y+r)*(y+r) < r*r) and (x < -r) and (y < r)
            { 
                Console.WriteLine("Входит в серую область III четверти");
            }
            else
            {
                Console.WriteLine("Не входит");
            }
        }

        static double Task1_3(double x, double eps, ref int i_count)
        {
            double y = 0;
            double r = 0;
            i_count = 1;
            do
            {
                r = Pow(x, i_count) / (i_count++);
                y -= r;
            } while (Abs(r) > eps);
            return y;
        }

        static void Main(string[] args)
        {
            // 1
            double r = 9;
            double raznica = r - 3;
            Console.WriteLine("\tШапка\n===================\n  X\t\t Y\n");
            for (double x = -8 - r; x <= 10 + r; x += .5)
                Console.WriteLine($"{x,6:f1}\t{Task1_1(x, r),10}");

            // 2
            Console.WriteLine("\n");
            double x2, y2, r2 = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Введите x:");
                x2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y:");
                y2 = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Введите r:");
                //r2 = Convert.ToDouble(Console.ReadLine());
                Task1_2(x2, y2, r2);
            }

            // 3
            Console.WriteLine("\n");
            double eps, dx;
            int i_count = 1;
            Console.WriteLine("Введите eps:");
            eps = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите dx:");
            dx = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"i\ty\tln(x-1)\t\tЧлен ряда");
            
            for (double i = -1; i < 1; i += dx)
            {
                Console.WriteLine($"{i,6:f1}\t{Task1_3(i, eps, ref i_count),3:f5}\t{Log(Abs(i - 1)),3:f5}" + "\t\t" + i_count);
            }
        }
    }
}

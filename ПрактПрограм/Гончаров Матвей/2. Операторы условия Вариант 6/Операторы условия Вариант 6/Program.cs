using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Операторы_условия_Вариант_6
{
    class Program
    {
        static double First(double x, double y)
        {
            double d;
            if (x > y)
            {
                d = Pow((x - y), 3) + Atan(x);
            }
            else if (x < y)
            {
                d = Pow((x - y), 3) + Atan(y);
            }
            else
            {
                d = Pow((x + y), 3) + 0.5;
            }
            return d;

            //double d;
            if (x > y)
            {
                return Pow((x - y), 3) + Atan(x);
            }
            if (x < y)
            {
                return Pow((x - y), 3) + Atan(y);
            }
            return   Pow((x + y), 3) + 0.5;
           // }
          //  return d;
        }
        static double Second(double x, double y, double z)
        {
            return Abs(Min(x, y) - Max(y, z)) / 2.0;
        }
        static bool Third(double x, double y)
        {
            return ((Pow(x, 2) + Pow(y, 2) >= 0.5*0.5 && (Pow(x, 2) + Pow(y, 2) <= 1*1) ?true:false));
        }
        static double Fourth(double r)
        {
            double y = 0;
            // y = k*r + b
            if (r <= -2)
            {
                y = Abs(r) - 1;
            }
            else if (r >= 2)
            {
                y = r - 1;
            }
            else if (r >= -2 && r <= -1)
            {
                y = -1 * r - 1;
            }
            else if (r >= -1 && r <= 0)
            {
                y = r + 1;
            }
            else if (r >= 0 && r <= 1)
            {
                y =  -1 * r + 1;
            }
            else if (r >= 1 && r <= 2)
            {
                y = -1 * r + 2;
            }
           
            return y;
        }
        static double Sixth(double i)
        {
            double S;
            switch (i)
            {
                case 3:
                case 4:
                case 5:
                case 6:
                    S = Sqrt(i);
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                    S = Pow(i, 2);
                    break;
                default:
                    S = 0;
                    break;
            }
            return S;
        }

        static void Main(string[] args)
        {

            for (double x = -2; x <= 2; x += .5)
                Console.WriteLine($"{x,6:f1}\t{Fourth(x),10}");

            Console.WriteLine("First = " + First(12.4, 12.3));
            Console.WriteLine("Second = " + Second(1.2, 2.3, 1.4));
            Console.WriteLine("Third = " + Third(1.5, 1.3));
            Console.WriteLine("Fourth = " + Fourth(4) + '\n');
            double x1 = 0, x2 = 0, a = 1, b = 6, c = 10;
            if (a != 0)
            {
                double D = Pow(b, 2) - 4 * a * c;
                Console.WriteLine($"D = {D}");
                if (D > 0) // a = 3, b = 7, c = -6;
                {
                    x1 = (-b + Sqrt(D)) / (2.0 * a);
                    x2 = (-b - Sqrt(D)) / (2.0 * a);
                    if (x1 > x2)
                    {
                        double j = x1;
                        x1 = x2;
                        x2 = j;
                    }
                    double help_X = x1 - 1; // Число для определения + или - на графике 
                    if (a * Pow(help_X, 2) + b * help_X + c >= 0)
                    {
                        Console.WriteLine($"Fifth x(-inf, {x1}] U [{x2}, inf) ");

                    }
                    else
                    {
                        Console.WriteLine($"Fifth x[{x1}, {x2}] ");
                    }
                }
                else if (D == 0) // a = 4, b = 4, c = 1;
                {
                    double help_X = x1 - 1; // Число для определения + или - на графике 
                    x1 = -b / (2.0 * a);
                    if (a * Pow(help_X, 2) + b * help_X + c >= 0)
                    {
                        Console.WriteLine($"Fifth x[{x1}, inf) ");
                    }
                    else
                    {
                        Console.WriteLine($"Fifth x(-inf, {x1}] ");
                    }
                    Console.WriteLine($"Fifth x[{x1}] ");
                }
                else // D < 0 // 2 0 1
                {
                    Console.WriteLine("Fifth x = R, D < 0");
                }
            }
            else
            {
                Console.WriteLine("a != 0");
            }
            Console.WriteLine("\nSixth = " + Sixth(5));
            Console.ReadLine();
        }
    }
}

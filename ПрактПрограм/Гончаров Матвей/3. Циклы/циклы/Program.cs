using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace циклы
{
    class Program
    {
        static double Faktorial(double x)
        {
            if (x == 0 || x == 1)
            {
                return 1;
            }
            return x * Faktorial(x - 1);
        }

        //static double Req(double n)
        //{
        //    if (n == 0)
        //    {
        //        return Sqrt(n);
        //    }
        //    n -= 1;
        //    return Sqrt(n + Req(n));
        //}

        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("\nTask 1");
            Console.WriteLine("Введите n: ");
            double n = Convert.ToInt32(Console.ReadLine());
            double proizv = 1;
            double flag = 1;
            do
            {
                if (flag % 2 == 0)
                {
                    proizv *= flag;
                    n--;
                }
                flag++;
            } while (n != 0);
            Console.WriteLine($"proizv = {proizv}");
            //2
                Console.WriteLine("\nTask 2");
            Console.WriteLine("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите h: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\ty");
            while (a <= b)
            {
                Console.WriteLine(Tan(a) / (a + 1));
                a += h;
            }
            //3
            Console.WriteLine("\nTask 3");
            Console.WriteLine("Введите n: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y_sum = 0;
            for (int i = 0; i < n2; i++)
            {
                y_sum += Pow(x, 2 * i + 1) / Faktorial((2 * i + 1));
            }
            Console.WriteLine("y_sum = " + y_sum + "\n sin = " + Sinh(x));

            //4
            Console.WriteLine("\nTask 4");
            double s;
            Console.WriteLine("Введите a: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            if (a2 >= 0)
            {
                s = 1;
                for (int i = 3; i <= 21; i++)
                {
                    s += Pow(i, 3) + 1;
                }
            }
            else
            {
                s = 0;
                for (int i = 2; i <= 16; i++)
                {
                    s += 1 / i;
                }
            }
            Console.WriteLine($"s = {s}");
            //5
            Console.WriteLine("\nTask 5");
            double Y = 0;
            Console.WriteLine("Введите N: ");
            double N = Convert.ToInt32(Console.ReadLine());
            //Y = Sqrt(2 + Sqrt(1));
            double N_help = Sqrt(1);
            for (double i = 2; i < N; i++)
            {
                Y = Sqrt(i + N_help);
                N_help = Y;
            }
            N_help += N;
            Console.WriteLine($"Y ======= {N_help}");

            Console.WriteLine(new string('_', 55));
            // 6
            Console.WriteLine("\nTask 6");
            double groshi = 100000;
            double procent = 10;
            int counter = 0;
            for (double i = 100000; i < 200000; i += (i * 0.1), counter++) ;
            Console.WriteLine($"Понадобиться столько лет/года {counter}");
        }
    }
}

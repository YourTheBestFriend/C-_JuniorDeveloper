using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("task 2");
            Console.WriteLine("Ввод x в метрах: ");
            double x = Convert.ToInt32(Console.ReadLine());
            x = x / 2.54 * 100;
            Console.WriteLine("В цалях (Дюймах): " + x);
            Console.ReadLine();
            // 2
            Console.WriteLine("task 3");
            int x2, y2;
            Console.WriteLine("Ввод x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввод y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            if (y2 > 0)
            {
                double a = Sqrt(Pow(Sin(Pow(y2, 3)), 2)) - (Log(Pow(y2, -Sqrt(Abs(x2))))) / (Sqrt(Abs(5 - 0.3 * x2)));
                Console.WriteLine("a = " + a);
                Console.ReadLine();
            }
            // 3
            Console.WriteLine("task 4");
            double X1, Y1, X2, Y2;
            Console.WriteLine("Ввод X1: ");
            X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввод Y1: ");
            Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввод X2: ");
            X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввод Y2: ");
            Y2 = Convert.ToInt32(Console.ReadLine());
            double P = (Abs(Y2 - Y1) + Abs(X1 - X2)) * 2;
            Console.WriteLine("P = " + P);
            Console.ReadLine();
            // 4
            Console.WriteLine("task 5");

            double yy1, xx3;
            Console.WriteLine("Ввод yy1: ");
            yy1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввод xx3: ");
            xx3 = Convert.ToInt32(Console.ReadLine());


















































































            double V = 1 / 3.0 * PI * Pow(xx3, 2) * yy1;
            Console.WriteLine("V = " + V);
            Console.WriteLine();

        } 
    }
}

using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вариант11
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1.25;
            double a = -2.14;
            double F = (Pow(Exp(x), a) + 2.73*(Pow(a, 3) * Pow(x, 1/3.0) + 1.78*Pow(Abs(x), 1.4))) / (Abs(x + a) + Tan((PI/2)*a));
            string result = String.Format("{0:e2}", F);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

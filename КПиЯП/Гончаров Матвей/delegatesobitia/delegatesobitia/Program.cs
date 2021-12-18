using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesobitia
{
    class Program
    {

        delegate void DelegateFirst(double start, double end, double step);
        static void Main(string[] args)
        {
            // 1
            DelegateFirst dg1;
            dg1 = PrintFunk;
            dg1(-1, 1, 0.2);

        }
        public static void PrintFunk(double start, double end, double step)
        {
            // Task 1
            Console.WriteLine("Task 1");
            for (double i = start; i <= end; i += step)
            {
                Console.WriteLine($"Asin({i}) = {Asin(i)} | Atan({i}) = {Atan(i)}");
            }
            Console.WriteLine();
        }
    }
}

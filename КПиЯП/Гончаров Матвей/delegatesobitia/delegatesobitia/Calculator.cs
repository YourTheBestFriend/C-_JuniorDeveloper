using System;
using System.Collections.Generic;
using System.Text;

namespace delegatesobitia
{
    class Calculator
    {
        public double Summ (double x, double y) => x + y; 
        public double Substraction(double x, double y) => x - y;
        public double Multiplication(double x, double y) => x * y;
        public double Division(double x, double y) => y == 0 ? throw new DivideByZeroException() : x / y;
        public double Degree(double x, double y) => Math.Pow(x, y);
        public double Square(double x) => Math.Sqrt(x);
    }
}

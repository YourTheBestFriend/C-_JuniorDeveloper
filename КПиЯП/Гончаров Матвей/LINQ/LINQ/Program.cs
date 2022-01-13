using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            В одномерном массиве, состоящем из п вещественных элементов, вычислить: минимальный элемент массива; 
            сумму элементов массива, расположенных между первым и последним поло¬жительными элементами. 
            Преобразовать массив таким образом, чтобы сначала располагались все элементы, равные нулю, а потом — все остальные.
             */

            const int n = 7;
            double[] array = new double[n] { 1.4, 2.3, -5.4, 1.6, 1.6, -1.4, 1.5};

            double min = (from t in array select t).Min();
            Console.WriteLine($"min = {min}");

            double sum = (from t in array where select t).Min();
            Console.WriteLine($"sum = {sum}");


            //var x_array = from t in array
            //              Min d;
        }
    }
}

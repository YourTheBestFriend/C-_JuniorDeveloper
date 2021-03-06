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

            const int n = 12;
            double[] array = new double[n] { -1.4, -2.3, -5.4, -0, -1.6, -0, 2, -10, 3, -1.5, 0.5, -1.5 };

            double min = (from t in array select t).Min();
            Console.WriteLine($"min = {min}");

            double first_p = (from t in array where t > 0 select t).First();
            double last_p = (from t in array where t > 0 select t).Last();


            //double sum = (from t in array where (first_p, last_p) select t).Sum();
            int index_first_p = 0;
            int index_last_p = 0;
            int i = 0;
            foreach (var item in array)
            {
                if (first_p == item)
                {
                    index_first_p = i;
                }
                if (last_p == item)
                {
                    index_last_p = i;
                    break;
                }
                i++;
            }
            Console.WriteLine(index_first_p);
            Console.WriteLine(index_last_p);
            double sum = (from t in array select t).Skip(index_first_p + 1).Take(index_last_p - index_first_p  - 1).Sum();
            Console.WriteLine($"sum = {sum}");
            
            var zeroArrFirst = array.Where(item => Math.Abs(item) < float.Epsilon).Concat(array.Where(item => item != 0));

            foreach (var item in zeroArrFirst)
            {
                Console.WriteLine(item);
            }
        }
    }
}

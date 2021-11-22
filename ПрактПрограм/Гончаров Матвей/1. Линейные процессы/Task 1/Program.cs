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
            // Для всех
            // Task 0
            if (false)
            {
                Console.WriteLine("Введите a: ");
                double a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Хотите ввести в градусах? - Yes");
                if (Convert.ToString(Console.ReadLine()) == "Yes")
                {
                    a = a / 180 * PI; // Это из радина в градусы (а из градусов в радианы (a * 180) / PI)
                }
                double z1 = 2 * Pow(Sin(3 * PI - 2 * a), 2) * Pow(Cos(5 * PI + 2 * a), 2);
                double z2 = 1 / 4.0 - 1 / 4.0 * Sin(5 / 2.0 * PI - 8 * a);
                Console.WriteLine(z1 + "\n" + z2);
                Console.ReadLine();
            }
            else
            {
                // Task 1
                Console.WriteLine("Введите a: ");
                double a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Хотите ввести в градусах? - Yes");
                if (Convert.ToString(Console.ReadLine()) == "Yes")
                {
                    a = a / 180 * PI; // Это из радина в градусы (а из градусов в радианы (a * 180) / PI)
                }
                double z1 = Pow(Cos(3 / 8.0 * PI - a / 4.0), 2) - Pow(Cos(11 / 8.0 * PI + a / 4.0), 2);
                double z2 = Sqrt(2) / 2.0 * Sin(a / 2.0);
                Console.WriteLine(z1 + "\n" + z2);
                Console.ReadLine();
            }
        }
    }
}

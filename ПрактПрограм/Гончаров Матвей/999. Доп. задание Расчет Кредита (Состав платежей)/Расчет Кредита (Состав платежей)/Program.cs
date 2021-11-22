using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Расчет_Кредита__Состав_платежей_
{
    class Program
    {
        static decimal Kredit(byte x, ref decimal p)
        {
            decimal S; // Сумма займа
            double P; // Процентная ставка
            int N; // Срок кредитования (в месяцах)
            Console.WriteLine("Введите сумму займа S: ");
            S = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите процентную ставку P: ");
            P = Convert.ToDouble(Console.ReadLine());
            P = P / P / 100;
            Console.WriteLine("Введите срок кредитования N в месяцах: ");
            N = Convert.ToInt32(Console.ReadLine());
            switch (x) // Тут без break - case не работают в C++ можно break не ставить
            {
                case 0:
                    // аннуитетным
                    // Определяется размер ежемесячного платежа (x) по следующей формуле
                    decimal v = Abs(S * (decimal)(P + (P / (Pow(1 + P, N) - 1))));
                    return v;
                case 1:
                    // дифференцированным
                    decimal B = (decimal)(S / N);
                    p = (S * (decimal)(P));
                    return B;
                default:
                    Console.WriteLine("Вы ничего не выбрали Error");
                    break;
            }
            return -12; // Error null
        }
        static void Main()
        {
            decimal p = 0;
            Console.WriteLine("проценты по кредиту 0 - аннуитетным / 1 - дифференцированным графиком");
            Console.WriteLine("Всего Ответ = " + Kredit(Convert.ToByte(Console.ReadLine()), ref p));

            if (p != 0)
            {
                Console.WriteLine("проценты p = " + p + " %");
            }
            Console.WriteLine("Кликните для завершения программы");
            Console.ReadLine();
        }
    }
}

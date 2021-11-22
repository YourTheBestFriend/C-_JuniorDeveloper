using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metods
{
    class Program
    {
        static void Min_way_points(int[] array_X, int[] array_Y)
        {
            // Пусть начальная точка будет первой
            int first_point_X = array_X[0];
            int first_point_Y = array_Y[0];

            // номер точки которая ближе
            int number_second = 1;
            
            //Вычислиени мин расстояния между первой и второй точкой
            double min_rasstoyanie = Sqrt(Pow((first_point_X - array_X[1]),2) + Pow((first_point_Y - array_Y[1]),2));
            // i = 2 т.к я узяю вверху первый и второй элемент и по ним не надо проходиться
            for (int i = 2; i < array_X.Length; i++)
            {
                double help_first_and_sled_znach = (double)Sqrt(Pow((first_point_X - array_X[i]), 2) + (double)Pow((first_point_Y - array_Y[i]), 2));
                if ((help_first_and_sled_znach) < min_rasstoyanie)
                {
                    min_rasstoyanie = help_first_and_sled_znach;
                    number_second = i;
                }
            }
            Console.WriteLine($"Min расстояние = {min_rasstoyanie}, между 0 и {number_second} точкой");
        }

        // 2
        static bool max_ball_in_two_groups(int[,] A, int[,] B)
        {
            // Первые
            double sredn_A = 0;
            double sredn_B = 0;

            // Для вычисления первых средних баллов в A and B
            for (int j = 0; j < A.GetLength(1); j++)
            {
                sredn_A += A[0,j];
                sredn_B += B[0,j];
            }
            // делю на 4 т.к 4 экзамена
            sredn_A /= 4.0;
            sredn_B /= 4.0;

            // new two sredn
            double second_sredn_A = 0;
            double second_sredn_B = 0;
            // Для подсчета новых баллов и сравнения
            for (int i = 1; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    second_sredn_A += A[i,j];
                    second_sredn_B += B[i,j];
                }
                second_sredn_A /= 4.0;
                second_sredn_B /= 4.0;
                if (second_sredn_A > sredn_A)
                {
                    sredn_A = second_sredn_A;
                }
                if (second_sredn_B > sredn_B)
                {
                    sredn_B = second_sredn_B;
                }
            }
            Console.WriteLine($"\nДля проверки данных это из функции и поэтому вывелось раньше\nsredn_A: {sredn_A}\nsredn_B: {sredn_B}");
            if (sredn_A > sredn_B)
            {
                return true;
            }
            return false;
        }

        // 3 
        static bool scarach_drob(int a, int b)
        {
            double a_b = (double)a / b;
            double help_ = a_b - (int)a_b; // 4,2324 - 4
            double pogreshnost = 0.0001;
            if (help_ >= pogreshnost)
            { 
                return false;
            }
            return true;
        }

        // 4

        // factorial 
        static double factorial(int f)
        {
            if (f <= 1)
            {
                return 1;                
            }
            return f * factorial(f - 1);
        }

        // task
        static double funk_y(int k, int s)
        {
            return (factorial(k)-s) / factorial(s);
        }

        // 5

        // palindrom
        static bool palindrom(int num)
        {
            bool flag = true;
            string str = num.ToString();
            for (int i = 0, j = str.Length-1; i < str.Length/2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
            }
            if (flag == false)
            {
                return false;
            }
            return flag;
        }

        // task

        static void get_palindrom_do_N(int N)
        {
            int i = 11;
            while (N != 0)
            {
                if (palindrom(i))
                {
                    Console.WriteLine($"Число {i} - палиндром");
                    N--;
                }
                i++;
            }
        }

        // 6 bionom 

        static int C_bionom(int m,int n)
        {
            if (m == 0 || m == n)
            {
                return 1;
            }
            return C_bionom(m, n-1) + C_bionom(m-1, m-1);
        }
        
        static void Main(string[] args)
        {

            // 1
            Random r = new Random();
            const int N = 5;
            
            int[] points_X = new int[N];
            int[] points_Y = new int[N];
            
            // Заполнение X
            for (int i = 0; i < N; i++)
            {
                points_X[i] = r.Next(0,10);
            }

            // Заполнение Y
            for (int i = 0; i < N; i++)
            {
                points_Y[i] = r.Next(0, 10);
            }
            Console.WriteLine("Task 1");
            Min_way_points(points_X, points_Y);

            // 2
            // i = 25 j = 4 и A и B, функция принимает матрицу и чекает самый высокий средний балл тупо в max по строке складываю и делю на 4 и так дальше
            int people = 25;
            int exams = 4;
            int[,] A = new int[people, exams];
            int[,] B = new int[people, exams];

            // True - Больше средний балл в A, False - B, равно тоже false
            // B
            for (int i = 0; i < people; i++)
            {
                for (int j = 0; j < exams; j++)
                {
                    A[i, j] = r.Next(1, 10);
                }
            }
            // B
            for (int i = 0; i < people; i++)
            {
                for (int j = 0; j < exams; j++)
                {
                    B[i, j] = r.Next(1, 10);
                }
            }
            Console.WriteLine($"\nTask 2: {max_ball_in_two_groups(A, B)}");

            // 3 если делится без остатка то да
            // 
            int a = 4;
            int b = 2;
            Console.WriteLine($"\nTask 3: {scarach_drob(a, b)}");
            // 4 
            int k = 5, s = 6;
            double y = funk_y(k, s);
            Console.WriteLine($"\nTask 4 y=: {y}");

            // 5 цикл до N там проверка является ли число палиндромом в функции
            Console.WriteLine($"\nTask 5");
            get_palindrom_do_N(1000);

            // 6
            int M2 = 10, N2 = 15;
            if (0 <= M2 && M2 <= N2)
            {
                Console.WriteLine($"bionom = {C_bionom(M2, N2)}");
            }
        }
    }
}

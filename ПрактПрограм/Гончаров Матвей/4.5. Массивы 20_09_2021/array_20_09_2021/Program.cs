using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_20_09_2021
{
    class Program
    {
        static void Rosa_switch(int p)
        {
            switch (p)
            {
                case 1: Console.WriteLine("паўночны"); break;
                case 2: Console.WriteLine("паўднёвы"); break;
                case 3: Console.WriteLine("усходнi"); break;
                case 4: Console.WriteLine("заходнi"); break;
                case 5: Console.WriteLine("паўночна-заходнi"); break;
                case 6: Console.WriteLine("паўночна-ўсходнi"); break;
                case 7: Console.WriteLine("паўднёва-заходнi"); break;
                case 8: Console.WriteLine("паўднёва-ўсходнi"); break;
            }
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            //Task одномерные массивы
            Console.WriteLine("\nTask одномерные массивы");
            // 1 работает
            Console.WriteLine("Задание 1");
            double[] array = new double[] { 7, 5, 3, 7, 9, 2, 8, 4, 7, 10 };
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (i == array.Length - 1)
                    {
                        array[i] = (i - 1) / 2;
                    }
                    else
                    {
                        array[i] = (i - 1 + i + 1) / 2;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i],5:f2}");
            }
            // 2 работает
            Console.WriteLine("\nЗадание 2");
            int[] array_2 = new int[] { 6, 2, -7, 6, 8, -7, 9, 0, -7, 10, 3, -7, 3 };
            int min_elem = array_2[0];
            int colvo_min = 0;
            // нахожу min
            for (int i = 1; i < array_2.Length; i++)
            {
                if (min_elem > array_2[i])
                {
                    min_elem = array_2[i];
                }
            }
            for (int i = 0; i < array_2.Length; i++)
            {
                if (array_2[i] == min_elem)
                {
                    colvo_min++;
                }
            }
            Console.WriteLine($"Колво min элементов = {colvo_min}");
            // 3 работает  
            Console.WriteLine("\nЗадание 3");
            int[] array_3 = new int[] { 2, -1, -4, 9, -3, 5, -10 };
            for (int i = 0; i < array_3.Length; i++)
            {
                for (int j = i + 1; j < array_3.Length; j++)
                {
                    if (Abs(array_3[i]) > Abs(array_3[j]))
                    {
                        array_3[i] = array_3[i] ^ array_3[j];
                        array_3[j] = array_3[i] ^ array_3[j];
                        array_3[i] = array_3[i] ^ array_3[j];
                    }
                }
            }
            for (int i = 0; i < array_3.Length; i++)
            {
                if (i % 4 == 0 && i != 0)
                {
                    Console.WriteLine();
                }

                {
                    Console.Write($"{array_3[i],8:f2}");
                }
            }

            // 4 работает
            Console.WriteLine("\nЗадание 4");
            double[] array_4 = new double[] { 1, 2, 3, 4, 5, 6, 7 }; // 3 4 5 6 7 1 2
            double first = array_4[0];
            double second = array_4[1];
            int len_arr = array_4.Length;
            for (int i = 2, flag = 0; i < len_arr && flag < len_arr - 1; i++, flag++)
            {
                array_4[flag] = array_4[i];
            }
            array_4[len_arr - 1] = second;
            array_4[len_arr - 2] = first;
            for (int i = 0; i < len_arr; i++)
            {
                Console.WriteLine($"array[{i}] = {array_4[i],5:f2}");
            }
            // 5 работает
            Console.WriteLine("\nЗадание 5");
            double[] array_5 = new double[] { 4, 5, 6, 2, 0, 2, 3, -1, 9, 0, 10, 0, -3 };
            // Sort
            int test_i = 0;
            int n = array_5.Length;
            while (test_i != n)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i == 0)
                    {
                        if (array_5[i] == 0)
                        {
                            continue;
                        }
                    }
                    if (array_5[i] == 0)
                    {
                        double z = array_5[i - 1];
                        array_5[i - 1] = array_5[i];
                        array_5[i] = z;
                    }
                }
                test_i++;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"array[{i}] = {array_5[i],5:f2}");
            }
            // 6 работает
            Console.WriteLine("\nЗадание 6");
            bool flag_est = false;
            double[] array_6 = new double[] { 1, 3, 7, 5, 3, -7, 6 };
            int help_j = 0;
            double element = array_6[help_j];
            for (int i = 1; i < array_6.Length; i++)
            {
                if ((element > 0 && array_6[i] < 0 && element == Abs(array_6[i])) || (element < 0 && array_6[i] > 0 && array_6[i] == Abs(element)))
                {
                    flag_est = true;
                    break;
                }
                element = array_6[++help_j];
            }
            Console.WriteLine($"Otvet: {flag_est}");
            // 7 работает
            Console.WriteLine("\nЗадание 7");
            Console.WriteLine($"Введите кол-во дней: ");
            int day = Convert.ToInt32(Console.ReadLine());
            int[] rosa_vetrov = new int[day];
            Random r2 = new Random();
            int[] array_colvo = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < day; i++)
            {
                rosa_vetrov[i] = r2.Next(1, 9);
            }
            for (int i = 0; i < rosa_vetrov.Length; i++)
            {
                array_colvo[rosa_vetrov[i] - 1]++; // - 1 ( ++ увеличиваю кол-во значения)
            }


            Console.WriteLine("\n rosa_vetrov");
            for (int i = 0; i < rosa_vetrov.Length; i++)
            {
                Console.Write($"{rosa_vetrov[i],5:d1}");
            }

            Console.WriteLine("\n array_colvo");
            for (int i = 0; i < array_colvo.Length; i++)
            {
                Console.Write($"{array_colvo[i],5:d1}");
            }

            int min = array_colvo[0];
            int min_index = 0;
            int max = array_colvo[0];
            int max_index = 0;
            for (int i = 1; i < array_colvo.Length; i++)
            {
                if (min > array_colvo[i])
                {
                    min = array_colvo[i];
                    min_index = i;
                }
                if (max < array_colvo[i])
                {
                    max = array_colvo[i];
                    max_index = i;
                }
            }
            // где менешь ветра жилая зона где больше для рабочей
            Console.WriteLine("Для жилой зоны: ");
            Rosa_switch(min_index);
            Console.WriteLine("Для прамысловой зоны: ");
            Rosa_switch(max_index);

            ////////////////////////////////////////////////////////////////////////////////////////// Task многомерные массивы
            Console.WriteLine("\nTask многомерные массивы");
            // по старинке или так
            // new_array3_.GetLength(0)
            // new_array3_.GetLength(1)
            // 1
            Console.WriteLine("\n####_Задание 1");
            int rows = 10, cols = 10;
            int[,] array1_ = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ((i == 0 || i == rows - 1) || (j == 0 || j == cols - 1))
                    {
                        array1_[i, j] = 1;
                        continue;
                    }
                    else
                    {
                        array1_[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{array1_[i, j],4:d1}");
                }
                Console.WriteLine();
            }

            // 2
            Console.WriteLine("\n####_Задание 2");
            int index_A = 5;
            double[,] A = new double[index_A, index_A];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = r2.Next(1, 10) + r2.NextDouble();
                }
            }
            // print
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"{A[i, j],4:f1}");
                }
                Console.WriteLine();
            }
            double sum_glavn_diagonal = 0;
            double sum_poboch_diagonal = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum_glavn_diagonal += A[i, j];
                    }
                    if (i + j == A.GetLength(1) - 1)
                    {
                        sum_poboch_diagonal += A[i, j];
                    }
                }
            }
            double sg = 0, sp = 0;
            for (int k = 0; k < A.GetLength(0); k++)
            {
                sg += A[k, k];
                sp += A[k, A.GetLength(0) - k - 1];

            }

            Console.WriteLine($"Сумма главной диагонали = {sum_glavn_diagonal}");
            Console.WriteLine($"Сумма побочной диагонали = {sum_poboch_diagonal}");


            Console.WriteLine($"Сумма главной диагонали = {sg}");
            Console.WriteLine($"Сумма побочной диагонали = {sp}");

            // 3
            Console.WriteLine("\n####_Задание 3");
            // СОЗДАТЬ массив флагов где будут минимальные элементы, заполнить его а потом тупо заполнить новый разделенными элементами при где делитель != 0, если == 0 то оставить значения как и были
            int rows2 = 6, cols2 = 7;
            double[,] array3_ = new double[rows2, cols2];
            double[] flag_array3_ = new double[rows2]; // В каждой строчке есть ли min elem
            // заполняю нулями
            for (int i = 0; i < flag_array3_.Length; i++)
            {
                flag_array3_[i] = 0;
            }
            double min_array3_;

            array3_[0, 0] = r2.Next(-10, 10) + r2.NextDouble();
            // Заполняю
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    array3_[i, j] = r2.Next(-10, 10) + r2.NextDouble();
                }
            }
            // вывожу для проверки
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write($"{array3_[i, j],6:f1}");
                }
                Console.WriteLine();
            }
            int flag_j = 0;
            for (int i = 0; i < rows2; i++)
            {
                min_array3_ = array3_[i, flag_j++];
                for (int j = 1; j < cols2; j++)
                {
                    if (min_array3_ > array3_[i, j])
                    {
                        min_array3_ = array3_[i, j];
                    }
                }
                flag_array3_[i] = min_array3_;
            }
            // min elem
            Console.WriteLine("Элементы на которые делить");
            for (int i = 0; i < flag_array3_.Length; i++)
            {
                Console.Write($"{flag_array3_[i],6:f1}");
            }
            int i_flag_array3_ = 0;
            double[,] new_array3_ = new double[rows2, cols2];
            for (int i = 0; i < new_array3_.GetLength(0); i++)
            {
                for (int j = 0; j < new_array3_.GetLength(1); j++)
                {
                    if (flag_array3_[i_flag_array3_] == 0)
                    {
                        new_array3_[i, j] = array3_[i, j];
                    }
                    else
                    {
                        new_array3_[i, j] = array3_[i, j] / flag_array3_[i_flag_array3_];
                    }
                }
                i_flag_array3_++;
            }
            // вывожу для проверки новый массив
            Console.WriteLine("\n Новый измененный другой массив");
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write($"{new_array3_[i, j],6:f1}");
                }
                Console.WriteLine();
            }
            // 4
            Console.WriteLine("\n####_Задание 4");
            // Sort массива и тупо проверять предыдущий элемент если равны остановить цикл и все, если дошло до конца строки и не нашло одинаковых элементов вернуть индекс
            int N = 5;
            int[,] matrix = new int[N, N];
            bool[] array_elem_strol_po_index = new bool[N]; // массив узнаваниия индекса строки в кторой не повторяются 
            for (int i = 0; i < array_elem_strol_po_index.Length; i++)
            {
                array_elem_strol_po_index[i] = false;
            }

            // Заполняю
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = r2.Next(-10, 10);
                }
            }
            for (int i = 0; i < N; i++)
                matrix[2, i] = i;
            int[,] sort_matrix_po_strokam = new int[N, N];
            int[] help_sort = new int[N];
            // печатаю 
            // До сортировки по строкам в массиве matrix
            Console.WriteLine("До сортировки по строкам в массиве matrix");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],6:d1}");
                }
                Console.WriteLine();
            }
            // сортирую
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    help_sort[j] = matrix[i, j];
                }
                Array.Sort(help_sort);
                for (int k = 0; k < N; k++)
                {
                    sort_matrix_po_strokam[i, k] = help_sort[k];
                }
            }
            // печатаю 
            // После сортировки по строкам уже в массиве sort_matrix_po_strokam (если надо можно тупо перезапихнуть элементы в matrix)
            Console.WriteLine("\nПосле сортировки по строкам уже в массиве sort_matrix_po_strokam");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{sort_matrix_po_strokam[i, j],6:d1}");
                }
                Console.WriteLine();
            }
            int first_elem;
            int help_h = 0;
            /////////////
            for (int i = 0; i < N; i++)
            {
                first_elem = sort_matrix_po_strokam[i, 0]; // Грубо говоря первый элемент каждой строки
                for (int j = 1; j < N; j++)
                {
                    if (first_elem == sort_matrix_po_strokam[i, j])
                    {
                        array_elem_strol_po_index[i] = true;
                        continue;
                    }
                    first_elem = sort_matrix_po_strokam[i, j];
                }
            }
            /////////////
            // Вывод номер индексов строк где не повторяются элементы
            for (int i = 0; i < array_elem_strol_po_index.Length; i++)
            {
                if (array_elem_strol_po_index[i] == false)
                {
                    Console.WriteLine($"В строке по индексу {i} нету повторяющихся элементов");
                }
                else
                {
                    Console.WriteLine($"В строке по индексу {i} есть повторяющиеся элементы");
                }
            }

            // 5
            Console.WriteLine("\n####_Задание 5");
            /*
             3 4 6     1 3 2 
             2 3 9     2 3 9
             4 5 1     3 4 6
             1 3 2     4 5 1
             */
            int N_ = 5;
            int M_ = 6;
            double[,] matrix_n_m = new double[N_, N_];
            for (int i = 0; i < matrix_n_m.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_n_m.GetLength(1); j++)
                {
                    matrix_n_m[i, j] = r2.Next(-10, 10) + r2.NextDouble();
                }
            }
            Console.WriteLine("\nВвывод не отсартированного массива");
            for (int i = 0; i < matrix_n_m.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_n_m.GetLength(1); j++)
                {
                    Console.Write($"{matrix_n_m[i, j],6:f1}");
                }
                Console.WriteLine();
            }
            double[] help_array_first = new double[matrix_n_m.GetLength(1)];
            double[] help_array_second = new double[matrix_n_m.GetLength(1)];

            double min_matrix_n_m = matrix_n_m[0, 0];
            for (int gg = 0; gg <= (matrix_n_m.GetLength(0) * matrix_n_m.GetLength(1) - 1); gg++)
            {
                for (int i = 0; i < matrix_n_m.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix_n_m.GetLength(1); j++)
                    {
                        // Проверка
                        if (i != 0 && min_matrix_n_m > matrix_n_m[i, 0])
                        { 
                            // Записываю в дополнительные массивы
                            for (int k = 0; k < matrix_n_m.GetLength(1); k++)
                            {
                                help_array_first[k] = matrix_n_m[i - 1, k];
                                help_array_second[k] = matrix_n_m[i, k];
                            }
                            // swap в массиве
                            for (int k = 0; k < matrix_n_m.GetLength(1); k++)
                            {
                                matrix_n_m[i - 1, k] = help_array_second[k];
                                matrix_n_m[i, k] = help_array_first[k];
                            }
                        }
                        else 
                        {
                            // для смены наименьшего 
                            min_matrix_n_m = matrix_n_m[i, 0]; // нужно именно тут т.к если оно зашло и поменялось оно так и останиться а если нет запихываю next элемент
                        }
                    }
                }
                min_matrix_n_m = matrix_n_m[0, 0];
            }
            
            Console.WriteLine("\nВвывод _отсартированного_ массива");
            for (int i = 0; i < matrix_n_m.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_n_m.GetLength(1); j++)
                {
                    Console.Write($"{matrix_n_m[i, j],6:f1}");
                }
                Console.WriteLine();
            }

            //// 6
            Console.WriteLine("\n####_Задание 6");
            int rows_garuch = 6, cols_garuch = 15;
            double[,] array_garuch = new double[rows_garuch, cols_garuch];
            // Заполняю рандомом
            for (int i = 0; i < rows_garuch; i++)
            {
                for (int j = 0; j < cols_garuch; j++)
                {
                    array_garuch[i, j] = r2.Next(-10, 10);
                }
            }

            // Вывод 
            Console.WriteLine("\nВвывод массива");
            for (int i = 0; i < rows_garuch; i++)
            {
                for (int j = 0; j < cols_garuch; j++)
                {
                    Console.Write($"{array_garuch[i, j],6:f1}");
                }
                Console.WriteLine();
            }

            // max по столбцу
            double max_garuch_rashod = array_garuch[0, 0];
            // для среднего по строке
            double sredn = 0;
            int help_kk = 0;

            // тут магия, i это по столбцам а j по строкам
            for (int i = 0; i < cols_garuch; i++)
            {
                max_garuch_rashod = array_garuch[0, i];
                for (int j = 1; j < rows_garuch; j++)
                {
                    // max по столбцу 
                    if (max_garuch_rashod < array_garuch[j, i])
                    {
                        max_garuch_rashod = array_garuch[j, i];
                    }
                }
                Console.WriteLine($"max по столбцу [{help_kk++}]: {max_garuch_rashod}");
            }
            Console.WriteLine();
            for (int i = 0; i < rows_garuch; i++)
            {
                sredn = 0;
                for (int j = 0; j < cols_garuch; j++)
                {
                    sredn += array_garuch[i, j];
                }
                Console.WriteLine($"Среднне значение по строке i = {i}: sredn = {sredn / (cols_garuch - 1)}");
            }
        }
    }
}









// на всякий но это не работает я уже придумал по другому

/*
 // Сортировка двумерного массива 
 for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        for (int l = 0; l < N; l++)
                        {
                            if (i + j == N && matrix[i, j] > matrix[i + 1, 0])
                            {
                                int t = matrix[i, j];
                                matrix[i, j] = matrix[i + 1, 0];
                                matrix[i + 1, 0] = t;
                            }
                            else if (matrix[i,j] > matrix[i, j+1]) 
                            {
                                int t = matrix[i, j];
                                matrix[i, j] = matrix[i,j+1];
                                matrix[i, j+1] = t;
                            }
                        }
                    }
                }
            }
 */
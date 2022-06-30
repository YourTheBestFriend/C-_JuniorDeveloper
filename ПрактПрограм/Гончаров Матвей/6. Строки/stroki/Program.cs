using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace stroki
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1
            //Console.WriteLine("Задание 1");
            //string str = "_d_ Русский #текст, Eng^lish text";
            //Console.WriteLine($"Было - {str}");
            //char[] arr_char = str.ToCharArray();
            
            //string str_ru = "";
            //string str_en = "";
            
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] >= 'A' && str[i] <= 'Z' || str[i] >= 'a' && str[i] <= 'z')
            //    {
            //        str_en += str[i];
            //    }
            //    else 
            //    {
            //        str_ru += str[i];
            //    }
            //}
            
            //str_en = str_en.ToUpper();
            //char[] str_en_2 = str_en.ToCharArray();
            //Array.Sort(str_en_2);
            //str = "";
            //str += str_ru;
            ////str.Concat(str_en_2);
            //for (int i = 0; i < str_en_2.Length; i++)
            //{
            //    str += str_en_2[i];
            //}
            //Console.WriteLine($"Стало - {str}");
            
            //// 2
            //Console.WriteLine("\nЗадание 2");
            //string str_krimin = "криминалистика";
            //str_krimin = str_krimin.Replace(str_krimin, "мина");
            //Console.WriteLine($"{str_krimin}");

            //// 3 
            //Console.WriteLine("\nЗадание 3");
            //string str_3 = "sdfg_a_sdgsfg_aa_s_a_dg_aa_ssdfsdf";
            //str_3 = str_3.Replace("aa", "a");
            //Console.WriteLine(str_3);

            // надо показать
            // 4
            Console.WriteLine("\nЗадание 4");
            string text = "Это текст, блааа. Привет как дела? Как справы, Привет еще жив? Где эта реяльность.";
            string slovo_ = "Привет";
            int colvo_slov = 0;
            // 4.1
            Console.WriteLine("Кол-во слов: " + Regex.Split(text, @" \w").Count());
            if (Regex.IsMatch(text, slovo_))
            {
                Console.WriteLine($"Слово {slovo_} есть в тексте");
            }
            else
            {
                Console.WriteLine($"Слова {slovo_} нету в тексте");
            }
            // 4.2
            string[] arr_ = text.Split(' ');
            string min = arr_[0];
            int index_min = 0;
            string max = arr_[0];
            int index_max = 0;
            for (int i = 1; i < arr_.Length; i++)
            {
                if (min.Length > arr_[i].Length)
                {
                    min = arr_[i];
                    index_min = i;
                }
                if (max.Length < arr_[i].Length)
                {
                    max = arr_[i];
                    index_max = i;
                }
            }
            Console.WriteLine($"min = {Regex.Replace(min, @"[^\w\.@-]", "")} index = {index_min}");
            Console.WriteLine($"max = {Regex.Replace(max, @"[^\w\.@-]", "")} index = {index_max}");
            // 4.3
            var new_text = new string(text.SkipWhile(x => x != ' ').ToArray());
            new_text = new string(new_text.Reverse().SkipWhile(x => x != ' ').Reverse().ToArray());
            Console.WriteLine($"{new_text}");


            //// 5 
            //// строка в ней огромное число если оно без других символов например 1111111111111111 то первое и последнне (сложить), если есть побочные символы тупо вывод то это не большое число
            //Console.WriteLine("\nЗадание 5");
            //string lik;
            //Console.Write("Введите lik: ");
            //lik = Console.ReadLine();
            //if (int.TryParse(lik, out int link_number))
            //{
            //    int first_num = 0;
            //    int last_num = link_number % 10;
            //    while (link_number != 0)
            //    {
            //        first_num = link_number % 10;
            //        link_number /= 10;
            //    }
            //    Console.WriteLine($"Это число, Сумма первого и последнего элемента = {first_num + last_num}");
            //}
            //else
            //{
            //    Console.WriteLine("Это не большое число, возможно там есть символы");
            //}

            //// 6 
            //Console.WriteLine("\nЗадание 6");
            //string my_predlozh = "Привет, это предложение.";
            //int sum = 0;
            //for (int i = 0; i < my_predlozh.Length; i++)
            //{
            //    if (my_predlozh[i] == '.')
            //    {
            //        sum += 2; // Тип перед точкой слово
            //    }
            //    else
            //    {
            //        if (my_predlozh[i] == ',' || my_predlozh[i] == '!' || my_predlozh[i] == '?' || my_predlozh[i] == ':' || my_predlozh[i] == ';')
            //        {
            //            ++sum;
            //        }
            //        else
            //        {
            //            if (my_predlozh[i] == ' ')
            //            {
            //                ++sum;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine($"Сложность текста = {sum}");
        }
    }
}

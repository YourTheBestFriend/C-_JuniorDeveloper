using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_01._11._2021
{

    // 1 структура
    struct tovar 
    {
        public string naimen;
        public int colvo;
        public double cena;
        public string izgotovitel;
        public DateTime date;

        public double maxStoimost()
        {
            return colvo * cena;
        }
    }

    // 2 структура
    struct train
    {
        public int num;
        public double time_prb;
        public double time_otb;
        public string napravlenie;
        public double rasstoianie;

        public double sredn_scorost()
        {
            return rasstoianie / (time_prb - time_otb);
        }
    }

    // 3 структура
    struct NOTE2
    {
        public string Name;
        public int TELE;
        public DateTime DATE;
        public void ShowInformation()
        {
            Console.WriteLine($"Name - {Name}, TELE - {TELE}, DATE - {DATE}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            // 1
            Console.WriteLine("________1________");
            tovar[] arr1 = new tovar[3];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i].naimen = "naimen_" + Convert.ToString(i);
                arr1[i].colvo = r.Next(1, 10);
                arr1[i].cena = r.Next(250, 500);
            }
            // find max
            int max_index = 0;
            double max = arr1[0].maxStoimost();
            for (int i = 1; i < arr1.Length; i++)
            {
                if (max < arr1[i].maxStoimost())
                {
                    max = arr1[i].maxStoimost();
                    max_index = i;
                }
            }
            Console.WriteLine($"Самая максимальная общаяя стоимость = {max}, object - {arr1[max_index].naimen}");

            // 2
            Console.WriteLine("________2________");
            train[] arr2 = new train[3];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i].rasstoianie = r.Next(10, 100);
                arr2[i].time_otb = 10.3 + i;
                arr2[i].time_prb = 20.5 + i;
            }
            // вывод средней скорости каждого поезда
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine($"train[{i}]: Sredn scorost = {arr2[i].sredn_scorost()}");
            }

            // 3
            Console.WriteLine("________3________");
            NOTE2[] arr3 = new NOTE2[7];
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write("Name: ");
                arr3[i].Name = Convert.ToString(Console.ReadLine());
                m:
                Console.Write("TELE: ");
                arr3[i].TELE = Convert.ToInt32(Console.ReadLine());
                if (arr3[i].TELE > 9999999 || arr3[i].TELE < 999999)
                {
                    Console.WriteLine("Error");
                    goto m;
                }
            }

            // Сортировка по трем цифрам
            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3.Length-1; j++)
                {
                    NOTE2 help;
                    // Первые 3 цифры
                    if (arr3[j].TELE / 10000 > arr3[j + 1].TELE / 10000)
                    {
                        help = arr3[j];
                        arr3[j] = arr3[j + 1];
                        arr3[j + 1] = help;
                    }
                }
            }

            string name;
            Console.Write("Input name: ");
            name = Convert.ToString(Console.ReadLine());
            bool flag = true;
            for (int i = 0; i < arr3.Length; i++)
            {
                if (arr3[i].Name == name)
                {
                    arr3[i].ShowInformation();
                    flag = false;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Такого нет");
            }
        }
    }
}

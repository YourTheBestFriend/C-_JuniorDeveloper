using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace structure
{
    class sport_people
    {
        public string naimen_country;
        public string name_command;
        public string FIO;
        public int game_num;
        public int age;
        public double hight;
        public double weigth;
        public void IMT()
        {
            Console.WriteLine($"FIO - {FIO}, IMT = {weigth / Pow(hight, 2), 5:f2} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            sport_people p1 = new sport_people();
            p1.naimen_country = "Reapablic of Belarus";
            p1.name_command = "Nimiga";
            p1.FIO = "Goncharov Matvey Nocholaevich";
            p1.game_num = 10;
            p1.age = 17;
            p1.hight = 1.94;
            p1.weigth = 63;
            p1.IMT();

            // colvo object
            int colvo_obj_struct = 3;
            sport_people[] array = new sport_people[colvo_obj_struct];
            ////for (int i = 0; i < array.Length; i++)
            ////{
            ////}
            // Заполняю
            Console.WriteLine("***");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new sport_people();
                Console.Write($"FIO object[{i}]: ");
                array[i].FIO = Convert.ToString(Console.ReadLine());
                Console.Write($"Weight: object[{i}]: ");
                array[i].weigth = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Hight: object[{i}]: ");
                array[i].hight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("***");
            }

            // Вывод для всех индекс массы тела
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"FIO object[{i}]: ");
                array[i].IMT();
            }

        }
    }
}

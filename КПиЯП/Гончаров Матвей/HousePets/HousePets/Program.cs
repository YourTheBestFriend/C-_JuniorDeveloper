using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            List<Person> list_per = new List<Person>();
            using (StreamReader sr = new StreamReader("file_zap.txt"))
            {
                string[] temp = sr.ReadLine().Split(",");
                list.Add(new Animal(temp[1], temp[2], Convert.ToInt32(temp[3])));
                list_per.Add(new Person(temp[0], list));

                while (!sr.EndOfStream)
                {
                    temp = sr.ReadLine().Split(",");
                    bool flag = false;
                    int k = 0;
                    foreach (var variable in list_per)
                    {
                        if (variable.name_pers == temp[0])
                        {
                            list_per[k].listA.Add((new Animal(temp[1], temp[2], Convert.ToInt32(temp[3]))));
                            flag = true;
                            break;
                        }
                        k++;
                    }
                    if (!flag)
                    {
                        list = new List<Animal>();
                        list.Add(new Animal(temp[1], temp[2], Convert.ToInt32(temp[3])));
                        list_per.Add(new Person(temp[0], list));
                    }
                }
            }
            int num = 0;
            do
            {
                Console.Write("Введите пункт меню 1-4 (0 - выход из программы)");
                Console.WriteLine("\n1.Посчитать количество различных видов животных у каждого владельца.\n2.Для конкретного вида животного (вводится пользователем) вывести всех его владельцев и клички.\n3. Определить, сколько видов животных носит определённую кличку (кличка вводится пользователем).\n4. Вывести информацию о возрасте самого старого и самого молодого животного каждого вида.");
                num = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (num)
                    {
                        case 1:
                            foreach (var variable in list_per)
                            {
                                Console.WriteLine($"Владелец с именем {variable.name_pers} имеет {variable.HowManyTypesOfAnimals()}" + $" различных видов животных");
                            }
                            break;
                        case 2:
                            Console.Write("Введите необходимый тип животного для поиска: ");
                            string typeOfNeededAnimal = Console.ReadLine();
                            foreach (var variable in list_per)
                            {
                                Console.WriteLine(variable.FindAnimalsByType(typeOfNeededAnimal));
                            }
                            break;
                        case 3:
                            Console.Write("Введите кличку для подсчёта животных с такой кличкой: ");
                            string nickname = Console.ReadLine();
                            List<string> types2 = new List<string>();
                            foreach (var variable in list_per)
                            {
                                foreach (var variable2 in variable.listA)
                                {
                                    if (variable2.nickNAme == nickname)
                                    {
                                        types2.Add(variable2.kindofAnimal);
                                    }
                                }

                            }
                            var newtypes2 = types2.Distinct();
                            newtypes2.Count();
                            Console.WriteLine($"Количество животных с кличкой {nickname} = {newtypes2.Count()}");
                            break;
                        case 4:
                            List<string> types = new List<string>();
                            foreach (var variable in list_per)
                            {
                                foreach (var V2 in variable.listA)
                                {
                                    types.Add(V2.kindofAnimal);
                                }
                            }

                            var newtypes = types.Distinct();
                            foreach (var variable in newtypes)
                            {
                                int minzn = 10000;
                                int maxzn = -10000;
                                foreach (var V2 in list_per)
                                {
                                    int mintemp = V2.FindMinInListWithNeededType(variable);
                                    int maxtemp = V2.FindMaxInListWithNeededType(variable);
                                    if (mintemp == 10000 & maxtemp == -10000)
                                        continue;
                                    else
                                    {
                                        if (mintemp < minzn)
                                            minzn = mintemp;
                                        if (maxtemp > maxzn)
                                            maxzn = maxtemp;
                                    }
                                }
                                Console.WriteLine($"У {variable} минимальный возраст равен" + $" {minzn}, а максимальный -  {maxzn}");
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (num != 0);

        }
    }
}

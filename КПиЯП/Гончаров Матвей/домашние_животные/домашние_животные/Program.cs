using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace домашние_животные
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            List<Person> list_per = new List<Person>();

            int num = 0;
            do
            {
                System.Console.Write("Введите пункт: ");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        list = new List<Animal>();
                        System.Console.WriteLine("imya vladelcya:");
                        string imyavlad = Console.ReadLine();
                        string buffer = "";
                        do
                        {
                            System.Console.WriteLine("Введите имя, кличку и возраст дживотного в формате имя;кличка;возраст (Если нет клички - ввод запятой, если больше животных нет - ввод точки)");
                            buffer = Console.ReadLine();
                            if (buffer == ".")
                                continue;
                            string[] temp = buffer.Split(";");
                            int tempp = Convert.ToInt32(temp[2]);

                            list.Add(new Animal(temp[0], temp[1], tempp));
                        } while (buffer != ".");

                        list_per.Add(new Person(imyavlad, list));
                        break;
                    case 2:
                        foreach (var item in list_per)
                        {
                            System.Console.WriteLine(item);
                        }
                        break;
                    case 3:
                        StreamWriter sw = new StreamWriter("input.txt");
                        foreach (var item in list_per)
                        {
                            sw.WriteLine(item);
                        }
                        sw.Close();
                        break;
                    case 4:
                        foreach (var VARIABLE in list_per)
                        {
                            List<string> types3 = new List<string>();
                            foreach (var V2 in VARIABLE.list)
                            {
                                types3.Add(V2.vid);
                            }

                            var newtypes3 = types3.Distinct();
                            int count2 = 0;
                            foreach (var item in newtypes3)
                            {
                                count2++;
                            }


                            System.Console.WriteLine(VARIABLE.name_owner + " имеет " + count2 + " вида животных");

                        }

                        break;
                    case 5:
                        System.Console.Write("Введите вид: ");
                        string vid = Console.ReadLine();
                        foreach (var item in list_per)
                        {
                            for (int i = 0; i < item.list.Count; i++)
                            {
                                if (vid == item.list[i].vid)
                                {
                                    System.Console.WriteLine(item.name_owner + " " + item.list[i].klichka);
                                }
                            }
                        }
                        break;
                    case 6:
                        System.Console.Write("Введите кличку: ");
                        string name = Console.ReadLine();
                        List<string> types2 = new List<string>();
                        foreach (var VARIABLE in list_per)
                        {
                            foreach (var V2 in VARIABLE.list)
                            {
                                if (V2.klichka == name)
                                {
                                    types2.Add(V2.vid);
                                }
                            }
                        }

                        var newtypes = types2.Distinct();
                        int count = 0;
                        foreach (var item in newtypes)
                        {
                            count++;
                        }
                        System.Console.WriteLine("Кол-во видов животных: " + count);
                        break;
                    case 7:
                        List<string> types = new List<string>();
                        foreach (var VARIABLE in list_per)
                        {
                            foreach (var V2 in VARIABLE.list)
                            {
                                types.Add(V2.vid);
                            }
                        }

                        var newtypes2 = types.Distinct();
                        foreach (var VARIABLE in newtypes2)
                        {
                            int minzn = 10000;
                            int maxzn = -10000;
                            foreach (var V2 in list_per)
                            {
                                int mintemp = V2.FindMinInListWithNeededType(VARIABLE);
                                int maxtemp = V2.FindMaxInListWithNeededType(VARIABLE);
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
                            Console.WriteLine($"У {VARIABLE} минимальный возраст равен" +
                                                $" {minzn}, а максимальный -  {maxzn}");
                        }
                        break;
                }

            } while (num != 0);



        }
    }
    }

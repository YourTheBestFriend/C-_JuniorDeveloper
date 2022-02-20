using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_08_02_2022
{
    public class SheduleDisciplini
    {
        public List<Disciplina> ListDisciplin { get; set; } = new List<Disciplina>();

        // Вывод названий дисциплин имеющух курсач
        public void PrintNameDisciplinIfEstKursach()
        {
            Console.WriteLine("Названия дисциплин у которых есть курсач");
            foreach (var x in ListDisciplin)
            {
                if (x.NalichKursacha == "Да")
                {
                    Console.WriteLine("NameDisciplina: " + x.NameDisciplina);
                }
            }
        }

        // Вывести фамилию преподавателя с наибольшим количеством экзаменов
        public void PrintNamePrepodavatelaMAXCOlEXAMS()
        {
            Console.WriteLine("Фамилия преподавателя с наибольшим количеством экзаменов");
            int max = ListDisciplin[0].NumStudents, index = 0;
            for (int i = 1; i < ListDisciplin.Count; i++)
            {
                if (max < ListDisciplin[i].NumStudents)
                {
                    max = ListDisciplin[i].NumStudents;
                    index = i;
                }
            }
            Console.WriteLine($"FamiliaPrepodsavatela: {ListDisciplin[index].FamiliaPrepodsavatela}");
        }

        // Вывести количество практических занятий по всем учебным дисциплинам
        public void PrintColvoPractZanatii()
        {
            Console.WriteLine("количество практических занятий");
            foreach (var x in ListDisciplin)
            {
                Console.WriteLine("NameDisciplina: " + x.NameDisciplina + " ColvoPractLekcii: " + x.ColvoPractLekcii);
            }
        }
         
        // Добавление объекта
        public void AddDisciplina()
        {
            Console.WriteLine("Добавление объекта: ");
            //string nameDisciplina, string familiaPrepodsavatela, int numStudents, int colvoHourLekcii, int colvoPractLekcii, string nalichKursacha, string vidItogovogoKursacha
            Console.WriteLine("Введите кол-во объектов: ");
            int j = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < j; i++)
            {
                Disciplina x = new Disciplina();
                while(true)
                {
                    try
                    {
                        // Просто в блок выделил
                        {
                            Console.Write("name: ");
                            x.NameDisciplina = Convert.ToString(Console.ReadLine());
                            Console.Write("familiaPrepodsavatela: ");
                            x.FamiliaPrepodsavatela = Convert.ToString(Console.ReadLine());
                            Console.Write("numStudents: ");
                            x.NumStudents = Convert.ToInt32(Console.ReadLine());
                            Console.Write("colvoHourLekcii: ");
                            x.ColvoHourLekcii = Convert.ToInt32(Console.ReadLine());
                            Console.Write("colvoPractLekcii: ");
                            x.ColvoPractLekcii = Convert.ToInt32(Console.ReadLine());
                            Console.Write("nalichKursacha: ");
                            x.NalichKursacha = Console.ReadLine();
                            Console.Write("vidItogovogoKursacha: ");
                            x.VidItogovogoKursacha = Console.ReadLine();
                        }
                        ListDisciplin.Add(x);
                        Console.WriteLine(" Сработала функция - AddDisciplina");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error = " + ex.Message);
                    }
                   
                }
            }
        }

        // Группировка
        public void PrintGroup()
        {
            while (true)
            {
                //string nameDisciplina, string familiaPrepodsavatela, int numStudents, int colvoHourLekcii, int colvoPractLekcii, string nalichKursacha, string vidItogovogoKursacha
                Console.WriteLine("По чем хотите сгруппировать?:\n1 - nameDisciplina\n2 - familiaPrepodsavatela\n3 - numStudents\n 4 - colvoHourLekcii\n5 - colvoPractLekcii\n6 - nalichKursacha\n7 - vidItogovogoKursacha");
                switch (Console.ReadLine())
                {
                    case "1":
                        var Des = ListDisciplin.GroupBy(x => x.NameDisciplina);
                        foreach (var f in Des)
                        {
                            Console.WriteLine(f.Key);

                            foreach (var dis in f)
                            {
                                Console.WriteLine(dis.NameDisciplina + " Familia: " + dis.FamiliaPrepodsavatela);
                            }
                            Console.WriteLine(); // для разделения между группами
                        }
                        break;
                    case "2":
                        var Des2 = ListDisciplin.GroupBy(x => x.FamiliaPrepodsavatela);
                        foreach (var f in Des2)
                        {
                            Console.WriteLine(f.Key);

                            foreach (var dis in f)
                            {
                                Console.WriteLine(dis.FamiliaPrepodsavatela + " Familia: " + dis.FamiliaPrepodsavatela);
                            }
                            Console.WriteLine(); // для разделения между группами
                        }
                        break;
                    case "3":
                        var Des3 = ListDisciplin.GroupBy(x => x.NumStudents);
                        foreach (var f in Des3)
                        {
                            Console.WriteLine(f.Key);

                            foreach (var dis in f)
                            {
                                Console.WriteLine(dis.NumStudents + " Familia: " + dis.FamiliaPrepodsavatela);
                            }
                            Console.WriteLine(); // для разделения между группами
                        }
                        break;
                    case "4":
                        var Des4 = ListDisciplin.GroupBy(x => x.ColvoHourLekcii);
                        foreach (var f in Des4)
                        {
                            Console.WriteLine(f.Key);

                            foreach (var dis in f)
                            {
                                Console.WriteLine(dis.ColvoHourLekcii + " Familia: " + dis.FamiliaPrepodsavatela);
                            }
                            Console.WriteLine(); // для разделения между группами
                        }
                        break;
                    case "5":
                        var Des5 = ListDisciplin.GroupBy(x => x.NalichKursacha);
                        foreach (var f in Des5)
                        {
                            Console.WriteLine(f.Key);

                            foreach (var dis in f)
                            {
                                Console.WriteLine(dis.NalichKursacha + " Familia: " + dis.FamiliaPrepodsavatela);
                            }
                            Console.WriteLine(); // для разделения между группами
                        }
                        break;
                    case "6":
                        var Des6 = ListDisciplin.GroupBy(x => x.NalichKursacha);
                        foreach (var f in Des6)
                        {
                            Console.WriteLine(f.Key);

                            foreach (var dis in f)
                            {
                                Console.WriteLine(dis.NalichKursacha + " Familia: " + dis.FamiliaPrepodsavatela);
                            }
                            Console.WriteLine(); // для разделения между группами
                        }
                        break;
                    case "7":
                        var Dec7 = ListDisciplin.GroupBy(x => x.VidItogovogoKursacha);
                        foreach (var f in Dec7)
                        {
                            Console.WriteLine(f.Key);

                            foreach (var dis in f)
                            {
                                Console.WriteLine(dis.VidItogovogoKursacha + " Familia: " + dis.FamiliaPrepodsavatela);
                            }
                            Console.WriteLine(); // для разделения между группами
                        }
                        break;
                }
            }
        }
    }
}

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

        // Группировка, поход не так
        public void PrintGroup()
        {
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
        }
    }
}

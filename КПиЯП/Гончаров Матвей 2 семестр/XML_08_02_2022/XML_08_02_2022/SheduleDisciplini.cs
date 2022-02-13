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
        public void PrintNameDisciplinIfEstKursach(List<Disciplina> ListDisciplin_)
        {
            Console.WriteLine("Названия дисциплин у которых есть курсач");
            foreach (var x in ListDisciplin_)
            {
                if (x.NalichKursacha == "Да")
                {
                    Console.WriteLine("NameDisciplina: " + x.NameDisciplina);
                }
            }
        }

        // Вывести фамилию преподавателя с наибольшим количеством экзаменов
        public void PrintNamePrepodavatelaMAXCOlEXAMS(List<Disciplina> ListDisciplin_)
        {
            Console.WriteLine("Фамилия преподавателя с наибольшим количеством экзаменов");
            int max = ListDisciplin_[0].NumStudents, index = 0;
            for (int i = 1; i < ListDisciplin_.Count; i++)
            {
                if (max < ListDisciplin_[i].NumStudents)
                {
                    max = ListDisciplin_[i].NumStudents;
                    index = i;
                }
            }
            Console.WriteLine($"FamiliaPrepodsavatela: {ListDisciplin_[index].FamiliaPrepodsavatela}");
        }

        // Вывести количество практических занятий по всем учебным дисциплинам
        public void PrintColvoPractZanatii(List<Disciplina> ListDisciplin_)
        {
            Console.WriteLine("количество практических занятий");
            foreach (var x in ListDisciplin_)
            {
                Console.WriteLine("NameDisciplina: " + x.NameDisciplina + " ColvoPractLekcii: " + x.ColvoPractLekcii);
            }
        }
         
        // Добавление объекта
        public void AddDisciplina(List<Disciplina> listDis)
        {
            Console.WriteLine("Добавление объекта: ");
            //string nameDisciplina, string familiaPrepodsavatela, int numStudents, int colvoHourLekcii, int colvoPractLekcii, string nalichKursacha, string vidItogovogoKursacha
            Console.WriteLine("Введите кол-во объектов: ");
            int j = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < j; i++)
            {
                Disciplina x = new Disciplina();
                Console.Write("name: ");
                // Просто в блок выделил
                {
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
                    x.NalichKursacha = Convert.ToString(Console.ReadLine());
                    Console.Write("vidItogovogoKursacha: ");
                    x.VidItogovogoKursacha = Convert.ToString(Console.ReadLine());
                }
                listDis.Add(x);
                Console.WriteLine(" Сработала функция - AddDisciplina");
            }
        }
    }
}

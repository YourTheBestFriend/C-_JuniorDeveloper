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
            foreach (var x in ListDisciplin)
            {
                Console.WriteLine("Названия дисциплин у которых есть курсач");
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
                    max = ListDisciplin[0].NumStudents;
                    index = i;
                }
            }
            Console.WriteLine("FamiliaPrepodsavatela: " + ListDisciplin[index].FamiliaPrepodsavatela);
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
         

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Вот тут вопрос List как копия будет ?    если нет то просто исправлю на void
        // Добавление объекта
        public void AddDisciplina(List<Disciplina> listDis)
        {
            Console.WriteLine("Добавление объекта: ");
            Disciplina x = new Disciplina();
            for (int i = 0; i < listDis.Count; i++)
            {

            }
            listDis.Add(x);

            
        }

    }
}

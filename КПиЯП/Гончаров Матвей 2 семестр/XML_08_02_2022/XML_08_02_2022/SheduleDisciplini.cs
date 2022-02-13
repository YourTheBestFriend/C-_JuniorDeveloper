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
                    Console.WriteLine();
                }
            }
        }
    }
}

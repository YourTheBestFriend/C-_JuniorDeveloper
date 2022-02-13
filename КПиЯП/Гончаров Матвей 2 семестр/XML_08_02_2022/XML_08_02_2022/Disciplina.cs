using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_08_02_2022
{
    /// <summary>
    /// Дисциплина
    /// </summary>
    public class Disciplina
    {  
        private string nameDisciplina;
        private string familiaPrepodsavatela;
        private int numStudents;
        private int colvoHourLekcii;
        private string nalichKursacha;

        ///////////////////////////////////////////////////////////////////////////////////////////////////// Секция с функциями для свойств
        public bool chekUperzaglav(string s)
        {
            if (s.ToUpper()[0] == s[0]) return true;
            else return false;
        }
        

        public string NameDisciplina
        {
            get { return nameDisciplina; }
            set
            {
                // Название дисциплины, фамилия преподавателя – с большой буквы (должно быть)
                if (chekUperzaglav(value)) // А а     А А
                {
                    nameDisciplina = value;
                }
                else
                {
                    throw new Exception("Название с маленькой буквы");
                }
                
            }
        }

        public string FamiliaPrepodsavatela
        {
            get { return familiaPrepodsavatela; }
            set
            {
                // Название дисциплины, фамилия преподавателя – с большой буквы (должно быть)
                if (chekUperzaglav(value)) // А а     А А
                {
                    nameDisciplina = value;
                }
                else
                {
                    throw new Exception("Фамилия преподавателя с маленькой буквы");
                }

            }
        }
        public int NumStudents
        {
            get { return numStudents; }
            set
            {
                if (value > 0)
                {
                    numStudents = value;
                }
                else
                {
                    throw new Exception("Кол-во студентов не может быть отрицательным");
                }
            }
        }
        public int ColvoHourLekcii
        {
            get { return colvoHourLekcii; }
            set
            {
                if (value > 0)
                {
                    colvoHourLekcii = value;
                }
                else
                {
                    throw new Exception("Кол-во часов практики с не может быть отрицательным");
                }
            }
        }
        public string NalichKursacha
        {
            get { return nalichKursacha; }
            set
            {
                if (value.ToUpper()[0] == value[0])
                {
                    nameDisciplina = value;
                }
                else
                {
                    throw new Exception("Фамилия преподавателя с маленькой буквы");
                }

            }
        }

      

        public bool Important { get; set; }

        public override string ToString()
        {
            return "NameDisciplina: " + NameDisciplina;
        }
    }
}

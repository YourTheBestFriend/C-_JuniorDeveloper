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
    public class Disciplina : IComparable<Disciplina>
    {  
        private string nameDisciplina;
        private string familiaPrepodsavatela;
        private int numStudents;
        private int colvoHourLekcii;
        private int colvoPractLekcii;
        private string nalichKursacha;
        private string vidItogovogoKursacha;

        ///////////////////////////////////////////////////////////////////////////////////////////////////// Секция с функциями для свойств
        // Для Проверки на заглавную букву
        public bool CheckUperZaglav(string s)
        {
            if (s.ToUpper()[0] == s[0]) return true;
            else return false;
        }
        // Для отрицательного
        public bool CheckBiggerThenZero(int s)
        {
            if (s > 0) return true;
            else return false;
        }

        // Для сравнения одного из параметров
        public bool CheckFirstOrSecondWord(string ishodnoe, string s1, string s2)
        {
            if (ishodnoe == s1 || ishodnoe == s2) return true;
            else return false;
        }

        // Constructors
        public Disciplina() { }
        public Disciplina(string nameDisciplina, string familiaPrepodsavatela, int numStudents, int colvoHourLekcii, int colvoPractLekcii, string nalichKursacha, string vidItogovogoKursacha) 
        {
            NameDisciplina = nameDisciplina;
            FamiliaPrepodsavatela = familiaPrepodsavatela;
            NumStudents = numStudents;
            ColvoHourLekcii = colvoHourLekcii;
            ColvoPractLekcii = colvoPractLekcii;
            NalichKursacha = nalichKursacha;
            VidItogovogoKursacha = vidItogovogoKursacha;
        }
       
        // Свойства
        public string NameDisciplina
        {
            get { return nameDisciplina; }
            set
            {
                // Название дисциплины, фамилия преподавателя – с большой буквы (должно быть)
                if (CheckUperZaglav(value)) // А а     А А
                {
                    nameDisciplina = value;
                }
                else
                {
                    throw new MyClassException("Название с маленькой буквы");
                }
            }
        }
        public string FamiliaPrepodsavatela
        {
            get { return familiaPrepodsavatela; }
            set
            {
                // Название дисциплины, фамилия преподавателя – с большой буквы (должно быть)
                if (CheckUperZaglav(value)) // А а     А А
                {
                    nameDisciplina = value;
                }
                else
                {
                    throw new MyClassException("Фамилия преподавателя с маленькой буквы");
                }
            }
        }
        public int NumStudents
        {
            get { return numStudents; }
            set
            {
                if (CheckBiggerThenZero(value))
                {
                    numStudents = value;
                }
                else
                {
                    throw new MyClassException("Кол-во студентов не может быть отрицательным");
                }
            }
        }
        public int ColvoHourLekcii
        {
            get { return colvoHourLekcii; }
            set
            {
                if (CheckBiggerThenZero(value))
                {
                    colvoHourLekcii = value;
                }
                else
                {
                    throw new MyClassException("Кол-во часов лекции с не может быть отрицательным");
                }
            }
        }
        public int ColvoPractLekcii
        {
            get { return colvoPractLekcii; }
            set
            {
                if (CheckBiggerThenZero(value))
                {
                    colvoPractLekcii = value;
                }
                else
                {
                    throw new MyClassException("Кол-во часов практики с не может быть отрицательным");
                }
            }
        }
        public string NalichKursacha
        {
            get { return nalichKursacha; }
            set
            {
                if (CheckFirstOrSecondWord(value, "Да", "Нет"))
                {
                    nalichKursacha = value;
                }
                else
                {
                    throw new MyClassException("Вы ввели что-то кроме - Да/Нет");
                }
            }
        }

        public string VidItogovogoKursacha
        {
            get { return vidItogovogoKursacha; }
            set
            {
                if (CheckFirstOrSecondWord(value, "Зачет", "Экзамен"))
                {
                    vidItogovogoKursacha = value;
                }
                else
                {
                    throw new MyClassException("Вы ввели что-то кроме - зачет/экзамен");
                }
            }
        }

        // Для сортировки
        public int CompareTo(Disciplina? other)
        {
            // string str = @"абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string str = @"abcdefghijklmnopqrstuvwxyz";
            // Для проверки
            if (str.IndexOf(FamiliaPrepodsavatela.ToLower()[0]) > str.IndexOf(other.FamiliaPrepodsavatela.ToLower()[0]) && NumStudents > other.NumStudents)
            {
                return 1;
            }
            else if (str.IndexOf(FamiliaPrepodsavatela.ToLower()[0]) < str.IndexOf(other.FamiliaPrepodsavatela.ToLower()[0]) && NumStudents < other.NumStudents)
            {
                return -1;
            }
            return 0;
        }
        // data
        public override string ToString() => "NameDisciplina: " + NameDisciplina + " FamiliaPrepodsavatela: " + FamiliaPrepodsavatela + " NumStudents: " + NumStudents;
    }
}

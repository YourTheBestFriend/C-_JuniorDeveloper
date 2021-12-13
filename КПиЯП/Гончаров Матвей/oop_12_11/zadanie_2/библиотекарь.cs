using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    public class библиотекарь
    {
        private string name;
        private int age;

        private List<Student> zapisStudent;
            
        // Свойство
       public List<Student> ZapisStudent
       {
            //get => ZapisStudent;
            set { zapisStudent = value; }
       }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set
            {
                if (value < 18 || value > 100)
                {
                    Console.WriteLine("Проверка на возрост  15 < age < 100");
                }
                else
                {
                    age = value;
                }
            }
            get { return age; }
        }
        public библиотекарь()
        {
            name = "none";
            age = 0; 
        }
        public библиотекарь(string name, int age, byte numKursa)
        {
            this.name = name;
            this.age = age; 
        }
        public void AddStudents(params Student[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                zapisStudent.Add(x[i]);
            }
        }
        public void PrintNameStudents()
        {
            for (int i = 0; i < zapisStudent.Count; i++)
            {
                Console.WriteLine($"student name[{i}] = {zapisStudent[i].Name}");
            }
        }
        public void reading() { Console.WriteLine($"name = {this.Name}: Я читаю......."); }
    }
}

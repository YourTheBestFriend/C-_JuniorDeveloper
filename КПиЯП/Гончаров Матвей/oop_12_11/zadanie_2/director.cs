using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    public class director
    {
        private string name;
        private int age;
        private List<Student> listStudent;
            
        // Свойство
       public List<Student> ListStudent
        {
            //get => ZapisStudent;
            set { listStudent = value; }
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
                if (value < 30 || value > 100)
                {
                    Console.WriteLine("Проверка на возрост  30 < age < 100");
                }
                else
                {
                    age = value;
                }
            }
            get { return age; }
        }
        public director()
        {
            name = "none";
            age = 0; 
        }
        public director(string name, int age)
        {
            this.name = name;
            this.age = age; 
        }
        public void PrintNameStudents()
        {
            for (int i = 0; i < listStudent.Count; i++)
            {
                Console.WriteLine($"student name[{i}] = {listStudent[i].Name}");
            }
        }
    }
}

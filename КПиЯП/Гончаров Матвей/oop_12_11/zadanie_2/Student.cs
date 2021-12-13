using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    public class Student
    {
        private string name;
        private int age;
        // Номер курса
        private byte numKursa = 0;

        // Свойство
        public byte NumKursa
        {
            set { numKursa = value; }
            get => numKursa;
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
                if (value < 15 || value > 100)
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
        public Student()
        {
            name = "none";
            age = 0;
            numKursa = 0;
        }
        public Student(string name, int age, byte numKursa)
        {
            this.name = name;
            this.age = age;
            this.numKursa = numKursa;
        }
        public void reading() { Console.WriteLine($"name = {this.Name}: Я читаю......."); }
    }
}

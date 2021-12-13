using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    public class security
    {
        private string name;
        private int age;
        
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set
            {
                if (value < 25 || value > 100)
                {
                    Console.WriteLine("Проверка на возрост  25 < age < 100");
                }
                else
                {
                    age = value;
                }
            }
            get { return age; }
        }
        public security()
        {
            name = "none";
            age = 0;
        }
        public security(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void reading() { Console.WriteLine($"name = {this.Name}: Я читаю......."); }
    }
}

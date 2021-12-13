using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    public class casear
    {
        private string name;
        private int age;
        private string kvalific;

        public string Kvalific
        {
            set { kvalific = value; }
            get => kvalific;
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
        public casear()
        {
            name = "none";
            age = 0;
            kvalific = "none";
        }
        public casear(string name, int age, string kvalific)
        {
            this.name = name;
            this.age = age;
            this.kvalific = kvalific;
        }
        public void working() { Console.WriteLine($"name = {this.Name}: Продаю товары"); }
    }
}

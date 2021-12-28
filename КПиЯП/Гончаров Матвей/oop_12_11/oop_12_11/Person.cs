using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_12_11
{
    abstract class Person
    {
        private string name;
        private int age;

        // get / set
        // Почитал про свойства как вы просили, теперб буду писать так :D
        public string Name
        {
            // акссесоры или методы доступа или как обычно геттеры сеттеры
            set { name = value; } // еще есть такая тема как init
            get { return name; }
        }
        public int Age
        {
            set
            {
                if (value < 1 || value > 100)
                {
                    Console.WriteLine("Проверка на возрост  1 < age < 100");
                }
                else
                {
                    age = value;
                }
            }
            get { return age; }
        }

        // Constructors
        public Person() 
        {
            name = "none";
            age = 0;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.Age = age;
        }

        // metod
        public abstract void Speak(string text);
    }
}

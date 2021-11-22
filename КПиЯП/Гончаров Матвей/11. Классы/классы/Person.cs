using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классы
{
    class Person
    {
        string fullName;
        int age;
        public Person() {}
        public Person(string fullName, int age)
        {
            this.fullName = fullName;
            this.age = age;
        }
        public void move()
        {
            Console.WriteLine($"{fullName} говорит");
        }
        public void talk()
        {
            Console.WriteLine($"{fullName} говорит");
        }
    }
}

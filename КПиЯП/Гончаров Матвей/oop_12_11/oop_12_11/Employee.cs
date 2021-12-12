using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_12_11
{
    class Employee : Person
    {
        // например работает ли он больше чем 5 лет
        private bool workingMoreThanFiveYears;
        // Свойство
        public bool WorkingMoreThanFiveYears
        {
            get => workingMoreThanFiveYears;
            set { workingMoreThanFiveYears = value; }
        }
        // Конструкторы
        public Employee()
        {
            workingMoreThanFiveYears = false;
        }
        public Employee(string name, int age) : base(name, age)
        {
            workingMoreThanFiveYears = false;
        }
        public Employee(string name, int age, bool workingMoreThanFiveYears) : base(name, age)
        {
            this.workingMoreThanFiveYears = workingMoreThanFiveYears;
        }

        public override void Speak(string text)
        {
            Console.WriteLine($"{this.Name} speak: {text}");
        }
    }
}

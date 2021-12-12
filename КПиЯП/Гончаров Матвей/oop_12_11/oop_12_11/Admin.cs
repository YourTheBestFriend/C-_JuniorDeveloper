using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_12_11
{
    class Admin : Employee
    {
        // Количество настроенных серверов
        private int mkServers;
        // Свойство
        public int MkServers
        {
            get => mkServers;
            set { mkServers = value; }
        }
        // Конструкторы
        public Admin()
        {
            mkServers = 0;
        }
        public Admin(string name, int age, bool workingMoreThanFiveYears) : base(name, age, workingMoreThanFiveYears)
        {
            mkServers = 0;
        }
        public Admin(string name, int age, bool workingMoreThanFiveYears, int mkServers) : base(name, age, workingMoreThanFiveYears)
        {
            this.mkServers = mkServers;
        }
        public override void Speak(string text)
        {
            Console.WriteLine($"{this.Name} speak: {text}");
        }
        public override string ToString() { return $"name = {this.Name}, age = {this.Age}, number maked servers = {this.MkServers}."; }

    }
}

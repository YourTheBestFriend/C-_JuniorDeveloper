using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePets
{
  public class Animal
  {
        public string kindofAnimal;
        public string nickNAme;
        public int Age;
        public Animal() { }
        public Animal(string kindofAnimal, string nickNAme, int Age)
        {
            this.kindofAnimal = kindofAnimal;
            if (nickNAme == ",,")
            {
                Console.WriteLine("У питомца нет клички");
            }
            else 
            {
                this.nickNAme = nickNAme;
            }
            this.Age = Age;
        }
    public override string ToString()
    {
            return $"Вид питомца: {kindofAnimal}\nКличка: {nickNAme}\nВозраст: {Age}";
    }
  }
}

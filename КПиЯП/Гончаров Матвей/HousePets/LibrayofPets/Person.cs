using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrayofPets
{
   public class Person
   {
        public string name_pers;
        public List<Animal> listA;
        public Person(string name_pers, List<Animal> listA)
        {
            this.name_pers = name_pers;
            this.listA = listA;
        }
        public override string ToString()
        {
            string info = "";
            foreach (var item in listA)
            {
                info += item.kindofAnimal + "," + item.nickNAme + "," + item.Age + "\n";
            }
            return $"\nИмя: {name_pers}\nЖивотные: {info}";
        }
        public int HowManyTypesOfAnimals()//кол-во животных
        {
            List<string> types = new List<string>();
            foreach (var variable in listA)
            {
                types.Add(variable.kindofAnimal);
            }
            var newtypes = types.Distinct();
            return newtypes.Count();
        }
        public string FindAnimalsByType(string typeOfNeededAnimal)
        {
            string temp = $"Владелец: {name_pers}\n";
            foreach (var variable in listA)
            {
                if (variable.kindofAnimal == typeOfNeededAnimal)
                    temp += $"Кличка: {variable.nickNAme}\n";
            }
            if (temp == $"Владелец: {name_pers}\n")
            {
                return $"У {name_pers} нет животных такого типа";
            }
            else
            {
                return temp;
            }   
        }
        public int FindMinInListWithNeededType(string typeOfNeededAnimal)
        {
            int min = 10000;
            foreach (var variable in listA)
            {
                if (variable.kindofAnimal == typeOfNeededAnimal)
                {
                    if (variable.Age < min)
                    {
                        min = variable.Age;
                    }           
                }
            }
            return min;
        }
        public int FindMaxInListWithNeededType(string typeOfNeededAnimal)
        {
            int max = -10000;
            foreach (var variable in listA)
            {
                if (variable.kindofAnimal == typeOfNeededAnimal)
                {
                    if (variable.Age > max)
                        max = variable.Age;
                }
            }
            return max;
        }
   }
}

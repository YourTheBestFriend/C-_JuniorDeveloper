using System;
using System.Collections.Generic;
namespace домашние_животные
{
    class Person {
        public string name_owner;
        public List<Animal> list;

        public Person(string name_owner, List<Animal> list) {
            this.name_owner = name_owner;
            this.list = list;
        }

        public override string ToString()
        {
            string info = "";
            foreach (var item in list) {
                info += item.vid + "," + item.klichka + "," + item.age + "\n";
            }
            return $"\nИмя: {name_owner}\nЖивотные:\n{info}";
        }

         public int FindMinInListWithNeededType(string typeofneededanimal)
        {
            int min = 10000;
            foreach (var VARIABLE in list)
            {
                if (VARIABLE.vid == typeofneededanimal)
                {
                    if (VARIABLE.age < min)
                        min = VARIABLE.age;
                }
            }
            return min;
        }
        
        public int FindMaxInListWithNeededType(string typeofneededanimal)
        {
            int max = -10000;
            foreach (var VARIABLE in list)
            {
                if (VARIABLE.vid == typeofneededanimal)
                {
                    if (VARIABLE.age > max)
                        max = VARIABLE.age;
                }
            }
            return max;
        }
    }
}
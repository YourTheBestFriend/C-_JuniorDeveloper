using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классы
{
    class Phone
    {
        int number;
        string model;
        double weight;
        public Phone() {}

        public Phone(int number, string model)
        {
            this.number = number;
            this.model = model;
        }

        public Phone(int number, string model, double weight) : this(number, model)
        {
            this.weight = weight;
        }
        
        public void receiveCall(string name)
        {
            Console.WriteLine("Звонит = " + name);
        }
        // Перегрузка
        public void receiveCall(string name, int number)
        {
            Console.WriteLine("Звонит = " + name + " number = " + number);
        }
        public void sendMessage(int num_one_Call, int num_two_Call)
        {
            Console.WriteLine("Номер - " + num_one_Call + " звонит номеру - " + num_two_Call);
        }
        public void sendMessage(int num_one_Call, params int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"Номер - {num_one_Call} присылает рассылку {x[i]}");
            }
        }
        public int get_number()
        {
            return number;
        }
        public void show()
        {
            Console.WriteLine($"Show:\nnumber {number}\nmodel {model}\nweight {weight}\n");
        }
    }
}

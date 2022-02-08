using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_zarplata
{
    abstract internal class Worker
    {
        private string name;
        private int id;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Worker() { }
        public Worker(string name, int id)
        {
            Name = name;
            Id = id;
        }
        // abstract method 
        public abstract double returnSalary(); //  для расчета среднемесячной заработной платы
    }
}

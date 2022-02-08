using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_zarplata
{
    abstract internal class Worker : IComparable<Worker>,IComparer<Worker>
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

        public int Compare(Worker x, Worker y)
        {
            if (x.returnSalary() > y.returnSalary())
                return 1;
            else if (x.returnSalary() < y.returnSalary())
                return -1;
            else
                return 0;
        }

        public int CompareTo(Worker other)
        {
            return this.returnSalary().CompareTo(other.returnSalary());
        }
    }
}

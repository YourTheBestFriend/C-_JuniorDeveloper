using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_zarplata
{
    abstract internal class Worker : IComparable<Worker>//,IComparer<Worker>
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

        //public int Compare(Worker x, Worker y)
        //{
        //    if (x is null || y is null)
        //        throw new ArgumentException("Некорректное значение параметра");
        //    else
        //    {
        //        if ((int)x.returnSalary() > (int)y.returnSalary())
        //        {
        //            return 1;
        //        }
        //        else if ((int)x.returnSalary() < (int)y.returnSalary())
        //        {
        //            return -1;
        //        }
        //        else
        //        {
        //            // string str = @"абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        //            string str = @"abcdefghijklmnopqrstuvwxyz";
        //            // Для проверки
        //            if (str.IndexOf(x.Name.ToLower()[0]) > str.IndexOf(y.Name.ToLower()[0]))
        //            {
        //                return 1;
        //            }
        //            else if (str.IndexOf(x.Name.ToLower()[0]) < str.IndexOf(y.Name.ToLower()[0]))
        //            {
        //                return -1;
        //            }
        //        }
        //    }
        //    return 0;
        //}


        // Поменял знаки для убыванию 1 на -1 и -1 на 1
        public int CompareTo(Worker? y)
        {
            if ((int)returnSalary() > (int)y.returnSalary())
            {
                return -1;
            }
            else if ((int)returnSalary() < (int)y.returnSalary())
            {
                return 1;
            }
            else
            {
                // string str = @"абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                string str = @"abcdefghijklmnopqrstuvwxyz";
                // Для проверки
                if (str.IndexOf(Name.ToLower()[0]) > str.IndexOf(y.Name.ToLower()[0]))
                {
                    return -1;
                }
                else if (str.IndexOf(Name.ToLower()[0]) < str.IndexOf(y.Name.ToLower()[0]))
                {
                    return 1;
                }
            }
            return 0;  
            //return (int)returnSalary().CompareTo((int)other.returnSalary());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfece_2711
{
    class Class_Task3 : ICloneable // , IComparable
    {
        // например список кфадратов
        List<Kvadrat> listKvadrats;
        public Class_Task3() { }
        public Class_Task3(params Kvadrat[] x) 
        {
            for (int i = 0; i < x.Length; i++)
            {
                listKvadrats.Add(x[i]);
            }
        }
        // clone
        public object Clone()
        {
            return new Class_Task3 { listKvadrats = this.listKvadrats}; // return this.MemberwiseClone(); - Возвратит копию объекта
        }

        public void Sort_list()
        {
            this.listKvadrats.Sort();
        }
        //public int CompareTo(object obj)
        //{
        //    Class_Task3 ts = obj as Class_Task3;
        //    if (ts != null)
        //        return this.listKvadrats.CompareTo(ts.listKvadrats);
        //    else
        //        throw new Exception("Невозможно сравнить два объекта");
        //}

        // перебор через foreach 
        public void printForeachList()
        {
            foreach (Kvadrat i in this.listKvadrats)
            {
                Console.WriteLine($"Kvadrat line = {i.getLine()}");
            }
        }
        
	
    }
}

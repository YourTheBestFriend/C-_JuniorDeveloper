using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfece_2711
{
    class Class_Task3 : ICloneable, IEnumerable<Pramaugolnik>
    {
        // например список кфадратов
        List<Pramaugolnik> listPramaugolnik = new List<Pramaugolnik>();
        public Class_Task3() { }
        public void Add(Pramaugolnik pr)
        {
            listPramaugolnik.Add(pr);
        }
        public Class_Task3(params Pramaugolnik[] x) 
        {
            for (int i = 0; i < x.Length; i++)
            {
                listPramaugolnik.Add(x[i]);
            }
        }
        // clone
        public object Clone()
        {
            return new Class_Task3 { listPramaugolnik = this.listPramaugolnik }; // return this.MemberwiseClone(); - Возвратит копию объекта
        }

        // print 
        public void PrintList()
        {
            for (int i = 0; i < listPramaugolnik.Count; i++)
            {
                Console.WriteLine($"i = {i} - {listPramaugolnik[i]}");
            }
        }

        // for IComparable
        public void sortListPramaugolnik()
        {
            listPramaugolnik.Sort();
        }

        // for IComparer
        public void sortListPramaugolnik2()
        {
            listPramaugolnik.Sort(new Pramaugolnik());
        }

        public IEnumerator<Pramaugolnik> GetEnumerator()
        {
            return listPramaugolnik.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return listPramaugolnik.GetEnumerator();
        }
        // перебор через foreach 
        public void printForeachList()
        {
            foreach (var i in listPramaugolnik)
            {
                Console.WriteLine($"Kvadrat line = {i.getLine()}");
            }
        }
    }
}

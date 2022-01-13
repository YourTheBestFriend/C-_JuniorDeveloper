using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обобщения
{
    class Program
    {
        public class ClassList<T> where T : struct
        {
            private List<T> list = new List<T>();
            private IEnumerable<T> enumerable1;

            // индексатор
            //public List<T> this[int index]
            //{
            //    get => list_[index];
            //    set { list_[index] = value; }
            //}

            public List<T> List_
            {
                get => list;
                set { list = value; }
            }
            public ClassList(List<T> list)
            {
                this.list = list;
            }
            public ClassList(IEnumerable<T> enumerable1)
            {
                this.enumerable1 = enumerable1;
            }

            public static ClassList<T> operator +(ClassList<T> a, ClassList<T> b)
            {
                List<T> x = (List<T>)a.list;
                for (int i = 0; i < b.list.Count; i++)
                {
                    x.Add(b.list[i]);
                }
                return new ClassList<T>(x);
            }
            public static ClassList<T> operator -(ClassList<T> a, T index)
            {
                a.list.Remove(index);
                return new ClassList<T>(a.list);
            }

            public static bool operator ==(ClassList<T> a1, ClassList<T> a2)
            {
                return a1.list.SequenceEqual(a2.list);
            }

            public static bool operator !=(ClassList<T> a1, ClassList<T> a2)
            {
                return !a1.list.SequenceEqual(a2.list);
            }

            public static bool operator ~(ClassList<T> a) // Проверка на пустоту списка
            {
                return a.list.Any();
            }
            public void Print()
            {
                foreach (T x in List_)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
            public override bool Equals(object obj)
            {
                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (ReferenceEquals(obj, null))
                {
                    return false;
                }
                throw new NotImplementedException();
            }
            ~ClassList() { } // Деструктор
        }
        static void Main(string[] args)
        {
            ClassList<int> list1 = new ClassList<int>(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 });
            ClassList<int> list2 = new ClassList<int>(new List<int> { 5, 4, 3, 2, 1 });
            
            ClassList<int> list3 = list1 + list2; // Ошибка

            Console.Write("List 1: "); list1.Print();
            Console.Write("List 2: "); list2.Print();
            Console.Write("List 3: "); list3.Print();

            list3 -= 1; // Удалит первый лемент
            Console.Write("\nList 3: "); list3.Print();
            
            Console.WriteLine($"list3 == list2: {list3 == list2}");
            Console.WriteLine($"list3 != list2: {list3 != list2}"); 
        }
    }
}

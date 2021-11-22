using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классы
{
    public class Лр_1
    {
        int minut;
        int second;

        public Лр_1() { }
        public Лр_1(int minut, int second)
        {
            this.minut = minut;
            this.second = second;
        }
        public override string ToString()
        {
            return $"{minut:00}:{second:00}";
        }
        public int obsh_col_second() 
        {
            return minut * 60 + second;
        }
    }
    public class Лр_1_2
    {
        int hour;
        int minut;
        int second;

         Лр_1_2(int i) { minut = i; }
        public static Лр_1_2 F(int i)
        {
            Console.WriteLine($"object {i} creates ");
            return new Лр_1_2(i);
        }
        public Лр_1_2(int hour, int minut, int second)
        {
            this.hour = hour;
            this.minut = minut;
            this.second = second;
        }

        public void colvo_minut_do_polunochi()
        {
            Console.WriteLine((24-hour) * 60 + minut + second / 60);
        }
        public void plus_100_min()
        {
            int k = 60 - minut;
            hour += (100 - k) / 60;
            minut += k;
        }
        ~Лр_1_2() { Console.WriteLine($"delete object {minut}"); }
    }
}

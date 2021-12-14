using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace исключения_2_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Reis rs1 = new Reis(1, "standart", "minsk" ,"12:43", "13:20");
            Reis rs2 = new Reis(2, "standart", "sitniki" ,"11:12", "12:40");
            Reis rs3 = new Reis(3, "elit", "minsk", "10:25", "11:25");
            Reis rs4 = new Reis(4, "standart", "minsk", "09:10", "14:20");
            Reis rs5 = new Reis(5, "elit", "minsk", "08:05", "09:30"); // Сделать исключения елсли вводится не 09:25 а 9:25

            List<Reis> lst1 = new List<Reis>();
            lst1.Add(rs1);
            lst1.Add(rs2);
            lst1.Add(rs3);
            lst1.Add(rs4);
            lst1.Add(rs5);

            SpravochSystem listSprav = new SpravochSystem(lst1);
            listSprav.printReisTime(30, "minsk");
        }
    }
}

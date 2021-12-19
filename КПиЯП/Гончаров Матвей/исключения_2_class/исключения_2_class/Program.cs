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
            List<Reis> lst1 = new List<Reis>();
            try
            {
                Reis rs1 = new Reis(1, "standart", "minsk", "12:43", "13:20");
                Reis rs2 = new Reis(2, "standart", "sitniki", "11:12", "12:40");
                Reis rs3 = new Reis(3, "elit", "minsk", "90:25", "11:25"); // 90:25 не может быть
                Reis rs4 = new Reis(4, "standart", "minsk", "09:10", "14:20");
                Reis rs5 = new Reis(5, "elit", "minsk", "08:05", "09:30"); 

                if (rs1.NumberReisa < 0 || rs2.NumberReisa < 0 || rs3.NumberReisa < 0 || rs4.NumberReisa < 0 || rs5.NumberReisa < 0)
                {
                    throw new SpravochSystemException("Номер рейса не может быть < 0");
                }
                else
                {
                    lst1.Add(rs1);
                    lst1.Add(rs2);
                    lst1.Add(rs3);
                    lst1.Add(rs4);
                    lst1.Add(rs5);
                }

                SpravochSystem listSprav = new SpravochSystem(lst1);
                listSprav.printReisTime(70, "minsk"); // 70 минут
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (SpravochSystemException ex2)
            {
                Console.WriteLine("Ошибка: " + ex2.Message);
            }
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1_Drinks_And_Builder_14_03_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            // drinks task
            Console.WriteLine("TASK 1");
            Napitok napitok = new Napitok(new LemonadeWithCognac());
            napitok.AlDrinks = new Koniac("Коньяк", 1, 15, "КоньякТвояСвежесть");
            napitok.Drinks = new Lemonade("Лемонад", "ЛемонадВетер", 1);
            Console.WriteLine("Смешиваем:");
            napitok.Structure();

            // indevidual task - pattern builder
            /*
                        Как работает pattern builder
                        Как я понял - Создание объекта, только в разной форме (представлении) 
                        - в итоге у нас все равно получится машина как в моем такске, но она имеет разную форму - на заказ или серийная. 
                        Тоесть на заказ например таже машина как серийная только с дополнительными плюшками например, но сути создания объекта не меняет это в любом случае машина

             */

            Console.WriteLine("\nTASK 2");
            // class for create diffrent auto
            AutoType avtoMeh = new AutoType();
            // for realization pattern builder
            AvtoBuilder builder = new SeriyaAvtoBuilder();
            Avto SeriynoeAvto = avtoMeh.Bake(builder);
            // check info
            Console.WriteLine(SeriynoeAvto.ToString());
            // give new 
            builder = new ZakazAvtoBuilder();
            Avto ZakarnoeAvto = avtoMeh.Bake(builder);
            // check info
            Console.WriteLine(ZakarnoeAvto.ToString());
        }
    }
}
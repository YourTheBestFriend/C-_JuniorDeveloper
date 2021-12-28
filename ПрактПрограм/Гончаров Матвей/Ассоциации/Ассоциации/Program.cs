using System;

namespace Ассоциации
{
    class Program
    {
        static void Main(string[] args)
        {
            // Общий товар
            Item cherry = new Item("Article_10", "Cherry", 1501); // 1501 - для демонстрации с надбавкой

            // Кол-во
            OrderLine ordl_cherry = new OrderLine(1, cherry); // 1 Вишня 
            //// 

            // я и в классе есть поле заказ
            Customer Matvey = new Customer(1, 299745334, "GoncharovMatveyNickolaevich", true); // ord1
            
            // Мой товар
            //Item banan = new Item("Article_1", "Banana", 20.4);

            // Кол-во
            //OrderLine ordl = new OrderLine(10, banan); // 10 бананов

            // Заказ
            DateTime create_date = new DateTime(2021, 01, 01); // Дата к нему
            Order ord1 = new Order(1, create_date, "Prititskogo", true, Matvey, ordl_cherry); //  ordl, ordl_cherry

            Console.WriteLine(ord1);

            //// я и в классе есть поле заказ
            //Customer David = new Customer(2, 294563445, "DavidOrlisDenisovich", true); // ord2 banana cherry
           
            //// Мой товар
            //Item orange = new Item("Article_2", "orange", 19.8);

            //// Кол-во
            //OrderLine ordl2 = new OrderLine(4, orange); 
          
            //Order ord2 = new Order(2, create_date, "Masherova", true, David, ordl2, ordl_cherry); // orange cherry

            //Console.WriteLine(ord2);
            // 

            ord1.PrintQuantityItemAndItem();
            //ord2.printQuantityItemAndItem();
        }
    }
}

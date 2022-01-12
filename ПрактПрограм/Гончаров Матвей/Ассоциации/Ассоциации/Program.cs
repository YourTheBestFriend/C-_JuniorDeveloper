using System;
using My_The_Best_Libruary; // Подключил

namespace Ассоциации
{
    class Program
    {
        static void Main(string[] args)
        {
            // я потестил как вы просили 
            /*
             Одна вишня стоит 100
             Всего 10 вишень   
             Стоимость - 1000

             Для проверки процентов надо 1501

             Например создал еще апельсин orange 125  
             Всего 7 апельсинов
             Стоимость - 875

                Это должно получится если пользователь ExpressDelivery == True and customer.Privileged == true && this.TotalCost > 1500
                Если это эксперсс доставка, пользаватель привилегированный и общая стоимость товара превышает 1500
                
                Общая стоимость 1593 // 1875 - 15% из-за срочной доставки = (15% = 281.25) == 1875 - 281.25 = 1593
                25% =  398,43 // Это уже т.к привелигированный и TotalCost > 1500
                Итоговая сумма с надбавкой = 1992,1875
            */

            // Общий товар
            Item cherry = new Item("Article_10", "Cherry", 100);
            Item orange = new Item("Article_11", "orange", 125);

            // Кол-во
            OrderLine ordl_cherry = new OrderLine(10, cherry); // 10 Вишень 
            OrderLine ordl_orange = new OrderLine(7, orange); // 7 Апельсинов

            // я и в классе есть поле заказ
            Customer Matvey = new Customer(1, 299745334, "GoncharovMatveyNickolaevich", true);
           
            // Заказ
            DateTime create_date = new DateTime(2021, 01, 01); // Дата к нему
            Order ord1 = new Order(1, create_date, "Prititskogo", true, Matvey, ordl_cherry, ordl_orange); //  - ordl -  (ordl_cherry, ordl_orange)

            Console.WriteLine(ord1);
            ord1.PrintQuantityItemAndItem();
        }
    }
}


/*
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
*/
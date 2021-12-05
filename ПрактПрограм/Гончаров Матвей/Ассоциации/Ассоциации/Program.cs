using System;

namespace Ассоциации
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer Matvey = new Customer(1, 299745334, "GoncharovMatveyNickolaevich", true);

            // Заказ
            DateTime create_date = new DateTime(2021, 01, 01);
            Order ord1 = new Order(Matvey.Code, create_date, "Prititskogo", true);

        }
    }
}

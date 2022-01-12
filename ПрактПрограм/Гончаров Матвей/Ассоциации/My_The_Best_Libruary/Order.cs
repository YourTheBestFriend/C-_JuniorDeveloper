using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_The_Best_Libruary
{
    public class Order
    {
        public int Number;
        public DateTime CreationDate;
        public string Address;
        public bool ExpressDelivery;

        // Если заказ строчный - высчитываю 25% отдельно, т.к стоимость заказа может варьироваться
        public double present25;
        
        public double TotalCost;

        public Customer customer = new Customer();

        // Тут кол-во заказов
        public List<OrderLine> ordl = new List<OrderLine>();

        public Order(int Number, DateTime CreationDate, string Address, bool ExpressDelivery, Customer customer, params OrderLine[] ordl_)
        {
            this.Number = Number;
            this.CreationDate = CreationDate;
            this.Address = Address;
            this.ExpressDelivery = ExpressDelivery;

            //this.TotalCost = TotalCost;
            this.customer = customer;
            for (int i = 0; i < ordl_.Length; i++)
            {
                this.ordl.Add(ordl_[i]); // new OrderLine(ordl_[i].it
                this.TotalCost += ordl_[i].Cost; // Общая стоимость
            }
            IfPrivilegCustomer();
            IfQuickDelivery();
        }
        // 
        public void PrintQuantityItemAndItem()
        {
            //cout << "" << endl;
            Console.WriteLine("[Товары]");
            int i = 0;
            foreach (var item in ordl)
            {
                Console.WriteLine($"index = [{i++}] quantity = {item.GetQuantity()}, cost = {item.GetCost()}, {item.PrintItem()}");
            }
        }

        // Если срочная доставка
        public void IfQuickDelivery()
        {
            double rezerve; // 25% от общего
            // Если пользователь привелигированный то стоимость увеличится на 25% 
            if (this.ExpressDelivery == true)//&& this.TotalCost > 1500)
            {
                //Console.WriteLine("Сработал метод Доставка срочная");
                //   for (int i = 0; i < ordl_.Length; i++)
                {
                    rezerve = this.TotalCost * 25 / 100;
                    this.present25 = rezerve;
                }
            }
            Console.WriteLine($"\n[Тут вывод из фунуции IfQuickDelivery() для проверки]\nTotalCost = {this.TotalCost}, precent25 = {this.present25}, TotalCost + present25 = {this.TotalCost + this.present25}.\n");
        }
        // Если привелигированный
        public void IfPrivilegCustomer()
        {
            double rezerve;
            if (customer.Privileged == true && this.TotalCost > 1500)
            {
                Console.WriteLine("Сработал метод IfPrivilegCustomer");
                rezerve = this.TotalCost * 15 / 100;
                this.TotalCost -= rezerve;
            }
        }

        // Функция для добавления \ удаления элементов
        public void AddOrRemoveItem()
        {
            // Какой заказ и его кол-во
            int j;
            try
            {
                Console.Write("Input номер заказа: ");
                j = Convert.ToInt32(Console.ReadLine());

                int p;
                while (true)
                {
                    Console.WriteLine("1 - Изменение Quantity");

                    Console.Write("Выберите пункт: ");
                    p = Convert.ToInt32(Console.ReadLine());

                    if (p == 1)
                    {
                        Console.Write("Введите новое значение Quantity: ");
                        ordl[j].Quantity = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error = {ex.Message}");
            }
        }

        public double GetTotalCost()
        {
            return TotalCost;
        }
        public override string ToString() => $"Total cost = {this.TotalCost} || Customer :: FullName: [{customer.FullName}], " +
            $"Privileged: {customer.Privileged}, || Order :: ExpressDelivery: {this.ExpressDelivery}";
        // Минимально вывел, а то вы сказали прошлый раз было нагружено
        //public override string ToString() => $"Total cost = {this.TotalCost} || Customer :: Code: {customer.Code}, " +
        //    $"ContactPhone: {customer.ContactPhone}, FullName: {customer.FullName}, " +
        //    $"Privileged: {customer.Privileged}, || Order :: Adress: {this.Address}, " +
        //    $"CreationDate: {this.CreationDate}, ExpressDelivery: {this.ExpressDelivery}, Number: {this.Number}";
    }
}

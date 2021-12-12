using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ассоциации
{
    public class Order
    {
        public int Number;
        public DateTime CreationDate;
        public string Address;
        public bool ExpressDelivery;

        public double TotalCost;

        public Customer customer = new Customer();

        // Тут кол-во заказов
        public List<OrderLine> ordl = new List<OrderLine>();

        //public Order(){ }
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
           
            double rezerve = 0; // 25% от общего
            // Если пользователь привелигированный то стоимость увеличится на 25% 
            if (this.ExpressDelivery == true )//&& this.TotalCost > 1500)
            {
             //   for (int i = 0; i < ordl_.Length; i++)
                {
                    rezerve = this.TotalCost * 25 / 100;
                    this.TotalCost += rezerve;
                }
            }
            rezerve = 0;
            if (customer.Privileged == true && this.TotalCost > 1500)
            {
                rezerve = this.TotalCost * 15 / 100;
                this.TotalCost -= rezerve;
            }
        }

        // 
        public void printQuantityItemAndItem()
        {
            //cout << "" << endl;
            int i = 0;
            foreach (var item in this.ordl)
            {
                Console.WriteLine($"index = {i++} === quantity = {item.getQuantity()}, cost = {item.getCost()}, for Item __ {item.printItem()}");
            }
        }
        //

        double GetTotalCost()
        {

            return TotalCost;
        }
        public override string ToString() => $"__Total cost = {this.TotalCost}____Customer :: Code: {customer.Code}, " +
            $"ContactPhone: {customer.ContactPhone}, FullName: {customer.FullName}, " +
            $"Privileged: {customer.Privileged},\nOrder :: Adress: {this.Address}, " +
            $"CreationDate: {this.CreationDate}, ExpressDelivery: {this.ExpressDelivery}, Number: {this.Number}";

    }
}

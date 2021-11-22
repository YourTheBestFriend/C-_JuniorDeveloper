using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классы
{

    public class PRICE
    {
        private string name_price; // { get; set; }
        private string name_store; // { get; set; }
        private double money; //{ get; set; }
        public PRICE() { }
        public PRICE(string name_price, string name_store, double money)
        {
            this.name_price = name_price;
            this.name_store = name_store;
            this.money = money;
        }
        public void show()
        {
            Console.WriteLine($"name_price = {name_price}\name_store = {name_store}\nmoney = {money}");
        }
        // get
        public string get_name_price()
        {
            return name_store;
        }
        public string get_name_store()
        {
            return name_price;
        }
        public double get_money()
        {
            return money;
        }
        // set 
        public void set_name_price(string name_store)
        {
            this.name_store = name_store;
        }
        public void set_name_store(string name_price)
        {
            this.name_price = name_price;
        }
        public void set_money(double money)
        {
            this.money = money;
        }

        public void stoim(string s)
        {
            if (string.Compare( name_price,s,true)==0) // бе учета регистра
            {
                Console.WriteLine($"stoimost = {money:C}");
            }
            else
            {
                Console.WriteLine("name_price не совпал");
            }
        }
    }
}

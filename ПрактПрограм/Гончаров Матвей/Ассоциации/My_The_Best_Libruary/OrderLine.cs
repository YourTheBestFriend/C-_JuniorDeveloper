using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_The_Best_Libruary
{
    public class OrderLine
    {
        public int Quantity = 1;
        public double Cost = 14.5;
      
        public Item It { get; set; }

        public OrderLine(Item i)
        {
            It = new Item(i.Article, i.Name, i.UnitPrice);
            
            this.Cost = i.UnitPrice * Quantity;
        }
        public OrderLine(int Quantity, Item i)
        {
            It = new Item(i.Article, i.Name, i.UnitPrice);
            this.Quantity = Quantity;
            this.Cost = i.UnitPrice * Quantity;
        }
        // Я просто чекал, я знаю как писать свойства по другому, я прост это написал то того как начал юзать их
        public int GetQuantity()
        {
            return Quantity;   
        }
        public double GetCost()
        {
            return Cost;
        }

        public void SetQuantity(int Quantity)
        {
            this.Quantity = Quantity;
        }
        public void SetCost(double Cost)
        {
            this.Cost = Cost;
        }

        public string PrintItem()
        {
            return $"{{ Item: Article {It.Article}., Name {It.Name}, UnitPrice {It.UnitPrice}}}";
        }
    }
}

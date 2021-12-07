using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ассоциации
{
    public class OrderLine
    {
        public int Quantity = 1;
        public double Cost = 14.5;

        //public OrderLine() { }
        public Item it { get; set; }

        public OrderLine(Item i)
        {
            it = new Item(i.Article, i.Name, i.UnitPrice);
            this.Cost = i.UnitPrice * Quantity;
        }
        public OrderLine(int Quantity, Item i)
        {
            it = new Item(i.Article, i.Name, i.UnitPrice);
            this.Quantity = Quantity;
            this.Cost = i.UnitPrice * Quantity;
        }

        public int getQuantity()
        {
            return Quantity;   
        }
        public double getCost()
        {
            return Cost;
        }

        public void setQuantity(int Quantity)
        {
            this.Quantity = Quantity;
        }
        public void setCost(double Cost)
        {
            this.Cost = Cost;
        }

        public string printItem()
        {
            return $"{{ Item: Article {it.Article}., Name {it.Name}, UnitPrice {it.UnitPrice}}}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_The_Best_Libruary
{
    public class Item
    {
        public string Article;
        public string Name;
        public double UnitPrice = 10.4;

        public Item(string Article, string Name, double UnitPrice) 
        {
            this.Article = Article;
            this.Name = Name;
            this.UnitPrice = UnitPrice;
        }
    }
}

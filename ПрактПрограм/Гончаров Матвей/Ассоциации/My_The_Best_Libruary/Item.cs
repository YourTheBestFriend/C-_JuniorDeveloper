using System;

namespace My_The_Best_Libruary
{
    [Serializable]
    public class Item
    {
        public string Article;
        public string Name;
        public double UnitPrice = 10.4;
        public Item() { }
        public Item(string Article, string Name, double UnitPrice) 
        {
            this.Article = Article;
            this.Name = Name;
            this.UnitPrice = UnitPrice;
        }
    }
}

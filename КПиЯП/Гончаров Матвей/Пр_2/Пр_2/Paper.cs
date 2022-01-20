using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Практика_2
{
    public class Paper
    {
        public string cardName { get; set; }
        public Personn cardAuthor { get; set; }
        public DateTime cardDate { get; set; }

        public Paper(string cardName, Personn cardAuthor, DateTime cardDate)
        {
            this.cardName = cardName;
            this.cardAuthor = cardAuthor;
            this.cardDate = cardDate;
        }
        public Paper()
        {
            cardName = "none";
            cardAuthor = new Personn();
            cardDate = DateTime.Today;
        }
        public virtual object DeepCopy()
        {
            return "DeepCopy";
        }
        public override string ToString() => $"Название публикации: {cardName}\nАвтор публикации: {cardAuthor}\nДата публикации: {cardDate.ToShortDateString()}";
    }
}

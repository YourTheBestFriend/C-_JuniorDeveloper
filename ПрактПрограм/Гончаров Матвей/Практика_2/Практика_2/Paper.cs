using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2
{
    class Paper
    {
        public string name_publ { get; set; }
        public Person author { get; set; }
        public DateTime date_public { get; set; }

        public Paper(string name_publ, Person author, DateTime date_public)
        {
            this.name_publ = name_publ;
            this.author = author;
            this.date_public = date_public;
        }

        public Paper()
        {
            name_publ = "none";
            author = new Person();
            date_public = new DateTime();
        }

        public override string ToString()
        {
            return name_publ + " " + author.getName() + " " + author.getSurName() + " " + "date class person: " + author.getDateTime() + " date class Paper: " + date_public.ToString();
        }
    }
}

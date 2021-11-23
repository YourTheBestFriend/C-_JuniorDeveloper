using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классы
{
    public class date_7_task
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public date_7_task() { }
        public date_7_task(int year, int month, int day) 
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public date_7_task(DateTime x)
        {
            this.year = x.Year;
            this.month = x.Month;
            this.day = x.Day;
        }

        public void add_day(int x)
        {
            if (this.day + x < 32)
            {
                this.day += x;
            }
        }
        public void minus_day(int x)
        {
            if (this.day - x > 0)
            {
                this.day -= x;
            }
        }
        public bool eql_date(date_7_task a, date_7_task b)
        {
            if (a.day != b.day || a.month != b.month || a.year != b.year)
            {
                return false;
            }
            return true;
        }
        public int promezh_day(int day)
        {
            return Abs(this.day-day);
        }
        public override string ToString()
        {
            return $"{day:00}.{month:00}.{year:0000}";
        }
    }
}

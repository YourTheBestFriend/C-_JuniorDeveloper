using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1_Drinks_And_Builder_14_03_2022
{
    class Milk : Drinks
    {
        private double Fattiness { get; set; }

        public Milk(double fattiness,string name,double volume) : base(name,volume)
        {
            this.Fattiness = fattiness;
        }

        public override void TypeDrink() => Console.WriteLine($"Это молоко. Жирность: {Fattiness}");
    }
}

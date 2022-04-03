using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1_Drinks_And_Builder_14_03_2022
{
    class Beer : AlcoholicDrinks
    {
        private string TypeBeer { get; set; }

        public Beer(string name, double volume, double degreeAlcohol, string typeBeer) : base (name,volume,degreeAlcohol)
        {
            this.TypeBeer = typeBeer;
        }
        public override void TypeAlcoholicDrink() => Console.WriteLine("Это пиво");
    }
}

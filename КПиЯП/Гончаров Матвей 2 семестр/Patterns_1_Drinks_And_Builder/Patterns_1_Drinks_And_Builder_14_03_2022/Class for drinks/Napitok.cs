using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1_Drinks_And_Builder_14_03_2022
{
    class Napitok
    {
        public AlcoholicDrinks AlDrinks { get; set; }
        public Drinks Drinks { get; set; }

        public Napitok(BottleFactory factory)
        {
            AlDrinks = factory.alcDrink();
            Drinks = factory.drink();
        }
        public void Structure()
        {
            AlDrinks.TypeAlcoholicDrink();
            Drinks.TypeDrink();
        }
    }
}

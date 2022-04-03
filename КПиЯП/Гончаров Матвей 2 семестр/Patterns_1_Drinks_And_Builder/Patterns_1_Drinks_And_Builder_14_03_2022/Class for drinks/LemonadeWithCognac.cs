using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1_Drinks_And_Builder_14_03_2022
{
    internal class LemonadeWithCognac : BottleFactory
    {
        public override AlcoholicDrinks alcDrink() 
        {
            return new Koniac();
        }
        public override Drinks drink()
        {
            return new Lemonade();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1_Drinks_And_Builder_14_03_2022
{
    abstract class BottleFactory
    {
        public abstract AlcoholicDrinks alcDrink();
        public abstract Drinks drink();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1_Drinks_And_Builder_14_03_2022
{
    class AutoType // Реализация создания машины через паттерн, который позволяет создать разное предстовление машины
    {
        public Avto Bake(AvtoBuilder avtoBuilder)
        {
            avtoBuilder.CreateAvto();
            avtoBuilder.SetDvigatel();
            avtoBuilder.SetAudioSystem();
            return avtoBuilder.Avto;
        }
    }
}

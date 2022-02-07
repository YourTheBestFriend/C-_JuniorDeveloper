using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование_07_02_2022
{
    sealed internal class RB : Respublica // sealed - показывает без плодность класса 
    {
        public RB(string name, string denezhnayaEden, string simvolika, string vid, string pravitelstvo) : base(name, denezhnayaEden, simvolika, vid, pravitelstvo) { }
    }
}

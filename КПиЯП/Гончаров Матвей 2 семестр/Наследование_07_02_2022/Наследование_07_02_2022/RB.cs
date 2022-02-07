using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование_07_02_2022
{
    sealed internal class RB : Respublica // sealed - показывает без плодность класса 
    {
        //public RB()
        //{
        //}

        public RB(int x, string name, string denezhnayaEden, string simvolika) : base(x, name, denezhnayaEden, simvolika)
        {
        }
    }
}

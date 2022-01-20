using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2
{
    interface INameAndCopy
    {
        string name { get; set; }
        object DeepCopy();
    }
}

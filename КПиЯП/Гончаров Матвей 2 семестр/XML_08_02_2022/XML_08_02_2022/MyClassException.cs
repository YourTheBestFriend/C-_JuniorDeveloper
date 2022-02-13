using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_08_02_2022
{
    class MyClassException : Exception
    {
        public MyClassException(string message) : base(message) { }
    }
}

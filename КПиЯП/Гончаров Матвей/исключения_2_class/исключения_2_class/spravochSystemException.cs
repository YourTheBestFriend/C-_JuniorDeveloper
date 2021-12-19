using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace исключения_2_class
{
    class SpravochSystemException : Exception
    {
        public SpravochSystemException(string message) : base(message) { }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatesobitia
{
    class Task3
    {
        public Task3() { }

        public string FullName(string[] name)
        {
            return $"{name[0]} {name[1][0]}.{name[2][0]}.";
        }
        public string Name(string[] name)
        {
            return $"{name[0]} {name[1]}";
        }
    }
}

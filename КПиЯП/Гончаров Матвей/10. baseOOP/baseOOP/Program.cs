using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********1*********");
            Massa Gramm = Massa.SetGrammMass(200);

            Console.WriteLine(Gramm);
            Console.WriteLine("*********2*********");
            Massa Funt = Massa.SetFuntMass(200);
            Console.WriteLine(Funt);
            Console.WriteLine("*********3*********");
            Massa Unic = Massa.SetUnicMass(200);
            Console.WriteLine(Unic);
          
            
            Console.WriteLine(Gramm.Add(Funt));
            Console.WriteLine(Gramm.Sub(Funt));

            Console.WriteLine(Funt.Add(Massa.SetFuntMass(2)));
            Console.WriteLine(Funt.Sub(Massa.SetFuntMass(1)));
            
            Console.WriteLine(Funt.Add(Massa.SetUnicMass(1)));
            Console.WriteLine(Funt.Sub(Massa.SetUnicMass(1)));
        }
    }
}

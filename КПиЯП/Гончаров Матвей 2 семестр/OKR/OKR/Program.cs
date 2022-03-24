using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace OKR
{
    class Program
    {
        public static void Main()
        {
            // string FIO, string Fakultet, int kurs, int minmark
            // 1
            Student student = new Student("FIOStudent", "SysFakultet", 2, 7);
            Console.WriteLine(student);

            // 2
            StudentKontraktnik studentKontraktnik1 = new StudentKontraktnik("GoncharovMatveyNickolaevich", "POIT", 3, 7, true);
            StudentKontraktnik studentKontraktnik2 = new StudentKontraktnik("OrlisDavidDenisovich", "POIT", 3, 8, false);
            Console.WriteLine(studentKontraktnik1);
            Console.WriteLine(studentKontraktnik2);

            // 3
            student.PerevestiOnNextKurs();
            studentKontraktnik1.PerevestiOnNextKurs();
            studentKontraktnik2.PerevestiOnNextKurs();

            // 4
            Console.WriteLine("============");
            Console.WriteLine(student);
            Console.WriteLine(studentKontraktnik1);
            Console.WriteLine(studentKontraktnik2);

        }
    }
}
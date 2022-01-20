using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2
{
    public enum TimeFrame
    {
        Year = 0,
        TwoYears = 1,
        Long = 2
    }
    public class Program
    {
        static void Main(string[] args)
        {
            ResearchTeam r = new ResearchTeam("ResearchTeam_1", TimeFrame.TwoYears);
            r.CardList = new ArrayList();
            r.HumList = new ArrayList();
            Personn per1 = new Personn("Matvey", "Goncharov", new DateTime(2001, 3, 13));
            Personn per2 = new Personn("Artem", "Zelenok", new DateTime(2000, 2, 10));
            Paper p1 = new Paper();
            Paper p2 = new Paper("Paper", per2, new DateTime(2015, 9, 8));
            r.AddMembers(per1, per2);
            r.AddPapers(p1, p2);
            
            Console.WriteLine(r.Team);
            Console.WriteLine();
            Console.WriteLine(r);
            Console.WriteLine();

            Console.WriteLine("_____________________________________________________");


            ResearchTeam rc = (ResearchTeam)r.DeepCopy();
            r.ResearchTopic = "ResearchTeam_1_______Epam";
            r.ResearchDuration = TimeFrame.Long;
            
            Console.WriteLine(r);
            Console.WriteLine();
            Console.WriteLine(rc);
            Console.WriteLine();
            Console.WriteLine(per1.GetHashCode());

            foreach (Personn pers in r.PerWithoutPub())
            {
                Console.WriteLine(pers);
            }
            Console.WriteLine();
            foreach (Paper pap in r.LastPaper(10))
            {
                Console.WriteLine(pap);
            }
            Console.ReadKey();
        }
    }
}

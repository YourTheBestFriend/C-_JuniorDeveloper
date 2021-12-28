using System;
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
    class Program
    {
        static void Main(string[] args)
        {
            ResearchTeam obj1 = new ResearchTeam();
            Console.WriteLine(obj1.ToShortString());
            Console.WriteLine(obj1.Get_prodolzh_issled());
            // string tema_inssle, string name_organization, int registr_num, TimeFrame prodolzh_issled, Paper[] list_publicacii
            TimeFrame x = 0;
            Console.WriteLine();

            int f = 5;
            Paper[] pap = new Paper[f];
            for (int i = 0; i < f; i++)
            {
                pap[i] = new Paper();
            }
            for (int i = 0; i < pap.Length; i++)
            {
                pap[i].author.setName("author" + Convert.ToString(i));
                pap[i].author.setSurName("serauthor" + Convert.ToString(i));
            }
            //obj1 = new ResearchTeam("tema_animal", "doragh", 12, x, pap);
            //Console.WriteLine(obj1.ToString());
            //Console.WriteLine(obj1);
            
            // for paper
            int time1 = Environment.TickCount;
            // ar1
            int row = 5;
            int col = 10;
            Paper[] ar = new Paper[row * col];
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = new Paper();
            }

            // Заполнение 
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i].name_publ = "public_" + Convert.ToString(i);
                ar[i].date_public = new DateTime(2000+i, 04, 3);
                ar[i].author.setName("Author_" + Convert.ToString(i));
                ar[i].author.setSurName("SurAuthor_" + Convert.ToString(i));
                DateTime ggh = new DateTime(2004+i, 08, 22);
                ar[i].author.setDateTime(ggh);
            }
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i].ToString());
            }
            
            int time2 = Environment.TickCount;
            Console.WriteLine("\ntime1 = " + (time2 - time1));

            int time3 = Environment.TickCount;
            // ar2
            Paper[,] ar2 = new Paper[row, col];
            for (int i = 0; i < ar2.GetLength(0); i++)
            {
                for (int j = 0; j < ar2.GetLength(1); j++)
                {
                    ar2[i, j] = new Paper();
                }
            }
            // Заполнение 
            for (int i = 0; i < ar2.GetLength(0); i++)
            {
                for (int j = 0; j < ar2.GetLength(1); j++)
                {
                    ar2[i,j].name_publ = "public_" + Convert.ToString(i);
                    ar2[i,j].date_public = new DateTime(2000 + i, 04, 3);
                    ar2[i,j].author.setName("Author_" + Convert.ToString(i));
                    ar2[i,j].author.setSurName("SurAuthor_" + Convert.ToString(i));
                    DateTime ggh = new DateTime(2004 + i, 08, 22);
                    ar2[i,j].author.setDateTime(ggh);
                }
            }
            for (int i = 0; i < ar2.GetLength(0); i++)
            {
                for (int j = 0; j < ar2.GetLength(1); j++)
                {
                    Console.WriteLine(ar2[i,j].ToString());
                }
            }
            int time4 = Environment.TickCount;
            Console.WriteLine("\ntime2 = " + (time4- time3));

            int time5 = Environment.TickCount;
            
            Paper[][] ar3 = new Paper[ar2.GetLength(0)][];
            for (int i = 0; i < ar2.GetLength(0); i++)
            {
                ar3[i] = new Paper[ar2.GetLength(1)];
               
                for (int j = 0; j < ar2.GetLength(1); j++)
                {
                    ar3[i][j] = new Paper();
                }
            }
            
            int time6 = Environment.TickCount;
            Console.WriteLine("\ntime3 = " + (time6-time5));

        }
    }
}

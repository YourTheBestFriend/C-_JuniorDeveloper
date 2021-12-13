using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_11_классы_вариант_6
{
    class Series : IComparer<Parallepiped>, IComparer<Cone>, IComparer<Ball>
    {
        // Список Параллелограммов
        private List<Parallepiped> listParalip = new List<Parallepiped>();
        
        public List<Parallepiped> ListParalip
        {
            get => listParalip;
        }

        // Список Конусов
        private List<Cone> listCone = new List<Cone>();
        public List<Cone> ListCone
        {
            get => listCone;
        }
        // Список Шаров 
        private List<Ball> listBall = new List<Ball>();
        public List<Ball> ListBall
        {
            get => listBall;
        }
        public Series(List<Parallepiped> listParalip, List<Cone> listCone, List<Ball> listBall)
        {
            this.listParalip = listParalip;
            this.listCone = listCone;
            this.listBall = listBall;
        }
        public void Display()
        {
            Console.WriteLine($"listParalip data:");
            for (int i = 0; i < listParalip.Count; i++)
            {
                Console.WriteLine($"paralip[{i}]: lineA = {listParalip[i].LineA}");
            }
            Console.WriteLine($"\nlistCone data:");
            for (int i = 0; i < listCone.Count; i++)
            {
                Console.WriteLine($"listCone[{i}]: lineA = {listCone[i].LineA}");
            }
            Console.WriteLine($"\nlistBall data:");
            for (int i = 0; i < listBall.Count; i++)
            {
                Console.WriteLine($"listBall[{i}]: lineA = {listBall[i].LineA}");
            }
        }

        public int Compare(Parallepiped x, Parallepiped y)
        {
            if (x.LineA > y.LineA)
            {
                return 1;
            }
            else if (x.LineA < y.LineA)
            {
                return -1;
            }
            return 0;
        }

        public int Compare(Cone x, Cone y)
        {
            if (x.LineA > y.LineA)
            {
                return 1;
            }
            else if (x.LineA < y.LineA)
            {
                return -1;
            }
            return 0;
        }

        public int Compare(Ball x, Ball y)
        {
            if (x.LineA > y.LineA)
            {
                return 1;
            }
            else if (x.LineA < y.LineA)
            {
                return -1;
            }
            return 0;
        }
    }
}

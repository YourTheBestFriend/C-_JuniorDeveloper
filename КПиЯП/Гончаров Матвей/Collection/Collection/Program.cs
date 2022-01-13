using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        // 11111111111111111111111111111111111 function
        static int Priority(string c)
        {
            if (c == "^")
            {
                return 3;
            }
            else if (c == "*" || c == "/")
            {
                return 2;
            }
            else if (c == "+" || c == "-")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static bool isOperator(string c)
        {
            if (c == "+" || c == "-" || c == "*" || c == "/" || c == "^")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 222222222222222222222222222 function
        struct Member
        {
            public string surname { get; set; }
            public string name { get; set; }
            public string patronymic { get; set; }
            public string sex { get; set; }
            public string age { get; set; }
            public string salary { get; set; }
            public override string ToString()
            {
                return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                    surname,
                    name,
                    patronymic,
                    sex,
                    age,
                    salary);
            }
        }
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////// 111111111111111111111111111111111111
            Console.WriteLine("Task 1");
           
            // string infix = "3 ^ 4 + ( 11 - ( 3 * 2 ) ) / 2";

            string infix = "3 + 2";
            string[] tokens = infix.Split(' ');

            Stack<string> s = new Stack<string>();
            List<string> outputList = new List<string>();
            int n;
            foreach (string c in tokens)
            {
                if (int.TryParse(c.ToString(), out n))
                {
                    outputList.Add(c);
                }
                if (c == "(")
                {
                    s.Push(c);
                }
                if (c == ")")
                {
                    while (s.Count != 0 && s.Peek() != "(")
                    {
                        outputList.Add(s.Pop());
                    }
                    s.Pop();
                }
                if (isOperator(c) == true)
                {
                    while (s.Count != 0 && Priority(s.Peek()) >= Priority(c))
                    {
                        outputList.Add(s.Pop());
                    }
                    s.Push(c);
                }
            }
            while (s.Count != 0) //if any operators remain in the stack, pop all & add to output list until stack is empty 
            {
                outputList.Add(s.Pop());
            }
            for (int i = 0; i < outputList.Count; i++)
            {
                Console.Write("{0}", outputList[i]);
            }

            Console.ReadLine();


            ////////////////////////////////////////////// 2222222222222222222222222222222222222222222222222222
            Console.WriteLine("Task 2");

            //фамилия, имя, отчество, пол, возраст, размер зарплаты
            string line;
            Queue<Member> all = new Queue<Member>();
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\\Users\\Xhref\\Desktop\\C#_task\\C-_JuniorDeveloper\КПиЯП\\Гончаров Матвей\\Collection\\Collection\\people.txt");
            while ((line = file.ReadLine()) != null)
            {
                Member m = new Member();
                string[] t = line.Split(',');
                m.surname = t[0];
                m.name = t[1];
                m.patronymic = t[2];
                m.sex = t[3];
                m.age = t[4];
                m.salary = t[5];
                all.Enqueue(m);
            }
            Console.WriteLine("мужчины\n");
            foreach (Member member in all)
            {
                if (member.sex.Trim() == "муж")
                {
                    Console.WriteLine(member);
                }
            }
            Console.WriteLine("\nженщины\n");
            foreach (Member member in all)
            {
                if (member.sex.Trim() == "жен")
                {
                    Console.WriteLine(member);
                }
            }
        }
    }
}

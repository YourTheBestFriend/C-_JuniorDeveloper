using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
        static bool IsOperator(string c)
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
        struct Employee
        {
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Patronymic { get; set; }
            public string Sex { get; set; }
            public string Age { get; set; }
            public string Salary { get; set; }
            public override string ToString()
            {
                // Интерополирование
                return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", Surname, Name, Patronymic, Sex, Age, Salary);
            }
        }

        // 333333333333333333333333333333333333
        public struct BaggageList : IComparable<BaggageList>
        {
            string name;
            int amount;
            double weight;
            public BaggageList(string name, int amount, double weight)
            {
                this.name = name;
                this.amount = amount;
                this.weight = weight;
            }
            public override string ToString()
            {
                return $"Name: {name}, amount of things: {amount}, general weight: {weight}";
            }

            public int CompareTo(BaggageList other)
            {
                if (amount > other.amount)
                    return 1;
                if (amount < other.amount)
                    return -1;
                else
                    return 0;
            }

            public bool Check(double w)
            {
                if (weight > w)
                    return true;
                else
                    return false;
            }
        }
        public struct Student : IComparable<Student>
        {
            string name;
            DateTime dateOfBirth;
            int group;
            double averageGrade;
            public Student(string name, DateTime dateOfBirth, int group, double averageGrade)
            {
                this.name = name;
                this.dateOfBirth = dateOfBirth;
                this.group = group;
                this.averageGrade = averageGrade;
            }

            public int CompareTo(Student obj)
            {
                return string.Compare(name, obj.name, true);
            }

            public override string ToString()
            {
                return $"Имя: {name}; дата рождения: {dateOfBirth}; группа: {group}; средний балл: {averageGrade}\n";
            }
        }

        // 444444444444444444444444444444444444
        // 4.1
        class Disk
        {
            Dictionary<string, string> songs = new Dictionary<string, string>();

            public void AddSong(string song, string singer)
            {
                songs.Add(song, singer);
            }

            public void DeleteSong(string song)
            {
                songs.Remove(song);
            }

            public override string ToString()
            {
                StringBuilder s = new StringBuilder("");
                foreach (KeyValuePair<string, string> keyValue in songs)
                {
                    s.Append($"\n{keyValue.Key} - {keyValue.Value}");
                }
                return s.ToString();
            }

            public bool IsExist(string singer)
            {
                int count = 0;
                foreach (KeyValuePair<string, string> keyValue in songs)
                {
                    if (keyValue.Value == singer)
                    {
                        count++;
                    }    
                }
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }   
            }

            public bool IsExistSong(string song)
            {
                int count = 0;
                foreach (KeyValuePair<string, string> keyValue in songs)
                {
                    if (keyValue.Key == song)
                    {
                        count++;
                    }   
                }
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }     
            }

            public string Search(string singer)
            {
                StringBuilder s = new StringBuilder("");
                foreach (KeyValuePair<string, string> keyValue in songs)
                {
                    if (keyValue.Value == singer)
                    {
                        s.Append($"{keyValue.Key} - {keyValue.Value}\n");
                    }        
                }
                return s.ToString();
            }
        }
        // 4.2
        class DiskCatalog
        {
            string name;
            Dictionary<string, Disk> catalog = new Dictionary<string, Disk>();

            public string Name
            {
                set { name = value; }
            }
            public void AddDisk(string name, Disk d)
            {
                catalog.Add(name, d);
            }

            public void DeleteDisk(string name)
            {
                catalog.Remove(name);
            }

            public void ShowDisk(string name)
            {
                Console.Write($"[{name}] ");
                foreach (KeyValuePair<string, Disk> keyValue in catalog)
                {
                    if (keyValue.Key == name)
                    {
                        Console.WriteLine(keyValue.Value);
                    }     
                }
            }

            public override string ToString()
            {
                StringBuilder s = new StringBuilder($"Каталог {name}: \n");
                foreach (KeyValuePair<string, Disk> keyValue in catalog)
                {
                    s.Append($"\n\nНазвание диска: {keyValue.Key}\nПесни: {keyValue.Value}");
                }
                return s.ToString();
            }

            public void Search(string singer)
            {
                Console.WriteLine($"\n[Записи исполнителя {singer}] ");
                int count = 0;
                foreach (Disk s in catalog.Values)
                {
                    if (s.IsExist(singer))
                    {
                        Console.WriteLine(s.Search(singer));
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("Записей данного исполнителя нет.");
                }  
            }

            public void AddSong(Disk d, string song, string singer)
            {
                d.AddSong(song, singer);
            }

            public void DeleteSong(Disk d, string song)
            {
                if (d.IsExistSong(song))
                {
                    d.DeleteSong(song);
                }
                else
                {
                    Console.WriteLine("Данной записи не существует в выбранном альбоме.");
                } 
            }
        }

        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////// 111111111111111111111111111111111111
            Console.WriteLine("Task 1");

            //string infix = "3 ^ 4 + ( 11 - ( 3 * 2 ) ) / 2";
            string infix = "( ( 2 + 2 ) * 2 ) / 2 - 5^2";
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
                if (IsOperator(c) == true)
                {
                    while (s.Count != 0 && Priority(s.Peek()) >= Priority(c))
                    {
                        outputList.Add(s.Pop());
                    }
                    s.Push(c);
                }
            }
            while (s.Count != 0) // if any operators remain in the stack, pop all & add to output list until stack is empty 
            {
                outputList.Add(s.Pop());
            }
            for (int i = 0; i < outputList.Count; i++)
            {
                Console.Write("{0}", outputList[i]);
            }
           
            ////////////////////////////////////////////// 2222222222222222222222222222222222222222222222222222
            Console.WriteLine("\n\nTask 2");
            //фамилия, имя, отчество, пол, возраст, размер зарплаты
            string line;
            Queue<Employee> all = new Queue<Employee>();
            using (StreamReader file = new(@"C:\\Users\\Xhref\\Desktop\\C#_task\\C-_JuniorDeveloper\КПиЯП\\Гончаров Матвей\\Collection\\Collection\\people.txt"))
            {
                while ((line = file.ReadLine()) != null) // Считываю построчно
                {
                    // Console.WriteLine(line);
                    Employee m = new Employee();
                    string[] t = line.Split(' ');
                    m.Surname = t[0];
                    m.Name = t[1];
                    m.Patronymic = t[2];
                    m.Sex = t[3];
                    m.Age = t[4];
                    m.Salary = t[5];
                    all.Enqueue(m);
                }
            }
            Console.WriteLine("мужчины");
            foreach (Employee emp in all)
            {
                if (emp.Sex.Trim() == "мужской")
                {
                    Console.WriteLine(emp);
                }
            }
            Console.WriteLine("\nженщины");
            foreach (Employee emp in all)
            {
                if (emp.Sex.Trim() == "женский")
                {
                    Console.WriteLine(emp);
                }
            }

            ////////////////////////////////////////////// 33333333333333333333333333333333333333333333333
            Console.WriteLine("\nTask 3");
            ArrayList list = new ArrayList();
            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\Xhref\\Desktop\\C#_task\\C-_JuniorDeveloper\\КПиЯП\\Гончаров Матвей\\Collection\\Collection\\input.txt", System.Text.Encoding.Default))
                {
                    string line2;
                    while ((line2 = sr.ReadLine()) != null)
                    {
                        string[] values = line2.Split(' ');
                        string name = values[0];
                        string[] date = values[1].Split('.');
                        int year = Convert.ToInt32(date[0]);
                        int month = Convert.ToInt32(date[1]);
                        int day = Convert.ToInt32(date[2]);
                        int group = Convert.ToInt32(values[2]);
                        double average = Convert.ToDouble(values[3]);
                        list.Add(new Student(name, new DateTime(year, month, day), group, average));
                    }
                    sr.Close();
                }
                using (StreamWriter sw = new StreamWriter("C:\\Users\\Xhref\\Desktop\\C#_task\\C-_JuniorDeveloper\\КПиЯП\\Гончаров Матвей\\Collection\\Collection\\input.txt", false, System.Text.Encoding.Default))
                {
                    foreach (Student std in list)
                    {
                        sw.WriteLine(std);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            List<Student> list2 = new List<Student>();
            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\Xhref\\Desktop\\C#_task\\C-_JuniorDeveloper\\КПиЯП\\Гончаров Матвей\\Collection\\Collection\\input.txt", System.Text.Encoding.Default))
                {
                    string line3;
                    while ((line3 = sr.ReadLine()) != null)
                    {
                        string[] values = line3.Split(' ');
                        string name = values[0];
                        string[] date = values[1].Split('.');
                        int year = Convert.ToInt32(date[0]);
                        int month = Convert.ToInt32(date[1]);
                        int day = Convert.ToInt32(date[2]);
                        int group = Convert.ToInt32(values[2]);
                        double average = Convert.ToDouble(values[3]);
                        list2.Add(new Student(name, new DateTime(year, month, day), group, average));
                    }
                    sr.Close();
                }
                using (StreamWriter sw = new StreamWriter("C:\\Users\\Xhref\\Desktop\\C#_task\\C-_JuniorDeveloper\\КПиЯП\\Гончаров Матвей\\Collection\\Collection\\input.txt", false, System.Text.Encoding.Default))
                {
                    foreach (Student std in list2)
                    {
                        sw.WriteLine(std);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            string way = "C:\\Учеба\\C#\\baggage.txt";
            string way2 = "C:\\Учеба\\C#\\baggage_final.txt";
            //ArrayList list = new ArrayList();
            ArrayList rightList = new ArrayList();
            try
            {
                using (StreamReader sr = new StreamReader(way, System.Text.Encoding.Default))
                {
                    string line4;
                    while ((line4 = sr.ReadLine()) != null)
                    {
                        string[] values = line4.Split(' ');
                        string name = $"{values[0]} {values[1]} {values[2]}";
                        int amount = Convert.ToInt32(values[3]);
                        double weight = Convert.ToDouble(values[4]);
                        list.Add(new BaggageList(name, amount, weight));
                    }
                }
                Console.WriteLine("Введите вес: ");
                double w = Convert.ToDouble(Console.ReadLine());
                foreach (BaggageList b in list)
                {
                    if (b.Check(w))
                        rightList.Add(b);
                }
                //rightList.Sort();
                using (StreamWriter sw = new StreamWriter(way2, false, System.Text.Encoding.Default))
                {
                    foreach (BaggageList b in rightList)
                    {
                        sw.WriteLine(b);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            ////////////////////////////////////////////// 44444444444444444444444444444444444444444444444
            Console.WriteLine("\nTask 4");
            // Диски
            Disk disk1 = new Disk();
            disk1.AddSong("Without you", "Eminem");
            disk1.AddSong("The Real Slim Shady", "Eminem");
            disk1.AddSong("Till I Collapse", "Eminem");

            Disk disk2 = new Disk();
            disk2.AddSong("Капитал", "Ляпис Трубецкой");
            disk2.AddSong("Зорачкі", "Ляпис Трубецкой");
            disk2.AddSong("Ау", "Ляпис Трубецкой");
           
            Disk disk3 = new Disk();
            disk3.AddSong("Перемен", "Виктор Цой");
            disk3.AddSong("Пачка сигарет", "Виктор Цой");
            disk3.AddSong("Спокойная ночь", "Виктор Цой");
           
            // Каталог
            DiskCatalog catalog = new DiskCatalog();
            catalog.Name = "Songs";
            catalog.AddDisk("disk Eminem", disk1);
            catalog.AddDisk("disk Ляпис Трубецкой", disk2);
            catalog.AddDisk("disk Виктор Цой", disk3);
            
            ///////////////////////////////////////////////////////////////////
            catalog.DeleteSong(disk2, "Ау");
            catalog.AddSong(disk2, "Воины света", "В платье белом");

            catalog.ShowDisk("disk Ляпис Трубецкой");
            catalog.Search("Eminem");

        }
    }
}

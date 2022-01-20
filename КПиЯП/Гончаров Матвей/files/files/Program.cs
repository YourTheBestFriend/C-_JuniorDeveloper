using System;
using System.Collections.Generic;
using System.IO; // Для файлов 
using System.Linq; // LINQ

namespace files
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("Task 1");
            var seq = new[] { 1, 3, -4, 5, 6, -7, -4};
            using (BinaryWriter fwrite = new BinaryWriter(File.Open(@"test.dat", FileMode.OpenOrCreate)))
            {
                Array.ForEach(seq, x =>
                {
                    if (x < 0)
                    {
                        fwrite.Write(x);
                    }  
                });
            }
            using (BinaryReader reader = new BinaryReader(File.Open(@"test.dat", FileMode.Open)))
            {
                // пока не достигнут конец файла
                // считываем каждое значение из файла
                while (reader.PeekChar() > -1)
                {
                    int x = reader.ReadInt32();
                    Console.WriteLine(x);
                }
            }

            // 2
            Console.WriteLine("Task 2");
            var lines = File.ReadAllLines(@"test2.txt").ToList();
            var min = lines.FindIndex(x => x.Length == lines.Min(z => z.Length)) + 1;
            Console.WriteLine(min);

            // 3
            Console.WriteLine("Task 3");
            try
            {
                if (!Directory.Exists("c:\\temp"))
                {
                    Directory.CreateDirectory("c:\\temp");
                }
                Directory.CreateDirectory("c:\\temp\\K1");
                Directory.CreateDirectory("c:\\temp\\K2");
                StreamWriter fwrite2 = new StreamWriter("c:\\temp\\K1\\t1.txt");
                fwrite2.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");
                fwrite2.Close();
                fwrite2 = new StreamWriter("c:\\temp\\K1\\t2.txt");
                fwrite2.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
                fwrite2.Close();
                // Уже из этих двух в t3.txt
                fwrite2 = new StreamWriter("c:\\temp\\K2\\t3.txt");
                StreamReader freader2 = new StreamReader("c:\\temp\\K1\\t1.txt");
                fwrite2.WriteLine(freader2.ReadToEnd());
                freader2.Close();
                freader2 = new StreamReader("c:\\temp\\K1\\t2.txt");
                fwrite2.WriteLine(freader2.ReadToEnd());
                freader2.Close();
                fwrite2.Close();
                File.Move("c:\\temp\\K1\\t2.txt", "c:\\temp\\K2\\t2.txt");
                File.Copy("c:\\temp\\K1\\t1.txt", "c:\\temp\\K2\\t1.txt");
                Directory.Move("c:\\temp\\K2", "c:\\temp\\ALL");
                Directory.Delete("c:\\temp\\K1", true);
                DirectoryInfo dinf = new DirectoryInfo("c:\\temp\\ALL");
                FileInfo[] finf = dinf.GetFiles();
                foreach (FileInfo fi in finf)
                {
                    Console.WriteLine(fi.FullName.ToString() + fi.Attributes.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
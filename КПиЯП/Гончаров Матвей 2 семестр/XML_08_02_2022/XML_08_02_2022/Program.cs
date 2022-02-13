using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XML_08_02_2022
{
    class Program
    {
        // Главная функция в которой switch
        public static void MainFunction(SheduleDisciplini catalog)
        {
            bool FlagExit = false;
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// Основной switch
            while (true)
            {
                Console.WriteLine("\t\t[Main]\n1 - Работа без xml\n2 - работа с xml\n3 - повторить действие или выйти? (основной switch)");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// без xml
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("\t\t[Работа без xml]\n1 - Вывод данных\n2 - Добавление объекта\n3 - Выбор запросов\n4 - повторить действие или выйти?");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("|||||||||||Data");
                                    foreach (var x in catalog.ListDisciplin)
                                    {
                                        Console.WriteLine(x); // там переопределяется метод ToString()
                                    }
                                    break;
                                case 2:
                                    catalog.AddDisciplina(catalog.ListDisciplin);
                                    break;
                                case 3:
                                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////// Список запросов без xml
                                    while (true)
                                    {
                                        Console.WriteLine("\t\t[Список запросов без xml]\n1 - Одновременная сортировка по фамилии преподавателя и количеству студентов в группе" +
                                        "\n2 - Вывести названия дисциплин, имеющих курсач\n3 - Вывести фамилию преподавателя с наибольшим количеством экзаменов" +
                                        "\n4 - Вывести количество практических занятий по всем учебным дисциплинам\n5 - Выполнить группировку по каждому полю\n6 - повторить действие или выйти из списка запросов?");
                                        switch (Convert.ToInt32(Console.ReadLine()))
                                        {
                                            case 1:
                                                catalog.ListDisciplin.Sort();
                                                Console.WriteLine("\nВыполнилась сортировка");
                                                break;
                                            case 2:
                                                catalog.PrintNameDisciplinIfEstKursach();
                                                break;
                                            case 3:
                                                catalog.PrintNameDisciplinIfEstKursach();
                                                break;
                                            case 4:
                                                catalog.PrintColvoPractZanatii();
                                                break;
                                            case 5:
                                                // тут не понял что за группировка
                                                break;
                                            case 6:
                                                Console.WriteLine("Хотите выйти ? - yes");
                                                if (Convert.ToString(Console.ReadLine()) == "yes")
                                                {
                                                    FlagExit = true;
                                                }
                                                break;
                                        }
                                        if (FlagExit == true)
                                        {
                                            FlagExit = false; // чтобы не вышло из предыдущего
                                            break;
                                        }
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Хотите выйти ? - yes");
                                    if (Convert.ToString(Console.ReadLine()) == "yes")
                                    {
                                        FlagExit = true;
                                    }
                                    break;
                            }
                            if (FlagExit == true)
                            {
                                FlagExit = false; // чтобы не вышло из основного
                                break;
                            }
                        }
                        break;
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// с xml
                    case 2:
                        // Читаем Xml файл.
                        ReadXmlFile("C:\\Users\\Matthew\\Desktop\\C-_JuniorDeveloper\\КПиЯП\\Гончаров Матвей 2 семестр\\XML_08_02_2022\\XML_08_02_2022\\example.xml");
                        while (true)
                        {
                            Console.WriteLine("\t\t[Работа c xml]\n1 - Вывод данных из XMl\n2 - Добавление объектов в xml\n3 - Выбор запросов\n4 - повторить действие или выйти?");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    ReadXmlFile("C:\\Users\\Matthew\\Desktop\\C-_JuniorDeveloper\\КПиЯП\\Гончаров Матвей 2 семестр\\XML_08_02_2022\\XML_08_02_2022\\example.xml");
                                    break;
                                case 2:
                                    // Пишем в файл.
                                    WriteXmlFile("result.xml", catalog);
                                    Console.WriteLine("Данные Записаны в файл result.xml");
                                    break;
                                case 3:
                                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////// Список запросов с xml
                                    while (true)
                                    {
                                        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// переработка
                                        Console.WriteLine("\t\t[Список запросов без xml]\n1 - Одновременная сортировка по фамилии преподавателя и количеству студентов в группе" +
                                        "\n2 - Вывести названия дисциплин, имеющих курсач\n3 - Вывести фамилию преподавателя с наибольшим количеством экзаменов" +
                                        "\n4 - Вывести количество практических занятий по всем учебным дисциплинам\n5 - Выполнить группировку по каждому полю\n6 - повторить действие или выйти из списка запросов?");
                                        switch (Convert.ToInt32(Console.ReadLine()))
                                        {
                                            case 1:
                                                catalog.ListDisciplin.Sort();
                                                Console.WriteLine("\nВыполнилась сортировка");
                                                break;
                                            case 2:
                                                catalog.PrintNameDisciplinIfEstKursach();
                                                break;
                                            case 3:
                                                catalog.PrintNameDisciplinIfEstKursach();
                                                break;
                                            case 4:
                                                catalog.PrintColvoPractZanatii();
                                                break;
                                            case 5:
                                                // тут не понял что за группировка
                                                break;
                                            case 6:
                                                Console.WriteLine("Хотите выйти ? - yes");
                                                if (Convert.ToString(Console.ReadLine()) == "yes")
                                                {
                                                    FlagExit = true;
                                                }
                                                break;
                                        }
                                        if (FlagExit == true)
                                        {
                                            FlagExit = false; // чтобы не вышло из предыдущего
                                            break;
                                        }
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Хотите выйти ? - yes");
                                    if (Convert.ToString(Console.ReadLine()) == "yes")
                                    {
                                        FlagExit = true;
                                    }
                                    break;
                            }
                            if (FlagExit == true)
                            {
                                FlagExit = false; // чтобы не вышло из основного
                                break;
                            }
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Вы попали в default");
                        break;
                    case 3:
                        Console.WriteLine("Хотите выйти ? - yes");
                        if (Convert.ToString(Console.ReadLine()) == "yes")
                        {
                            FlagExit = true; // чтобы не вышло из основного
                        }
                        break;
                }
                // Выход их основного 
                if (FlagExit == true)
                {
                    // FlagExit = false; // тут уже не надо
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            // Устанавливаем кодировку консоли.
            // Нужно только если при использовании англоязычной Windows
            // на консоль вместо кириллицы выводятся знаки вопроса (??? ????? ??????)
            Console.OutputEncoding = Encoding.Unicode;

            // Создаем структуру данных.
            var catalog = new SheduleDisciplini() // Корневой элемент
            {
                ListDisciplin = new List<Disciplina>()
                {
                    // string nameDisciplina, string familiaPrepodsavatela, int numStudents, int colvoHourLekcii, int colvoPractLekcii, string nalichKursacha, string vidItogovogoKursacha
                    new Disciplina("KPiAP(C#)", "Baglasova", 23, 200, 200, "Да", "экзамен"),
                    new Disciplina("English", "Smelova", 12, 100, 100, "Нет", "экзамен"),
                    new Disciplina("OAiP(C++)", "Shalapin", 25, 1000, 900, "Да", "экзамен"),
                    new Disciplina("TestPO", "Iakimovich", 23, 120, 120, "Нет", "экзамен"),
                    new Disciplina("DataBase", "Kubtsova", 23, 110, 110, "Да", "экзамен"),
                    new Disciplina("AUDO", "Basaliga", 23, 150, 150, "Нет", "зачет"),
                    new Disciplina("BuhUchet", "Iaskevich", 23, 90, 90, "нет", "зачет"),
                    new Disciplina("Basic(Java)", "Kibisova", 23, 170, 170, "Нет", "экзамен"),
                    new Disciplina("PractWeb", "Kudravceva", 23, 200, 200, "нет", "зачет"),
                    new Disciplina("Fizra", "Burmakova", 23, 100, 50, "нет", "зачет")
                }
            };


            // start
            MainFunction(catalog);

           
            Console.ReadLine();
        }

        /// <summary>
        /// Сохранить данные в Xml файл.
        /// </summary>
        /// <param name="filename"> Путь к сохраняемому файлу. </param>
        /// <param name="catalog"> Сохраняемые данные. </param>
        private static void WriteXmlFile(string filename, SheduleDisciplini catalog)
        {
            // Создаем новый Xml документ.
            var doc = new XmlDocument();

            // Создаем Xml заголовок.
            var xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

            // Добавляем заголовок перед корневым элементом.
            doc.AppendChild(xmlDeclaration);

            // Создаем Корневой элемент
            var root = doc.CreateElement("catalog");

            // Получаем все записи телефонной книги.
            foreach (var Disciplin in catalog.ListDisciplin)
            {
                // Создаем элемент записи телефонной книги.
                var phoneNode = doc.CreateElement("phone");

                if (Disciplin.Important)
                {
                    // Если установлен атрибут Важный в true,
                    // то создаем и добавляем атрибут к элементу записи телефонной книги.

                    // Создаем атрибут и нужным именем.
                    var attribute = doc.CreateAttribute("group");

                    // Устанавливаем содержимое атрибута.
                    attribute.InnerText = "important";

                    // Добавляем атрибут к элементу.
                    phoneNode.Attributes.Append(attribute);
                }

                // Создаем зависимые элементы.
                AddChildNode("name", Disciplin.Name, phoneNode, doc);
                AddChildNode("number", Disciplin.Number.ToString(), phoneNode, doc);
                AddChildNode("remark", Disciplin.Remark, phoneNode, doc);

                // Добавляем запись телефонной книги в каталог.
                root.AppendChild(phoneNode);
            }

            // Добавляем новый корневой элемент в документ.
            doc.AppendChild(root);

            // Сохраняем документ.
            doc.Save(filename);
        }

        /// <summary>
        /// Прочитать Xml файл.
        /// </summary>
        /// <param name="filename"> Путь к Xml файлу. </param>
        private static void ReadXmlFile(string filename)
        {
            // Создаем экземпляр Xml документа.
            var doc = new XmlDocument();

            // Загружаем данные из файла.
            doc.Load(filename);

            // Получаем корневой элемент документа.
            var root = doc.DocumentElement;

            // Используем метод для рекурсивного обхода документа.
            PrintItem(root);
        }

        /// <summary>
        /// Метод для отображения содержимого xml элемента.
        /// </summary>
        /// <remarks>
        /// Получает элемент xml, отображает его имя, затем все атрибуты
        /// после этого переходит к зависимым элементам.
        /// Отображает зависимые элементы со смещением вправо от начала строки.
        /// </remarks>
        /// <param name="item"> Элемент Xml. </param>
        /// <param name="indent"> Количество отступов от начала строки. </param>
        private static void PrintItem(XmlElement item, int indent = 0)
        {
            // Выводим имя самого элемента.
            // new string('\t', indent) - создает строку состоящую из indent табов.
            // Это нужно для смещения вправо.
            // Пробел справа нужен чтобы атрибуты не прилипали к имени.
            Console.Write($"{new string('\t', indent)}{item.LocalName} ");

            // Если у элемента есть атрибуты, 
            // то выводим их поочередно, каждый в квадратных скобках.
            foreach (XmlAttribute attr in item.Attributes)
            {
                Console.Write($"[{attr.InnerText}]");
            }

            // Если у элемента есть зависимые элементы, то выводим.
            foreach (var child in item.ChildNodes)
            {
                if (child is XmlElement node)
                {
                    // Если зависимый элемент тоже элемент,
                    // то переходим на новую строку 
                    // и рекурсивно вызываем метод.
                    // Следующий элемент будет смещен на один отступ вправо.
                    Console.WriteLine();
                    PrintItem(node, indent + 1);
                }

                if (child is XmlText text)
                {
                    // Если зависимый элемент текст,
                    // то выводим его через тире.
                    Console.Write($"- {text.InnerText}");
                }
            }
        }

        /// <summary>
        /// Добавить зависимый элемент с текстом.
        /// </summary>
        /// <param name="childName"> Имя дочернего элемента. </param>
        /// <param name="childText"> Текст, который будет внутри дочернего элемента. </param>
        /// <param name="parentNode"> Родительский элемент. </param>
        /// <param name="doc"> Xml документ. </param>
        private static void AddChildNode(string childName, string childText, XmlElement parentNode, XmlDocument doc)
        {
            var child = doc.CreateElement(childName);
            child.InnerText = childText;
            parentNode.AppendChild(child);
        }
    }
}

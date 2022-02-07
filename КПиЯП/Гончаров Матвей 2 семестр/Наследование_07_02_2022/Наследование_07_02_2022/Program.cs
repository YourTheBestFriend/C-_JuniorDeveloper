/*
                    Общее задание.
        1. Определить иерархию классов (в соответствии с вариантом). +
        2. 
            2.1 Классы(минимум один) должны содержать конструкторы (с параметрами и без), +
            2.2 статический конструктор, свойства (get, set), +
            2.3 переопределение методов (override) в производных классах. +
        3. Создайте в одном из классов статический метод вывода количества объектов и статическое поле – номер объекта. + (например реализовал в классе республика)
        4. В проекте должны быть или интерфейс(при множественном наследовании), или абстрактный класс (при единичном наследовании). +
        5. В методах класса (минимум в одном) для работы с аргументами используйте ref - и out-параметры. !!!!!!!!!!!!!!!!!!!!!!!!!!! +-
        6. При возникновении ошибок должны выбрасываться исключения. Выполните обработку исключений, используя try, catch и finally. +
        7. Создайте бесплодный класс, указанный в варианте. + (С помощью sealed - RB)
        8. Напишите демонстрационную программу, в которой создаются объекты различных классов и добавляются в коллекцию из пространства имен System.Collections. +
 */

// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

namespace Наследование_07_02_2022 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // Список абстрактного класса Gosudarstvo
                List<Gosudarstvo> list = new List<Gosudarstvo>();

                // Это различные типы государства
                Respublica gos1 = new Respublica("Tadzhikistan", "tjk", "gerb_tjk", "tutVid1", "pravitelstvo1");
                Korolevstvo gos2 = new Korolevstvo("United Kindom", "funt", "flag_joker", "Elisaveta_2");
                RB gos3 = new RB("RB", "ue", "flag_white_red_white", "tutVid2", "pravitelstvo2");

                // Add
                list.Add(gos1);
                list.Add(gos2);
                list.Add((gos3));

                // test method - UvelichKred_10
                Console.WriteLine("\n[test method - UvelichKred_10]");               
                int x = gos1.Kredit;
                gos1.UvelichKred_10(ref x);

                // test static method
                Respublica.PrintColObject(); // Выведет т.к gos1 это 1 и + gos3 (Производный sealed класс от Respublica)

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error = " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Вы попали в finnaly");
            }
        }
    }
}



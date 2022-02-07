using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Наследование_07_02_2022
{
    abstract internal class Gosudarstvo
    {
        int kredit = 0;
        static int numberObject;
        string name;
        string denezhnayaEden;
        string simvolika;
        public static int NumberObject
        {
            get { return numberObject; }
            set { numberObject = value; }
        }
        public int Kredit
        {
            get { return kredit; }
            set { kredit = value; }
        }
        public string Name
        {
            get { return name; }
            set 
            {
                try
                {
                    if (name.Length < 3)
                    {
                        throw new ArgumentException("Error!");
                    }
                    name = value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                    throw;
                }
                finally
                {
                    Console.WriteLine("Сработал finally");
                }
            }
        }
        public string DenezhnayaEden
        {
            get { return denezhnayaEden; }
            set { denezhnayaEden = value; }
        }
        public string Simvolika
        {
            get { return simvolika; }
            set { simvolika = value; }
        }

        static Gosudarstvo()
        {
            numberObject = ++numberObject;
        }
        // С параметрами
        public Gosudarstvo(int x, string name, string denezhnayaEden, string simvolika) 
        {
            numberObject = ++numberObject;
            Name = name;
            DenezhnayaEden = denezhnayaEden;
            Simvolika = simvolika;

        }
        // Вывод кол-ва объектов
        static void PrintColvoObject()
        {
            Console.WriteLine("Кол-во обьектов: " + NumberObject);
        }

        // Методы работы с кредитом для переопределеия их в производных классах
        public abstract void UvelichKred_10(ref int x);

        public abstract void UmenshKred_10(out int x);
       
    }
}

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классы
{
    class Program
    {
        static void Main(string[] args)
        {
            //int ii = 0;
            //while (true)
            //{
            //    Лр_1_2 a = Лр_1_2.F(ii++);
            //}

            //111111111111111111111111111111111111111111111
             //make
            Phone obj1 = new Phone();
            Phone obj2 = new Phone();
            Phone obj3 = new Phone();
            // print
            Console.WriteLine("__obj1__");
            obj1.show();
            Console.WriteLine("__obj2__");
            obj2.show();
            Console.WriteLine("__obj3__");
            obj3.show();

            obj1.sendMessage(298734995, 298734994, 298754995, 298634995);

            // c тремя 
            obj1 = new Phone(297537818, "xiaomi", 2.3);
            // c двумя
            obj2 = new Phone(292834356, "samsung");

            obj1.receiveCall("Matvey");
            obj2.receiveCall("David");


            obj3 = new Phone(292777834, "nokia");
            obj3.receiveCall("Artem");

            // print
            Console.WriteLine("\nget_number");
            Console.WriteLine("obj1 = " + obj1.get_number());
            Console.WriteLine("obj2 = " + obj2.get_number());
            Console.WriteLine("obj3 = " + obj3.get_number());

            // и
            obj3.receiveCall("Artem", 292777834);

            // к
            obj1.sendMessage(297537818, 292834356);

            // 22222222222222222222222222222222222222222222222222
            Person pr1 = new Person();
            Person pr2 = new Person("MatveyGoncharovNickolaevich", 17);
            pr1.move();
            pr2.talk();

            // 333333333333333333333333333333333333333333333333333
            double[,] matr1 = new double[,] { { 1.4, 3.6, 6.7 }, { 4.2, 6.8, 5.1 }, { 5.4, 8.7, 7.9, } };
            double[,] matr2 = new double[,] { { 1.4, 3.6, 6.7 }, { 4.2, 6.8, 5.1 }, { 5.4, 8.7, 7.9, } };

            matrix arr1 = new matrix(matr1);
            arr1.show();
            arr1.plus_other_matrix(matr2);
            arr1.show();
            arr1.proizv_on_num(2.4);
            arr1.show();
            //arr1.proizv_matric(matr2); // это доп. задание
            arr1.show();

            // 444444444444444444444444444444444444444444444444444
            Reader reader_1 = new Reader("GoncharovMatveyNickolaevich", 10, "Факультет компьютерных систем и сетей", 10082021, 299786992);
            reader_1.takeBook(3);
            reader_1.takeBook("Приключения", "Словарь", "Энциклопедия");
            reader_1.returnBook("Приключения", "Словарь", "Энциклопедия");
            Book book1 = new Book("Evgeniy_Onegin", "Pushkin");
            Book book2 = new Book("Medniy_Vsadnik", "Pushkin");
            reader_1.takeBook(book1.name, book2.name);
            reader_1.returnBook(book1.name, book2.name);



            Console.WriteLine("_______________________________");
            reader_1.takeBook(book1, book2);

            // Массив объектов данного класса
            Console.WriteLine("Введите кол-во объектов класса");
            int size_n = Convert.ToInt32(Console.ReadLine());
            Reader[] array_reader = new Reader[size_n];
            Console.WriteLine($"Введите данные объектов:");
            for (int i = 0; i < array_reader.Length; i++)
            {
                Console.WriteLine($"object [{i}]: ");
                array_reader[i] = new Reader();
                Console.WriteLine("Ввод FIO: ");
                array_reader[i].FIO = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ввод номер: ");
                array_reader[i].numberRead = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ввод fakultet: ");
                array_reader[i].Fakultet = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ввод date: ");
                array_reader[i].date = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ввод номер телефона: ");
                array_reader[i].honeNumber = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array_reader.Length; i++)
            {
                Console.WriteLine($"object [{i}]: ");
                array_reader[i].takeBook(book1.name, book2.name);
                array_reader[i].returnBook(book1.name, book2.name);
            }

            // 5555555555555555555555555555555555555555555555555555
            complex z1 = new complex(3, -1);
            complex z2 = new complex(-2, 3);
            z1 = z1.multiplication(z2);
            z1.print_complex();
            z1 = z1.pow2(2);
            z1 = z1.division(z2.pow2(2));
            z1.print_complex();

            // 66666666666666666666666666666666666666666666666666666
            Vector3D v1 = new Vector3D(5, 5, 5);
            Vector3D v2 = new Vector3D(3, 2, 1);
            Vector3D v3 = v1 + v2;
            Vector3D v4 = v1 - v2;
            double d, l;
            if (v1 != v2)
                d = Vector3D.Scal(v1, v2);
            else
                l = v3.Length();
            //  Vector3D.Scal();

            // 77777777777777777777777777777777777777777777777777777
            Console.WriteLine("_________________");
            date_7_task dt1 = new date_7_task(2021, 5, 12);
            date_7_task dt2 = new date_7_task(2021, 5, 12);
            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            bool f = dt1.eql_date(dt1, dt2);
            Console.WriteLine(f);
            dt1.add_day(1);
            Console.WriteLine(f);
            Console.WriteLine(dt1.promezh_day(10));

            //   // Лр_1
            Console.WriteLine("++++++++++++++++++++++++++++");
            Лр_1 object1 = new Лр_1(10, 2);
            //object1.colvo_minut_do_polunochi();
            Console.WriteLine(object1);
            Console.WriteLine(object1.obsh_col_second());

            Лр_1_2 object2 = new Лр_1_2(10, 2, 10);
            //object1.colvo_minut_do_polunochi();
            Console.WriteLine(object2);
            object2.colvo_minut_do_polunochi();

            // Лр_2
            PRICE price1 = new PRICE();
            price1.set_money(15.53);
            price1.set_name_price("phone");
            price1.set_name_store("apple_store");
            price1.stoim("Apple_store");
        }
    }
}

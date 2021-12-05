using System;

namespace наследование_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("____1____");
            PAIR ob1 = new PAIR(1, 3);
            PAIR ob2 = new PAIR(5, 2);
            PAIR ob3 = ob1.plus_(ob2);
            // output
            Console.WriteLine($"ob3 first = {ob3.first}, second = {ob3.second}");
           
            // 2
            Console.WriteLine("____2____");
            Long_number obj1 = new Long_number(4, 1);
            Long_number obj2 = new Long_number(7, 4);
            Long_number obj3 = obj1.plus_(obj2);
            // output
            Console.WriteLine($"obj3 oldPartNumber = {obj3.oldPartNumber}, youngPartNumber = {obj3.youngPartNumber}");
            Long_number obj4 = obj1.minus_(obj2);
            Console.WriteLine($"obj4 oldPartNumber = {obj4.oldPartNumber}, youngPartNumber = {obj4.youngPartNumber}");
            Long_number obj5 = obj1.nultiplexing_(obj2);
            Console.WriteLine($"obj5 oldPartNumber = {obj5.oldPartNumber}, youngPartNumber = {obj5.youngPartNumber}");


        }
    }
}

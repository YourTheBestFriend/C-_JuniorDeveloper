using System.Collections.Generic;
using System;
namespace test_answer_on_question
{

    interface IControl
    {
        void Paint();
    }
    interface IForm
    {
        void Paint();
    }
    class Page : IControl, IForm
    {
        public void Paint() => Console.WriteLine("In class page");
        void IControl.Paint()
        {
            Console.WriteLine("Paint IControl");
        }
        void IForm.Paint()
        {
            Console.WriteLine("Paint IForm");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Page x = new Page();
            x.Paint();
            (x as IControl).Paint();
            (x as IForm).Paint();
        }
    }


    // 18
    //class Test
    //{
    //    delegate int F();
    //    static void Main()
    //    {
    //        List<F> fs = new List<F>();
    //        int[] xs = { 1, 2, 3 };
    //        for (int i = 0; i < 3; i++)
    //        {
    //            fs.Add(() => xs[i]);
    //        }
    //        foreach (F f in fs)
    //        {
    //            Console.WriteLine(f());
    //        }
    //        Console.ReadLine();
    //    }
    //}   
    /*
     Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
     at test_answer_on_question.Test.<>c__DisplayClass1_1.<Main>b__0() in C:\Users\Matthew\Desktop\C-_JuniorDeveloper\КПиЯП\Гончаров Матвей 2 семестр\test_answer_on_question\test_answer_on_question\Program.cs:line 14
     at test_answer_on_question.Test.Main() in C:\Users\Matthew\Desktop\C-_JuniorDeveloper\КПиЯП\Гончаров Матвей 2 семестр\test_answer_on_question\test_answer_on_question\Program.cs:line 18
     */

    // 19
    //class Test
    //{
    //    static void Main(string[] args)
    //    {
    //        A a = new B();
    //        CallMethod1(a);
    //        a = new C();
    //        CallMethod1(a);
    //        Console.ReadKey();
    //    }
    //    public static void CallMethod1(A item)
    //    {
    //        B b = item as B;
    //        b.Method1();
    //    }
    //}
    //abstract class A
    //{
    //    public virtual void Method1()
    //    {
    //        Console.WriteLine("A.Method1");
    //    }
    //}
    //class B : A
    //{
    //    public override void Method1()
    //    {
    //        Console.WriteLine("B.Method1");
    //    }
    //}
    //class C : A
    //{
    //    public override void Method1()
    //    {
    //        Console.WriteLine("C.Method1");
    //    }
    //}
    /* 
     B.Method1
     Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
     at test_answer_on_question.Test.CallMethod1(A item) in C:\Users\Matthew\Desktop\C-_JuniorDeveloper\КПиЯП\Гончаров Матвей 2 семестр\test_answer_on_question\test_answer_on_question\Program.cs:line 44
     at test_answer_on_question.Test.Main(String[] args) in C:\Users\Matthew\Desktop\C-_JuniorDeveloper\КПиЯП\Гончаров Матвей 2 семестр\test_answer_on_question\test_answer_on_question\Program.cs:line 38
     */

    // 20
    //class A
    //{
    //    public virtual int m(ref int i)
    //    { 
    //        i = 1;
    //        return i;
    //    }
    //}
    //class B : A
    //{
    //    public override int m(ref int i)
    //    {
    //        i = 2;
    //        return i;
    //    }
    //}
    //internal class Program
    //{
    //    int i;
    //    private static void Main(string[] args)
    //    {
    //        A a = new B();
    //        System.Console.WriteLine(a.m(ref i));
    //    }
    //}
    // Ошибка, если сделать поле статическим выведет 2

    // 21
    //interface Interface1
    //{
    //    void F();
    //    void G();
    //}
    //class Class1
    //{
    //    public void F() { }
    //    public void G() { }
    //}
    //class Class2 : Class1, Interface1
    //{
    //    new public void G() { }
    //}
    // нет не скомпилируется, нужен main

    // 22
    //public Class C1 : M1, M2 { }
    //public struct S1 : M3, M4 { };
    // от первого только 1 класс и интерфейс, от структуры только интерфейсы

    // 23
    //interface IList
    //{
    //    public int Count { get; set; }
    //}
    //interface ICounter
    //{
    //    void Count(int i);
    //}
    //interface IListCounter : IList, ICounter
    //{
    //    // public int Count { get; set; }
    //    // IListCounter(int i) => Count = i;
    //}
    //class C
    //{
    //    void Test(IListCounter x) // 1
    //    {
    //        x.Count(1); // 2

    //        (x as IList).Count = 1; // 3
    //    }
    //}
    // 3 строка ошибка

    // 24 

    //    class Base
    //    {
    //        public String className = "Base";
    //}
    //    class Derived : Base
    //    {
    //        private new String className = "Derived";
    //}
    //    class Test
    //    {
    //        static void Main(string[] args)
    //        {
    //            Console.WriteLine(new Derived().className);
    //        }
    //    }
    // Вывыдет Base

    // 25
    //class OuterClass
    //{
    //    private int i;
    //    protected int j;
    //    public int k;
    //    public OuterClass()
    //    {
    //        InnerClass nested = new InnerClass(this);
    //        nested.a = 1; // 1
    //        nested.b = 1; // 2
    //        nested.c = 1; // 3
    //    }
    //    class InnerClass
    //    {
    //        private int a;
    //        protected int b;
    //        public int c;
    //        public InnerClass(OuterClass outerClass)
    //        {
    //            outerClass.i = 1; // 4
    //            outerClass.j = 1; // 5
    //            outerClass.k = 1;
    //        }
    //    }
    //}
    // Ошибка -- 1 2

    // 26
    //interface IControl
    //{
    //    void Paint();
    //}
    //interface IForm
    //{
    //    void Paint();
    //}
    //class Page : IControl, IForm
    //{
    //    public void Paint() { }
    //}

    // Да скомилируется


    // 27
    //public class Test
    //{
    //    int testInt = 5;
    //    public int getInt() { return testInt; }
    //}
    //class Another
    //{
    //    int a1;
    //    int a2;
    //    int a3;

    //    Another()
    //    {
    //        Test x = new Test();
    //        a1 = x.getInt();
    //        // a2 = x.testInt;
    //    }
    //}

}

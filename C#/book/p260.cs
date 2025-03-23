using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace CsConsole
{
    class MainApp
    {
        //p260
        class MyClass
        {
            int a, b, c;
            public MyClass()
            {
                this.a = 5425;
                WriteLine("MyClass()");
            }
            public MyClass(int b):this()
            {
                this.b = b;
                WriteLine($"MyClass({b})");
            }
            public MyClass(int b, int c) : this(b)
            {
                this.c = c;
                WriteLine($"MyClass({b},{c})");
            }
            public void PrintFields()
            {
                WriteLine($"a:{a}, b:{b}, c:{c})");
            }
        }
        static void Main(string[] args)
        {
            //P260
            MyClass a = new MyClass();
            a.PrintFields();
            WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            WriteLine();

            MyClass c = new MyClass(10,20);
            c.PrintFields();

            ReadLine();
        }
    }
}
using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace CsConsole
{
    class MainApp
    {
        //p239
        class Cat
        {
            public string name;
            public string color;
            //p243
            public Cat()
            {
                name = "";
                color = "";
            }
            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
            }
            public void Meow() { WriteLine("{0} : Meow", name); }
        }
        //p248
        class Global
        {
            public static int Count = 0;
        }
        class ClassA
        {
            public ClassA()
            {
                Global.Count++;
            }
        }
        //p253
        class MyClass
        {
            public int MyField1;
            public int MyField2;
            public MyClass DeecCopy()
            {
                MyClass newCopy= new MyClass();
                newCopy.MyField1 = MyField1;
                newCopy.MyField2 = MyField2;
                return newCopy;
            }
        }
        static void Main(string[] args)
        {
            //239
            Cat kitty = new Cat();
            kitty.color = "White";
            kitty.name = "Kitty";
            kitty.Meow();
            //243
            Cat Nero = new Cat("Nero", "Black");
            Nero.Meow();
            //p249
            WriteLine($"Global.Count : {Global.Count}");
            new ClassA();
            new ClassA();
            WriteLine($"Global.Count : {Global.Count}");

            //p254
            WriteLine("Shallow Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                WriteLine($"{source.MyField1} {source.MyField2}");
                WriteLine($"{target.MyField1} {target.MyField2}");
            }
            WriteLine("Deep Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeecCopy();
                target.MyField2 = 30;

                WriteLine($"{source.MyField1} {source.MyField2}");
                WriteLine($"{target.MyField1} {target.MyField2}");
            }
            ReadLine();
        }
    }
}
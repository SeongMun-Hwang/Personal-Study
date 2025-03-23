using static System.Console;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
namespace CsConsole
{
    //p592
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    class History : System.Attribute
    {
        private string programmer;
        public double version;
        public string changes;

        public History(string programmer)
        {
            this.programmer = programmer;
            this.version = 1.0;
            changes = "Frist Release";
        }
        public string GetProgrammer()
        {
            return programmer;
        }
    }
    [History("Sean", version = 0.1, changes = "2017-11-01 Created class stub")]
    [History("Bob", version = 0.2, changes = "2020-12-03 Added Func() Method")]

    class MyClass
    {
        public void Func()
        {
            WriteLine("Func()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            //p593
            Type type = typeof(MyClass);
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            WriteLine("MyClass change history...");
            foreach(Attribute a in attributes)
            {
                History h = a as History;
                if(h != null)
                {
                    WriteLine("Ver:{0}, Programmer:{1}, Changes:{2}",h.version,h.GetProgrammer(),h.changes);
                }
            }
            ReadLine();
        }
    }
}
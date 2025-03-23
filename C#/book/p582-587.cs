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
    //p582
    public class MyClass
    {
        [Obsolete("OldMethod는 폐기되었습니다. NewMethid()를 이용하세요.")]
        public void OldMethod()
        {
            WriteLine("I'm old");
        }
        public void NewMethod()
        {
            WriteLine("I'm new");
        }
    }
    //p587
    public static class Trace
    {
        public static void WriteLine(string message,
            [CallerFilePath] string file="",
            [CallerLineNumber] int line =0,
            [CallerMemberName] string member = "") 
        {
            Console.WriteLine($"{file}(Line: {line}) {member}: {message}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            //p583
            MyClass obj = new MyClass();
            obj.OldMethod();
            obj.NewMethod();
            WriteLine();

            //p587
            Trace.WriteLine("Programming");
            ReadLine();
        }
    }
}
using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace CsConsole
{
    class MainApp
    {
        //p205
        class Calculator
        {
            public static int Plus(int a, int b)
            {
                return a+b;
            }
            public static int Minus(int a , int b)
            {
                return a - b;
            }
        }
        //p207
        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n-1)+Fibonacci(n-2);
        }
        static void PrintProfile(string name, string phone)
        {
            if(name == "")
            {
                WriteLine("Input your name : ");
                return;
            }
            WriteLine($"Name : {name}, Phone : {phone}");
        }
        static void Main(string[] args)
        {
            //p205
            WriteLine(Calculator.Plus(1, 2));
            WriteLine(Calculator.Minus(1, 2));

            WriteLine($"10th Fibonicci Number : {Fibonacci(10)}");
            PrintProfile("", "123-4567");
            PrintProfile("SeongMun", "000-0000");

            ReadLine();
        }
    }
}
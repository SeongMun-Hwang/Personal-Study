using static System.Console;
using System;
using System.Collections;
namespace CsConsole
{
    class MainApp
    {    
        //p507
        delegate int Caluculate(int a,int b);
        //p509
        delegate string Concatenate(string[] args);
        static void Main(string[] args)
        {
            //p507
            Caluculate calc = (a, b) => a + b;
            WriteLine($"{3} + {4} : {calc(3,4)}");
            WriteLine();

            //p509
            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (string s in arr)
                    result += s;
                return result;
            };
            args = new string[] { "Hello", "World", "Program" };
            WriteLine(concat(args));
            WriteLine();

            //p512
            Func<int> func1 = () => 10;
            WriteLine($"func1() : {func1()}");

            Func<int, int> func2 = (x) => x * 3;
            WriteLine($"func2() : {func2(3)}");

            Func<double, double, double> func3 = (x, y) => x / y;
            WriteLine($"func3() : {func3(22, 7)}");
            WriteLine();

            //p514
            Action act1 = () =>  WriteLine("Action()");
            act1();

            int result = 0;
            Action<int> act2 = (x) => result = x * x;
            WriteLine("result : " + result);

            Action<double, double> act3 = (x, y) =>
            {
                double pi = x / y;
                WriteLine($"Action<T1,T2>({x}, {y}) : {pi}");
            };
            act3(22.0, 7.0);
            WriteLine();

            ReadLine();
        }
    }
}
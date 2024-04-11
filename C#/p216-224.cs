using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace CsConsole
{
    class MainApp
    {
        //p216
        static void DivideRef(int a, int b, ref int q, ref int r)
        {
            q = a / b;
            r = a % b;
        }
        //p217
        static void DivideOut(int a, int b, out int q, out int r)
        {
            q = a / b;
            r = a % b;
        }
        //p220
        static int Plus(int a, int b) { return a + b; }
        static double Plus(double a, double b) { return a + b; }
        //p223
        static int Sum(params int[] args)
        {
            int sum = 0;
            for (int i = 0; i < args.Length; i++) { sum += args[i]; }
            return sum;
        }

        static void Main(string[] args)
        {
            //p216
            int a = 20, b = 3, c = 0, d = 0;
            DivideRef(a, b, ref c, ref d);
            WriteLine("Quotient : {0}, Remainder : {1}", c, d);

            DivideOut(a, b, out int e, out int f);
            WriteLine("Quotient : {0}, Remainder : {1}", c, d);

            //p220
            WriteLine(Plus(1, 2));
            WriteLine(Plus(1.1, 2.2));

            //p224
            WriteLine(Sum(2, 3));
            WriteLine(Sum(3, 4, 5, 6, 7, 8, 9, 10));

            ReadLine();
        }
    }
}
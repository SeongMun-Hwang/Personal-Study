using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace CsConsole
{
    class MainApp
    {
        //p231
        static double Square(double arg)
        {
            return arg * arg;
        }
        //p232
        public static void Mean(double a, double b,double c,
            double d,double e,ref double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
        static void Main(string[] args)
        {
            //231
            Write("Input Number : ");
            string input = ReadLine();
            double arg = Convert.ToDouble(input);
            WriteLine($"Result : {Square(arg)}");

            //p232
            double mean = 0;
            Mean(1, 2, 3, 4, 5, ref mean);
            WriteLine($"Average : {mean}");

            ReadLine();
        }
    }
}
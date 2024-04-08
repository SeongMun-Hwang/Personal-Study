using static System.Console;
using System;
using System.Linq;

namespace CsConsole
{
    class MainApp
    {
        //p197
        class Fibonacci
        {
            public static long GetNumber(long index) {
                long result = index switch
                {
                    0=>0,
                    1=>1,
                    _=>GetNumber(index-1)+GetNumber(index-2),
                };
                return result;
            }
        }
        static void Main(string[] args)
        {
            //p196
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < i+1; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5-i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();

            Write("Input repeat number : ");
            var num = ReadLine();
            if(int.Parse(num) is <= 0)
                WriteLine("Same or Under 0 cannot used");
            else
            {
                for (int i = 0; i < int.Parse(num); i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        Write("*");
                    }
                    WriteLine();
                }
            }
            WriteLine();

            //p197
            Write("Input number : ");
            WriteLine(Fibonacci.GetNumber(long.Parse(ReadLine())));
            ReadLine();
        }
    }
}
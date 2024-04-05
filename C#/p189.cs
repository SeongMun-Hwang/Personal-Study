using System.Collections;
using static System.Console;
using System;

namespace CsConsole
{
    class MainApp
    {
        static string GetGrade(double score) => score switch
        {
            < 60 => "F",
            >= 60 and < 70 => "D",
            >= 70 and < 80 => "C",
            >= 80 and < 90 => "B",
            _ => "A",
        };
        static void Main(string[] args)
        {
            Write("Input your score : ");
            double score = double.Parse(ReadLine());
            WriteLine($"Your Grade is {GetGrade(score)}");
            ReadLine();
        }
    }
}
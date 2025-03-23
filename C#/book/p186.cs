using System.Collections;
using static System.Console;
using System;

namespace CsConsole
{
    class Preschooler { }
    class Underage { }
    class Adult { }
    class Senior { }

    class MainApp
    {
        static int CalculateFee(object visitor)
        {
            return visitor switch
            {
                Underage => 100,
                Adult => 500,
                Senior => 200,
                Preschooler => 0,
            };
        }
        static void Main(string[] args)
        {
            WriteLine($"Fee for a senior : {CalculateFee(new Senior())}");
            WriteLine($"Fee for a Adult : {CalculateFee(new Adult())}");
            WriteLine($"Fee for a Underage : {CalculateFee(new Underage())}");
            WriteLine($"Fee for a preschooler : {CalculateFee(new Preschooler())}");
            ReadLine();
        }
    }
}
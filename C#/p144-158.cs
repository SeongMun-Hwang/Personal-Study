using System.Collections;
using static System.Console;

namespace CsConsole
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p144
            int? num = null;
            WriteLine($"{num??0}");

            num = 99;
            WriteLine($"{num??0}");

            string str = null;
            WriteLine($"{str ?? "Default"}");

            str = "Specific";
            WriteLine($"{str ?? "Default"}");
            WriteLine();

            //p146
            WriteLine($"{8>>3}");
            int a = 10;
            string b = a == 0 ? "가나다" : "ABC";
            WriteLine(b);
            WriteLine();

            //151
            Write("Input Number : ");
            string input = ReadLine();
            int number =int.Parse(input);

            if (number < 0)
                WriteLine("Minus");
            else if (number > 0)
                WriteLine("Plus");
            else
                WriteLine("Zero");

            if (number % 2 == 0)
                WriteLine("Even");
            else
                WriteLine("Odd");

            //158
            object obj = null;
            Write("Input : ");
            string s=ReadLine();
            if (int.TryParse(s, out int out_i))
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;

            switch (obj)
            {
                case int:
                    WriteLine($"{(int)obj}'s type is Int");
                    break;
                case float:
                    WriteLine($"{(float)obj}'s type is Float");
                    break;
                default:
                    WriteLine($"{obj}'s type is Unknown)");
            }

            ReadLine();
        }
    }
}
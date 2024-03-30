using System.Collections;
using static System.Console;

namespace CsConsole
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p160
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
                case int i when i>=0:
                    WriteLine($"{(int)obj}'s type is Int Plus");
                    break;
                case int:
                    WriteLine($"{(int)obj}'s type is Int Minus");
                    break;
                case float f when f >= 0:
                    WriteLine($"{(float)obj}'s type is Float Plus");
                    break;
                case float:
                    WriteLine($"{(float)obj}'s type is Float Minus");
                    break;
                default:
                    WriteLine($"{obj}'s type is Unknown");
                    break;
            }
            WriteLine();

            //p163
            Write("Input Score : ");
            int score = int.Parse(ReadLine());
            score = score - score % 10;
            bool re = bool.Parse(ReadLine());

            string grade = score switch
            {
                90 when re ==true=>"B+",
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"
            };
            WriteLine($"Grade is : {grade}");

            ReadLine();
        }
    }
}
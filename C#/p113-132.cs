using System.Collections;
using static System.Console;

namespace CsConsole
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p113
            string name = "SeongMun Hwang";
            int age = 26;
            WriteLine($"{name,-20},{age:D3}.");
            WriteLine($"{name},{age,-20:D3}.");
            WriteLine($"{name},{(age>20?"adult":"children")}.");
            WriteLine();

            //p114
            WriteLine("Input height of square");
            var height = ReadLine();
            WriteLine("Input width of square");
            var width = ReadLine();
            WriteLine("Size of square is : {0}", int.Parse(height)*int.Parse(width));
            WriteLine();

            WriteLine($"1 == 0 : { 1 == 0}");
            string result = (10 % 3) == 0 ? "짝수" : "홀수";
            WriteLine("result : {0}", result);
            WriteLine();

            //p132
            ArrayList a = null;
            a?.Add("A");
            WriteLine($"count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine();
            
            a=new ArrayList();
            a?.Add("A");
            a?.Add("B");
            WriteLine($"count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");
            WriteLine();

            ReadLine();
        }
    }
}
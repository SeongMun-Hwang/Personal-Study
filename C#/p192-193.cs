using static System.Console;
using System;
using System.Linq;

namespace CsConsole
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p192
            var IsPassed = (int[] scores) => scores.Sum() / scores.Length is var average
            && Array.TrueForAll(scores, (score) => score >= 60)
            && average >= 60;

            int[] scores1 = { 90, 80, 60, 80, 70 };
            WriteLine($"{string.Join(",", scores1)}: Pass:{IsPassed(scores1)}");

            int[] scores2 = { 90, 80, 50, 80, 70 };
            WriteLine($"{string.Join(",", scores2)}: Pass:{IsPassed(scores2)}");


            //p193
            var GetCountryCode = (string nation) => nation switch
            {
                "KR" => 82,
                "US" => 1,
                "UK" => 44,
                _ => throw new ArgumentException("Unknown Country code")
            };
            WriteLine(GetCountryCode("KR"));
            WriteLine(GetCountryCode("US"));
            WriteLine(GetCountryCode("UK"));
            WriteLine(GetCountryCode("CA"));

            ReadLine();
        }
    }
}
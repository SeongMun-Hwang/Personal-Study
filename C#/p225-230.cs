using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace CsConsole
{
    class MainApp
    {
        //p225
        static void PrintProfile(string name, string phone = "None")
        {
            WriteLine($"Name : {name}, Phone : {phone}");
        }
        //p230
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for(int i=0;i < arr.Length;i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90)
                    return arr[i];
                else
                    return (char)(arr[i] + 32);
            }
            return new string(arr);
        }
        static void Main(string[] args)
        {
            //p225
            PrintProfile(name: "Kim", phone: "1");
            PrintProfile(name: "Lee", phone: "2");
            PrintProfile(name: "Choe", phone: "4");
            PrintProfile(name: "hwnag");

            //p230
            WriteLine(ToLowerString("Hello!"));
            WriteLine(ToLowerString("Good Morning."));
            WriteLine(ToLowerString("This is C#."));

            ReadLine();
        }
    }
}
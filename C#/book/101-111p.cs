using System;
using System.Globalization;
using static System.Console;

namespace CsConsole
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string words = "Good morning everyone!";

            WriteLine(words.Substring(0,5));
            WriteLine(words.Substring(5));
            WriteLine();    

            string[] arr=words.Split(new string[] { " " },StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length);

            foreach (string element in arr)
                WriteLine("{0}", element);
            WriteLine();

            string fmt = "{0,-20}{1,-15}{2,30}";

            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron man");
            WriteLine(fmt, "Hanbit", "Spark", "This is C#");
            WriteLine();

            DateTime dt = new DateTime(2024, 03, 27, 22, 44, 1);
            WriteLine("12시간 형식 : {0:yyyy-MM-dd tt hh:mm:ss (ddd)}",dt);
            WriteLine("24시간 형식 : {0:yyyy-MM-dd tt HH:mm:ss (dddd)}",dt);
            WriteLine();

            CultureInfo ci =new CultureInfo("en-US");
            WriteLine("12시간 형식 : "+dt.ToString("0:yyyy-MM-dd tt hh:mm:ss (ddd)", ci));
            WriteLine("24시간 형식 : "+dt.ToString("0:yyyy-MM-dd tt HH:mm:ss (dddd)", ci));
            ReadLine();
        }
    }
}
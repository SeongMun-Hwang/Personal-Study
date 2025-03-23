using static System.Console;

namespace CsConsole
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string words = " Good Morning ";

            WriteLine(words);
            WriteLine();

            WriteLine("Index of 'Good' : {0}", words.IndexOf("Good"));
            WriteLine("Index of 'o' :{0}",words.IndexOf("o"));

            WriteLine("Last index of 'Good' : {0}", words.LastIndexOf("Good"));
            WriteLine("Last Index of 'o' :{0}", words.LastIndexOf("o"));

            WriteLine("StartsWith 'Good' : {0}", words.StartsWith("Go"));
            WriteLine("StartsWith 'o' :{0}", words.StartsWith("o"));

            WriteLine("EndsWith 'Good' : {0}", words.EndsWith("Good"));
            WriteLine("EndsWith 'g' :{0}", words.EndsWith("g"));

            WriteLine("Contains 'Good' : {0}", words.Contains("Good"));
            WriteLine("Contains 'o' :{0}", words.Contains("o"));

            WriteLine("Replace :{0}", words.Replace("Morning", "Evening"));

            WriteLine("ToLower : {0}",words.ToLower());
            WriteLine("ToUpper : {0}",words.ToUpper());

            WriteLine("Insert : {0}", words.Insert(words.Length, " everyone!"));
            WriteLine("Remove :{0}", words.Remove(10, 3));

            WriteLine("Trim : {0}", words.Trim());
            WriteLine("TrimStart :{0}", words.TrimStart());
            WriteLine("TrimEnd:{0}", words.TrimEnd());

            ReadLine();
        }
    }
}
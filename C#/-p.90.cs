using System;

namespace CsConsole
{
    class MainApp
    {
        enum Reply { YES,NO }

        static void Main(string[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int c = 128;
            Console.WriteLine(c);

            sbyte d=(sbyte)c;
            Console.WriteLine(d);

            Console.WriteLine((int)Reply.YES);
            Console.WriteLine((int)Reply.NO);

            int ?e = 1;
            Console.WriteLine(e.HasValue);
            Console.WriteLine(e.Value);
        }
    }
}
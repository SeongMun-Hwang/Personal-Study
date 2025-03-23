using System;
using static System.Console;

namespace CsConsole
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("uses : HelloWorld.exe");
                return;
            }
            WriteLine("Hello, {0}!", args[0]);
        }
    }
}
using System;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace Program
{
    class MainApp
    {
        //p710
        async static private void MyMethodAsync(int count)
        {
            WriteLine("C");
            WriteLine("D");

            await Task.Run(async () =>
            {
                for (int i = 1; i <= count; i++)
                {
                    WriteLine($"{i}/{count}...");
                    await Task.Delay(100);
                }
            });
            WriteLine("G");
            WriteLine("H");
        }
        static void Caller()
        {
            WriteLine("A");
            WriteLine("B");

            MyMethodAsync(3);

            WriteLine("E");
            WriteLine("F");
        }
        static void Main(string[] args)
        {
            //p711
            Caller();

            ReadLine();
        }
    }
}
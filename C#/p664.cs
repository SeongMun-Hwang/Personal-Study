using System;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace Program
{
    class MainApp
    {
        //p664
        static void DoSomething()
        {
            for (int i = 0; i < 5; i++)
            {
                WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);
            }
        }
        static void Main(string[] args)
        {
            //p664
            Thread t1 = new Thread(new ThreadStart(DoSomething));
            WriteLine("Starting thread...");
            t1.Start();

            for (int i = 0; i < 5; i++)
            {
                WriteLine($"Main : {i}");
                Thread.Sleep(10);
            }
            WriteLine("Waiting until thread stops...");
            t1.Join();

            WriteLine("Finished");


            ReadLine();
        }
    }
}
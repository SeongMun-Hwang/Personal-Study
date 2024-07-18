using System;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace Program
{
    class MainApp
    {
        //p702
        static bool IsPrime(long number)
        {
            if (number < 2)
            {
                return false;
            }
            if (number % 2 == 0 && number != 2)
            {
                return false;
            }
            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            //p707
            long from = Convert.ToInt64(args[0]);
            long to = Convert.ToInt64(args[1]);

            WriteLine("Please press enter to start...");
            ReadLine();
            WriteLine("Started...");

            DateTime startTime = DateTime.Now;
            List<long> total = new List<long>();

            Parallel.For(from, to, (long i) =>
            {
                if (IsPrime(i)) lock (total) total.Add(i);
            });

            DateTime endTime = DateTime.Now;

            TimeSpan elapsed = endTime - startTime;
            WriteLine("Prime number count between {0} and {1} : {2}",
                from, to, total.Count);
            WriteLine("Elapsed time : {0}", elapsed);

            ReadLine();
        }
    }
}
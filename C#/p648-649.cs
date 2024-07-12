using static System.Console;
using System;
using System.Linq;

namespace CsConsole
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p648
            using (StreamWriter sw=new StreamWriter(
                new FileStream("a.txt",FileMode.Create)))
            {
                sw.WriteLine(int.MaxValue);
                sw.WriteLine("Good Morning!");
                sw.WriteLine(uint.MaxValue);
                sw.WriteLine("Hell!");
                sw.WriteLine(double.MaxValue);
            }
            using (StreamReader sr=
                new StreamReader(
                    new FileStream("a.txt", FileMode.Open)))
            {
                //p649
                WriteLine($"File size : {sr.BaseStream.Length} bytes");
                while (sr.EndOfStream == false)
                {
                    WriteLine(sr.ReadLine());
                }
            }
            
            ReadLine();
        }
    }
}
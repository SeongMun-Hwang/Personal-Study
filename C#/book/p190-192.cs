using static System.Console;
using System;

namespace CsConsole
{
    class MainApp
    {
        //p191-2
        struct Audience
        {
            public bool IsCitizen { get; set; }
            public int Age { get; set; }
            
            public Audience(bool isCitizen, int age)
            {
                IsCitizen = isCitizen;
                Age = age;
            }
            public void Deconstruct(out bool isCitizen, out int age) {
                isCitizen = IsCitizen;
                age = Age;
            }
        }

        static void Main(string[] args)
        {
            //p190
            object age = 30;
            if (age is (int and > 19))
                WriteLine("Major");

            //p191-1
            Tuple<string, int> item = new Tuple<string, int>("Americano", 3000);
            if (item is ("espresso", < 5000))
                WriteLine("Coffee is affordable.");

            //p191-2
            var calculateFee = (Audience audience) => audience switch
            {
                (true, < 19) => 100,
                (true, _) => 200,
                (false, < 19) => 200,
                (false, _) => 400,
            };

            var a1 = new Audience(true, 10);
            WriteLine($"Local : {a1.IsCitizen} age : {a1.Age} fee : {calculateFee(a1)}");
            var a2 = new Audience(false, 23);
            WriteLine($"Local : {a2.IsCitizen} age : {a2.Age} fee : {calculateFee(a2)}");

            ReadLine();
        }
    }
}
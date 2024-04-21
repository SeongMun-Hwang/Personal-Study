using static System.Console;
using System;
namespace CsConsole
{
    //p371
    class NameCard
    {
        public int age { get; set; } = 0;
        public string name { get; set; } = "Unknown";
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            //p371
            NameCard MyCard = new NameCard();
            MyCard.age = 24;
            MyCard.name = "Lee";
            WriteLine($"Age : {MyCard.age}, Name : {MyCard.name}");

            NameCard Annoymous = new NameCard();
            WriteLine($"Age : {Annoymous.age}, Name : {Annoymous.name}");

            //p372
            var nameCard = new { name = "Park", age = 23 };
            WriteLine($"Age : {nameCard.age}, Name : {nameCard.name}");

            var complex = new { Real = true, Imaginary = false };
            WriteLine("Real : {0}, Imaginary : {1}", complex.Real, complex.Imaginary);

            ReadLine();
        }
    }

}
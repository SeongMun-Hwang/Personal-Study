using static System.Console;
using System;
namespace CsConsole
{
    //p366
    interface INamedValue
    {
        string Name { get; set; }
        string Value { get; set; }
    }
    class NamedValue : INamedValue
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
    //p369
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return String.Format("{0:d5}", serial++); }
        }
        abstract public DateTime ProductDate { get; set; }
    }
    class MyProduct : Product
    {
        public override DateTime ProductDate { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            //p364
            var a = new { Name = "Park", Age = 23 };
            WriteLine($"Name : {a.Name}, Age : {a.Age}");

            var b = new { Subject = "math", Scores = new int[] { 90, 80, 70, 60 } };
            Write($"Subject : {b.Subject}, Scores : ");
            foreach (var i in b.Scores) { Write($"{i}"); };
            WriteLine();

            //p367
            NamedValue name = new NamedValue()
            { Name = "name", Value = "Park" };

            NamedValue height = new NamedValue()
            { Name = "height", Value = "183" };

            NamedValue weight = new NamedValue()
            { Name = "weight", Value = "73" };

            WriteLine($"{name.Name} : {name.Value}");
            WriteLine($"{height.Name} : {height.Value}");
            WriteLine($"{weight.Name} : {weight.Value}");
            WriteLine();

            //369
            Product p1 = new MyProduct() {
                ProductDate = new DateTime(2023, 1, 10)};
            WriteLine("Product : {0}, Product Date : {1}", p1.SerialID, p1.ProductDate);
            Product p2 = new MyProduct() {
                ProductDate = new DateTime(2023, 2, 3) };
            WriteLine("Product : {0}, Product Date : {1}", p2.SerialID, p2.ProductDate);

            ReadLine();
        }
    }
}
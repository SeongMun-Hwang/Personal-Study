using static System.Console;
using System;
using System.Linq;
using System.Globalization;
using System.Net.Http.Headers;

namespace CsConsole
{
    //p310
    struct ACSetting
    {
        public double currentInCelsius;
        public double target;
        public readonly double GetFahrenheit()
        {
            return currentInCelsius * 1.8 + 32;
        }
    }
    class MainApp
    {
        //p307
        private static double GetDiscountRate(object client)
        {
            return client switch
            {
                ("학생", int n) when n < 18 => 0.2,
                ("학생", _) => 0.1,
                ("일반", int n) when n < 18 => 0.1,
                ("일반", _) => 0.05,
                _ => 0,
            };
        }
        static void Main(string[] args)
        {
            //p308
            var alice = (job: "학생", age: 17);
            var bob = (job: "학생", age: 23);
            var charlie = (job: "일반", age: 15);
            var dave = (job: "일반", age: 21);

            WriteLine($"alice : {GetDiscountRate(alice)}");
            WriteLine($"bob : {GetDiscountRate(bob)}");
            WriteLine($"charlie : {GetDiscountRate(charlie)}");
            WriteLine($"dave : {GetDiscountRate(dave)}");

            //p310
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            WriteLine($"{acs.GetFahrenheit()}");
            WriteLine($"{acs.target}");

            ReadLine();
        }
    }
}
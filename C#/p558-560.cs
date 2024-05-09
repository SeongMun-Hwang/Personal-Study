using static System.Console;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
using System.Collections.Generic;
namespace CsConsole
{
    //p558
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    //p560
    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            //p558
            Profile[] arrProfile =
            {
                new Profile(){Name="Jeong",Height=186},
                new Profile(){Name="Kim",Height=158},
                new Profile(){Name="Go",Height=172},
                new Profile(){Name="Lee",Height=178},
                new Profile(){Name="Ha",Height=171}
            };
            var heightStat = from profile in arrProfile
                             group profile by profile.Height < 175 into g
                             select new
                             {
                                 Group = g.Key == true ? "Under 175" : "Over 175",
                                 Count = g.Count(),
                                 Max = g.Max(profile => profile.Height),
                                 Min = g.Min(profile => profile.Height),
                                 Average = g.Average(profile => profile.Height),
                             };
            foreach(var stat in heightStat)
            {
                Write("{0} - Count : {1}, Max : {2}, ",stat.Group,stat.Count,stat.Max);
                WriteLine("Min : {0}, Average : {1}",stat.Min,stat.Average);
            }
            WriteLine();

            //p560
            Car[] cars =
            {
                new Car(){Cost=56,MaxSpeed=120},
                new Car(){Cost=70,MaxSpeed=150},
                new Car(){Cost=45,MaxSpeed=180},
                new Car(){Cost=32,MaxSpeed=200},
                new Car(){Cost=82,MaxSpeed=280},
            };
            var selected = from car in cars
                           where car.Cost > 50
                           where car.MaxSpeed > 150
                           select car;
            foreach(var car in selected)
                WriteLine("Cost : {0}, MaxSpeed : {1}",car.Cost,car.MaxSpeed);

            ReadLine();
        }
    }
}
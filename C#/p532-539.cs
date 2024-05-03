using static System.Console;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
using System.Collections.Generic;
namespace CsConsole
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    class Class
    {
        public string Name { get; set; }
        public int[] Score {  get; set; }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            //p532
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };
            var result = from n in numbers
                         where n % 2 == 0
                         orderby n
                         select n;
            foreach (int n in result)
            {
                WriteLine("Even : " + n);
            }
            WriteLine();

            //p537
            Profile[] arrProfile =
            {
                new Profile(){Name="Jeong",Height=186},
                new Profile(){Name="Kim",Height=158},
                new Profile(){Name="Go",Height=172},
                new Profile(){Name="Lee",Height=178},
                new Profile(){Name="Ha",Height=171}
            };
            var profiles = from profile in arrProfile
                           where profile.Height < 175
                           orderby profile.Height
                           select new
                           {
                               Name = profile.Name,
                               InchHeight = profile.Height * 0.393
                           };
            foreach (var profile in profiles)
                WriteLine($"{profile.Name}, {profile.InchHeight}");
            WriteLine();

            //p539
            Class[] arrClass =
            {
                new Class(){Name="Green",Score=new int[]{99,80,70,24}},
                new Class(){Name="Pink",Score=new int[]{60,45,87,72}},
                new Class(){Name="Blue",Score=new int[]{92,30,85,94}},
                new Class(){Name="Yellow",Score=new int[]{90,88,0,17}},
            };
            var classes = from c in arrClass
                          from score in c.Score
                          where score < 60
                          orderby score
                          select new { c.Name, Lowest = score };
            foreach (var c in classes)
                WriteLine($"Failed : {c.Name}({c.Lowest})");
            WriteLine();

            ReadLine();
        }
    }
}
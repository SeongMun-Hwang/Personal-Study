using static System.Console;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
using System.Collections.Generic;
namespace CsConsole
{
    //p552
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    
    class MainApp
    {
        static void Main(string[] args)
        {
            //p552
            Profile[] arrProfile =
            {
                new Profile(){Name="Jeong",Height=186},
                new Profile(){Name="Kim",Height=158},
                new Profile(){Name="Go",Height=172},
                new Profile(){Name="Lee",Height=178},
                new Profile(){Name="Ha",Height=171}
            };
            var profiles = arrProfile.
                Where(profile => profile.Height < 175).
                OrderBy(profile => profile.Height).
                Select(profile =>
                new
                {
                    Name = profile.Name,
                    InchHeight = profile.Height * 0.393
                });

            foreach (var profile in profiles)
            {
                    WriteLine($"{profile.Name}, {profile.InchHeight}");
            }
            WriteLine();

           

            ReadLine();
        }
    }
}
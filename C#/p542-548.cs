using static System.Console;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
using System.Collections.Generic;
namespace CsConsole
{
    //p542
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    //p547
    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            //p542
            Profile[] arrProfile =
            {
                new Profile(){Name="Jeong",Height=186},
                new Profile(){Name="Kim",Height=158},
                new Profile(){Name="Go",Height=172},
                new Profile(){Name="Lee",Height=178},
                new Profile(){Name="Ha",Height=171}
            };
            var profiles = from profile in arrProfile
                           orderby profile.Height
                           group profile by profile.Height < 175 into g
                           select new { GroupKey = g.Key, Profiles = g };

            foreach (var profile in profiles)
            {
                WriteLine($" - under 175cm : {profile.GroupKey}");
                foreach (var p in profile.Profiles)
                    WriteLine($">>> {p.Name}, {p.Height}");
            }
            WriteLine();

            //p548
            Product[] arrProduct =
            {
                new Product(){Title="bit", Star="Jeong"},
                new Product(){Title="cf", Star="Kim"},
                new Product(){Title="Iris", Star="Kim"},
                new Product(){Title="Sand Clock", Star="Go"},
                new Product(){Title="Solo", Star="Lee"},
            };
            var listProfile = from profile in arrProfile
                              join product in arrProduct on profile.Name equals product.Star
                              select new
                              {
                                  Name = profile.Name,
                                  Work = product.Title,
                                  Height = profile.Height
                              };
            WriteLine("Inner Join results");
            foreach(var p in listProfile)
                WriteLine("Name : {0}, Work : {1}, Height : {2}cm",
                    p.Name,p.Work, p.Height);
            WriteLine();

            listProfile = from profile in arrProfile
                          join product in arrProduct on profile.Name equals product.Star
                          into ps
                          from product in ps.DefaultIfEmpty(new Product()
                          {
                              Title = "Null"
                          })
                          select new
                          {
                              Name = profile.Name,
                              Work = product.Title,
                              Height = profile.Height
                          };
            WriteLine("Outer Join results");
            foreach (var p in listProfile)
                WriteLine("Name : {0}, Work : {1}, Height : {2}cm",
                    p.Name, p.Work, p.Height);
            WriteLine();

            ReadLine();
        }
    }
}
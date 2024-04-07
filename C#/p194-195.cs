using static System.Console;
using System;
using System.Linq;

namespace CsConsole
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p194
            var match = (int[] array) => array is [int, > 10, _];
            WriteLine(match(new int[] { 1, 100, 3 }));
            WriteLine(match(new int[] { 100, 10, 999 }));
            WriteLine();

            var match2 = (int[] array) => array is [int, > 10, ..];
            WriteLine(match2(new int[] { 1, 100, 3, 4, 5 }));
            WriteLine(match2(new int[] { 100, 10, 999 }));
            WriteLine();

            //p195
            var GetStatisitics = (List<object[]> records) =>
            {
                var statisitics = new Dictionary<string, int>();

                foreach (var record in records)
                {
                    var (contentType, contentViews) = record switch
                    {
                    [_, "COMEDY", .., var views] => ("COMEDY", views),
                    [_, "SF", .., var views] => ("SF", views),
                    [_, "ACTION", .., var views] => ("ACTION", views),
                    [_, .., var amount] => ("ETC", amount),
                        _ => ("ETC", 0),
                    };
                    if (statisitics.ContainsKey(contentType))
                        statisitics[contentType] += (int)contentViews;
                    else
                        statisitics.Add(contentType, (int)contentViews);
                }
                return statisitics;
            };
            List<object[]> MOvieRecords = new List<object[]>()
            {
                new object[]{0,"COMEDY","SPY",2015,10_000},
                new object[]{1,"COMEDY","Scary Movie", 20_000},
                new object[]{2,"SF","Avengers: Infinite War",100_000},
                new object[]{3,"COMEDY","극학직업", 25_000},
                new object[]{4,"SF","Star Wars",200_000},
                new object[]{5,"ACTION","Fast & Furious",80_000},
                new object[]{6,"DRA?MA","Notting Hill",1_000},
            };
            var statistics = GetStatisitics(MOvieRecords);
            foreach(var s in statistics)
                WriteLine($"{s.Key} : {s.Value}");
            ReadLine();
        }
    }
}
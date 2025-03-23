using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using static System.Console;

namespace CsConsole
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p626
            string directory;
            if (args.Length < 1)
            {
                directory = ".";
            }
            else
            {
                 directory = args[0];
            }

            WriteLine($"{directory} directory Info");
            WriteLine("- Directories :");
            var directories = (from dir in Directory.GetDirectories(directory)
                               let info = new DirectoryInfo(dir)
                               select new
                               {
                                   Name=info.Name,
                                   Attributes=info.Attributes,
                               }).ToList();
            foreach(var d in directories)
            {
                WriteLine($"{d.Name} : {d.Attributes}");
            }

            WriteLine("- Files : ");
            var files = (from file in Directory.GetFiles(directory)
                         let info = new FileInfo(file)
                         select new
                         {
                             Name = info.Name,
                             FileSize = file.Length,
                             Attributes = info.Attributes,
                         }).ToList();
            foreach(var f in files)
            {
                WriteLine($"{f.Name} : {f.FileSize}, {f.Attributes}");
            }


            ReadLine();
        }
    }
}
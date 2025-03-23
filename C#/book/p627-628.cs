using System;
using System.IO;
using static System.Console;
namespace Program
{
    class MainApp
    {
        //p627
        static void OnWrongPathType(string type)
        {
            WriteLine($"{type} is wrong type");
            return;
        }
        static void Main(string[] args)
        {
            //p628
            if (args.Length == 0)
            {
                WriteLine("Usage : Touch.exe <Path> [Type:File/Directory]");
                return;
            }
            string path = args[0];
            string type = "File";
            if (args.Length > 1)
            {
                type = args[1];
            }

            if (File.Exists(path) || Directory.Exists(path)) { 
                if(type=="File")
                    File.SetLastWriteTime(path, DateTime.Now);
                else if(type=="Directory")
                    Directory.SetLastWriteTime(path,DateTime.Now);
                else
                {
                    OnWrongPathType(path);
                    return;
                }
                WriteLine($"Updated {path} {type}");
            }
            else
            {
                if (type == "File")
                    File.Create(path).Close();
                else if (type == "Directory")
                    Directory.CreateDirectory(path);
                else
                {
                    OnWrongPathType(path);
                    return;
                }
                WriteLine($"Created {path} {type}");
            }
        }
    }
}
using System;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace Program
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p700
            string srcFile = args[0];
            Action<object> FileCopyAction = (object state) =>
            {
                String[] paths = (String[])state;
                File.Copy(paths[0], paths[1]);

                WriteLine("TaskID : {0}, ThreadID : {1}, {2} was copied to {3}",
                    Task.CurrentId, Thread.CurrentThread.ManagedThreadId, paths[0], paths[1]);
            };

            Task t1 = new Task(
                FileCopyAction, new string[] { srcFile, srcFile + ".copy1" });
            Task t2 = Task.Run(() =>
            {
                FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
            });
            t1.Start();

            Task t3 = new Task(
                FileCopyAction, new string[] { srcFile, srcFile + ".copy3" });

            t3.RunSynchronously();

            t1.Wait();
            t2.Wait();
            t3.Wait();

            ReadLine();
        }
    }
}
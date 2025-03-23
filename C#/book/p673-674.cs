using System;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace Program
{
    class MainApp
    {
        //p673
        private static void PrintThreadState(ThreadState state)
        {
            WriteLine("{0,-16} : {1}", state, (int)state);
        }

        static void Main(string[] args)
        {
            //p674
            PrintThreadState(ThreadState.Running);
            PrintThreadState(ThreadState.SuspendRequested);
            PrintThreadState(ThreadState.Background);
            PrintThreadState(ThreadState.Unstarted);
            PrintThreadState(ThreadState.Stopped);
            PrintThreadState(ThreadState.WaitSleepJoin);
            PrintThreadState(ThreadState.Suspended);
            PrintThreadState(ThreadState.AbortRequested);
            PrintThreadState(ThreadState.Aborted);
            PrintThreadState(ThreadState.Aborted | ThreadState.Stopped);

            ReadLine();
        }
    }
}
using System;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace Program
{
    //p684
    class Counter
    {
        const int LOOP_COUNT = 1000;
        readonly object thisLock;
        private int count;
        public int Count { get { return count; } }
        public Counter()
        {
            thisLock = new object();
            count = 0;
        }
        public void Increase()
        {
            int loopCount = LOOP_COUNT;
            //p685
            while (loopCount-- > 0)
            {
                lock (thisLock) { count++; }
            }
            Thread.Sleep(1);
        }
        public void Decrease()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0) { 
                lock (thisLock) { count--; }
            }
            Thread.Sleep(1);
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            //p685
            Counter counter=new Counter();
            Thread incThread = new Thread(new ThreadStart(counter.Increase));
            Thread decThread = new Thread(new ThreadStart(counter.Decrease));

            incThread.Start();
            decThread.Start();

            incThread.Join();
            decThread.Join();

            WriteLine(counter.Count);            

            ReadLine();
        }
    }
}
using System;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace Program
{
    class MainApp
    {
        //p667
        class SideTask
        {
            int count;
            private CancellationToken _cancellationToken;
            public SideTask(int count, CancellationToken cancellationToken)
            {
                this.count = count;
                _cancellationToken = cancellationToken;
            }
            //p668
            public void KeepALive()
            {
                try
                {
                    while (count > 0)
                    {
                        if (_cancellationToken.IsCancellationRequested)
                        {
                            WriteLine("Cancellation requested");
                            break;
                        }
                        WriteLine($"{count--} left");
                        Thread.Sleep(10);

                    }
                    WriteLine("Count : 0");
                }
                catch(ThreadAbortException e)
                {
                    WriteLine(e);
                    Thread.ResetAbort();
                }
                finally
                {
                    WriteLine("Clearing Resource...");
                }
            }
        }
        static void Main(string[] args)
        {
            //p668

            CancellationTokenSource cts= new CancellationTokenSource();
            SideTask task =new SideTask(100,cts.Token);
            Thread t1 = new Thread(new ThreadStart(task.KeepALive));
            t1.IsBackground = false;

            WriteLine("Starting thread...");
            t1.Start();

            Thread.Sleep(100);
            //p669
            WriteLine("Aborting thread...");
            cts.Cancel();

            WriteLine("Wait until thread stop...");
            t1.Join();

            WriteLine("Finished");
            ReadLine();
        }
    }
}
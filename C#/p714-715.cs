using System;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace Program
{
    class MainApp
    {
        //p714
        static async Task<long> CopyAsync(string FromPath, string ToPath)
        {
            using (
                var fromStream = new FileStream(FromPath, FileMode.Open))
            {
                long totalCopied = 0;
                using (
                    var toSTream = new FileStream(ToPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024];
                    //p715
                    int nRead = 0;
                    while ((nRead =
                        await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await toSTream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;
                    }
                }
                return totalCopied;
            }
        }
        //p715
        static async void DoCopy(string FromPath, string ToPath)
        {
            long totalCopied = await CopyAsync(FromPath, ToPath);
            WriteLine($"Coied Total {totalCopied} Bytes");
        }

        static void Main(string[] args)
        {
            //p715
            if (args.Length < 2)
            {
                WriteLine("Usage : AsyncFileIO <Source> <Destination");
                return;
            }
            DoCopy(args[0], args[1]);

            ReadLine();
        }
    }
}
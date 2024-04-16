using static System.Console;
using System;
using System.Linq;
using System.Globalization;
using System.Net.Http.Headers;

namespace CsConsole
{
    //p320
    interface ILogger
    {
        void WriteLog(string  message);
    }
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message) {
            WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
    class FileLogger : ILogger
    {
        private StreamWriter writer;
        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}",DateTime.Now.ToLocalTime(), message);
        }
    }
    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void start()
        {
            while (true)
            {
                WriteLine("Write Temperature : ");
                string temperature = ReadLine();
                if (temperature == "") break;
                logger.WriteLog("Now temperature is : " + temperature);
            }
        }
    }
    
    class MainApp
    {
        static void Main(string[] args)
        {
            //p321
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            monitor.start();

            ReadLine();
        }
    }
}
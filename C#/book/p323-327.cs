using static System.Console;
using System;
using System.Linq;
using System.Globalization;
using System.Net.Http.Headers;

namespace CsConsole
{
    //p323
    interface ILogger
    {
        void WriteLog(string message);
    }
    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params object[] args);
    }
    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
        public void WriteLog(string format,params Object[] args)
        {
            String message=String.Format(format, args);
            WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
    //p326
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }
    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            WriteLine("Running...");
        }
        public void Fly()
        {
            WriteLine("Flying...");
        }
    }
    
    class MainApp
    {
        static void Main(string[] args)
        {
            //324
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("The world is not flat");
            logger.WriteLog("{0}+{1}={2}", 1, 1, 2);

            //327
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable =car as IRunnable;
            runnable.Run();
            IFlyable flyable =car as IFlyable;
            flyable.Fly();

            ReadLine();
        }
    }
}
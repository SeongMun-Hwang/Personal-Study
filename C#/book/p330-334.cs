using static System.Console;

namespace CsConsole
{
    //p330
    interface ILogger
    {
        void WriteLog(string message);
        void WriteError(string error)
        {
            WriteLine($"Error : {error}");
        }
    }
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            WriteLine($"{DateTime.Now.ToLocalTime()},{message}");
        }
    }
    //p333
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            WriteLine("AbstractBase.PrivateMethodA()");
        }
        public void PublicMethodA()
        {
            WriteLine("AbstractBase.PublicMethodA()");
        }
        public abstract void AbstractMethodA();
    }
    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            //331
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("System Up");
            logger.WriteError("System Fail");

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("System Up");
            //clogger.WriteError("System Fail");
            WriteLine();

            //p334
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();

            ReadLine();
        }
    }
}
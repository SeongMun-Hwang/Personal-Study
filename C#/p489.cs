using static System.Console;
using System;
using System.Collections;
namespace CsConsole
{
    //p489
    delegate void Notify(string message);
    class Notifier
    {
        public Notify EventOccured;
    }
    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }
        public void SomethingHappend(string message)
        {
            WriteLine($"{name}, Something Happened : {message}"); 
        }
    }
    class MainApp
    {    
        static void Main(string[] args)
        {
            //p489
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            notifier.EventOccured += listener1.SomethingHappend;
            notifier.EventOccured += listener2.SomethingHappend;
            notifier.EventOccured += listener3.SomethingHappend;
            notifier.EventOccured("You've got mail.");
            WriteLine();

            notifier.EventOccured -= listener2.SomethingHappend;
            notifier.EventOccured("Download compelete");
            WriteLine();

            notifier.EventOccured = new Notify(listener2.SomethingHappend)
                + new Notify(listener3.SomethingHappend);
            notifier.EventOccured("Nuclear launch detected.");
            WriteLine();

            Notify notify1=new Notify(listener1.SomethingHappend);
            Notify notify2=new Notify(listener2.SomethingHappend);
            notifier.EventOccured=(Notify)Delegate.Combine(notify1, notify2);
            notifier.EventOccured("Fire!!");
            WriteLine();

            notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
            notifier.EventOccured("RPG");
            ReadLine();
        }
    }
}
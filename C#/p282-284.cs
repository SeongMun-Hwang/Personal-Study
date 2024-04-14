using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace CsConsole
{
    //p282
    class Base
    {
        public void MyMethod()
        {
            WriteLine("Base.MyMethod()");
        }
        //283
        public virtual void SealMe() { }
    }
    class Derived : Base
    {
        public new void MyMethod()
        {
            WriteLine("Derived.MyMehod()");
        }
        //p284
        public sealed override void SealMe() { }
    }
    class WantToOverride : Derived
    {
        public override void SealMe() { }
    }
   
    class MainApp
    {

        static void Main(string[] args)
        {
            //P282
            Base baseObj=new Base();
            baseObj.MyMethod();

            Derived derivedobj=new Derived();
            derivedobj.MyMethod();

            Base baseOrDerived=new Derived();
            baseOrDerived.MyMethod();

            ReadLine();
        }
    }
}
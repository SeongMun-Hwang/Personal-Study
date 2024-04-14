using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace CsConsole
{
    //p274
    class Mammal
    {
        public void Nurse()
        {
            WriteLine("Nurse()");
        }
    }
    class Dog : Mammal
    {
        public void Bark()
        {
            WriteLine("Bark()");
        }
    }
    class Cat : Mammal
    {
        public void Meow()
        {
            WriteLine("Meow()");
        }
    }
    //p279
    class ArmorSuit
    {
        public virtual void Initialize()
        {
            WriteLine("Armored");
        }
    }
    class IronMan : ArmorSuit
    {
        public override void Initialize()
        {
            base.Initialize();
            WriteLine("Repulsor Rays Armed");
        }
    }
    class WarMachine : ArmorSuit
    {
        public override void Initialize()
        {
            base.Initialize();
            WriteLine("Double-Barrel Cannons Armd");
            WriteLine("Micro-Rocket Launcher Armd");
        }
    }
    class MainApp
    {

        static void Main(string[] args)
        {
            //P274
            Mammal mammal = new Dog();
            Dog dog;
            if(mammal is Dog)
            {
                dog= (Dog)mammal;
                dog.Bark();
            }
            Mammal mammal2 = new Cat();
            Cat cat = mammal2 as Cat;
            if(cat!=null)
                cat.Meow();

            Cat cat2=mammal as Cat;
            if (cat2 != null)
                cat2.Meow();
            else
                WriteLine("cat2 is not a Cat");

            //p279
            WriteLine("Creating ArmorSuite...");
            ArmorSuit armorsuite = new ArmorSuit();
            armorsuite.Initialize();

            WriteLine("Creating IronMan...");
            ArmorSuit ironman = new IronMan();
            ironman.Initialize();

            WriteLine("Creating WarMachine...");
            ArmorSuit warmachine = new WarMachine();
            warmachine.Initialize();

            ReadLine();
        }
    }
}
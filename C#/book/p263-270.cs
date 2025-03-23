using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace CsConsole
{
    //p263
    class WaterHeater
    {
        protected int temperature;
        public void SetTemperature(int temperature)
        {
            if (temperature < -5 || temperature > 42)
            {
                throw new Exception("out of Temperature Range");
            }
            this.temperature = temperature;
        }
        internal void TurnOnWater()
        {
            WriteLine($"Turn on water : {temperature}");
        }
    }
    //p269
    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            WriteLine($"{this.Name}, Base()");
        }
        ~Base()
        {
            WriteLine($"{Name}, ~Base()");
        }
        public void BaseMethod()
        {
            WriteLine($"{Name}, BaseMethod()");
        }
    }
    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        {
            WriteLine($"{this.Name}, Derived()");
        }
        ~Derived()
        {
            WriteLine($"{this.Name}, ~Derived()");
        }
        public void DerivedMethod()
        {
            WriteLine($"{Name}, DerivedMethod()");
        }
            }
    class MainApp
    {

        static void Main(string[] args)
        {
            //P263
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);
                heater.TurnOnWater();
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message);
            }

            //p270
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
            
            ReadLine();
        }
    }
}
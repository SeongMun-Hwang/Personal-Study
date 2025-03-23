using static System.Console;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
using System.Collections.Generic;
namespace CsConsole
{
    //p575
    class Profile
    {
        private string name;
        private string phone;
        public Profile()
        {
            name = ""; phone = "";
        }
        public Profile(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }
        public void Print()
        {
            WriteLine($"{name}, {phone}");
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            //p575
            Type type = Type.GetType("CsConsole.Profile");
            MethodInfo methodInfo = type.GetMethod("Print");
            PropertyInfo nameProperty = type.GetProperty("Name");
            PropertyInfo phoneProperty = type.GetProperty("Phone");

            object profile=Activator.CreateInstance(type, "Park", "512-1234");
            methodInfo.Invoke(profile, null);

            profile = Activator.CreateInstance(type);
            nameProperty.SetValue(profile, "Park", null);
            phoneProperty.SetValue(profile, "997-5511", null);

            WriteLine("{0}, {1}",
                nameProperty.GetValue(profile, null),
                phoneProperty.GetValue(profile,null));


            ReadLine();
        }
    }
}
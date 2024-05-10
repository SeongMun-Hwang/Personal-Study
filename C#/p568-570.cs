using static System.Console;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
using System.Collections.Generic;
namespace CsConsole
{
    class MainApp
    {
        //p568
        static void PrintInterfaces (Type type)
        {
            WriteLine("----- Interfaces -----");
            Type[] interfaces=type.GetInterfaces();
            foreach(Type i in interfaces)
            {
                WriteLine("Name : {0}",i.Name);
            }
            WriteLine();
        }
        static void PrintFields(Type type)
        {
            WriteLine("----- Fields -----");
            FieldInfo[] fields=type.GetFields(
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.Instance);

            foreach(FieldInfo field in fields)
            {
                string accessLevel = "protected";
                if (field.IsPublic) accessLevel = "public";
                else if (field.IsPrivate) accessLevel = "private";

                WriteLine("Access : {0}, Type : {1}, Name : {2}",
                    accessLevel,field.FieldType.Name,field.Name);
            }
            WriteLine();
        }
        //p569
        static void PrintMethods(Type type)
        {
            WriteLine("----- Methods -----");
            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Write("Type : {0}, Name : {1}, Parameter : ",
                    method.ReturnType.Name,method.Name);
                ParameterInfo[] args=method.GetParameters();
                for(int i=0;i<args.Length; i++)
                {
                    Write("{0}", args[i].ParameterType.Name);
                    if (i < args.Length - 1)
                        Write(", ");
                }
                WriteLine();
            }
            WriteLine();
        }
        static void PrintProperties(Type type)
        {
            WriteLine("----- Properties -----");
            PropertyInfo[] properties = type.GetProperties();
            
            foreach(PropertyInfo property in properties)
            {
                WriteLine("Type : {0}, Name : {1}",property.PropertyType.Name, property.Name);
            }
            WriteLine();
        }
        static void Main(string[] args)
        {
            //p570
            int a = 0;
            Type type=a.GetType();

            PrintInterfaces(type);
            PrintFields(type);
            PrintMethods(type);
            PrintProperties(type);


            ReadLine();
        }
    }
}
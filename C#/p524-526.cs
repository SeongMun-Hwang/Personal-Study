using static System.Console;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection;
using System.Collections.Generic;
namespace CsConsole
{
    //p524
    class FriendList
    {
        private List<string> list = new List<string>();
        public void Add(string name)=>list.Add(name);
        public void Remove(string name)=>list.Remove(name);
        public void PrintAll()
        {
            foreach(string s in list)
                    WriteLine(s);
            WriteLine();
        }
        public FriendList() => WriteLine("FriendList()");
        ~FriendList() => WriteLine("~FriendList()");

        //public int Capacity => list.Capacity; //읽기 전용
        public int Capactiy
        {
            get => list.Capacity;
            set=>list.Capacity = value;
        }
        //public string this[int index]=>list[index]; //읽기 전용
        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }
    class MainApp
    {    
        static void Main(string[] args)
        {
            //p525
            FriendList obj= new FriendList();
            obj.Add("Eeny");
            obj.Add("Meeny");
            obj.Add("Miny");
            obj.PrintAll();

            obj.Remove("Eeny");
            obj.PrintAll();

            WriteLine($"{obj.Capactiy}");
            obj.Capactiy = 10;
            WriteLine($"{obj.Capactiy}");

            WriteLine($"{obj[0]}");
            obj[0] = "Moe";
            WriteLine($"{obj[0]}");
            WriteLine();

            //p526
            int[] array = { 11, 22, 33, 44, 55 };
            foreach(int a in array)
            {
                Action action = () =>
                {
                    WriteLine(a * a);
                };
                action.Invoke();
            }

            ReadLine();
        }
    }
}
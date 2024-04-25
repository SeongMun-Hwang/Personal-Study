using static System.Console;
using System;
using System.Collections;
namespace CsConsole
{
    class MainApp
    {
        //p412
        class MyList
        {
            private int[] array;
            public MyList()
            {
                array = new int[3];
            }
            public int this[int index]
            {
                get { return array[index]; }
                set
                {
                    if (index >= array.Length)
                    {
                        Array.Resize(ref array, index + 1);
                        WriteLine($"Array Resized : {array.Length}");
                    }
                    array[index] = value;
                }
            }
            public int Length { get { return array.Length; } }
        }
        static void Main(string[] args)
        {
            //p406
            Hashtable ht = new Hashtable();
            ht["하나"] = "one";
            ht["둘"]="two";
            ht["셋"]="three";
            ht["넷"]="four";
            ht["다섯"]="five";

            foreach(object o in ht) { WriteLine(o); }

            WriteLine(ht["하나"]);
            WriteLine(ht["둘"]);
            WriteLine(ht["셋"]);
            WriteLine(ht["넷"]);
            WriteLine(ht["다섯"]);
            WriteLine();

            //p408
            int[] arr = { 1, 2, 3 };
            ArrayList arrayList = new ArrayList(arr);
            Stack stack = new Stack(arr);
            Queue queue = new Queue(arr);

            //p413
            MyList list = new MyList();
            for (int i = 0; i < 5; i++) list[i] = i;
            for(int i=0;i<list.Length;i++)
            {
                WriteLine(list[i]);
            }
            WriteLine("List length is : "+list.Length);

            ReadLine();
        }
    }

}
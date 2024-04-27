using static System.Console;
using System;
using System.Collections;
namespace CsConsole
{
    //p434
    class StructArray<T> where T : struct
    {
        public T[] Array { get; set; }
        public StructArray(int size) { Array = new T[size]; }
    }
    class RefArray<T> where T : class
    {
        public T[] Array { get; set; }
        public RefArray(int size) { Array = new T[size]; }
    }
    //p435
    class Base { }
    class Derived : Base { }
    class BaseArray<U> where U : Base
    {
        public U[] Array { get; set; }
        public BaseArray(int size) { Array = new U[size]; }
        public void CopArray<T>(T[] Source) where T : U
        {
            Source.CopyTo(Array, 0);
        }
    }
    class MainApp
    {
        //p426
        static void CopyArray<T>(T[] source, T[] target)
        {
            for(int i=0;i< source.Length;i++)
            {
                target[i] = source[i];
            }
        }
        //p429
        class MyList<T>
        {
            private T[] array;
            public MyList()
            {
                array = new T[3];
            }
            public T this[int index]
            {
                get { return array[index]; }
                set
                {
                    if (index >= array.Length)
                    {
                        Array.Resize<T>(ref array, index + 1);
                        WriteLine("Resize array length : {0}",array.Length);
                    }
                    array[index] = value;
                }
            }
            public int length
            {
                get { return array.Length; }
            }
        }
        //p435
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }

        static void Main(string[] args)
        {
            //p426
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyArray(source, target);

            foreach(int element in target)
                WriteLine(element);

            string[] source2 = { "one", "two", "three", "four", "five" };
            string[] target2 = new string[source2.Length];

            CopyArray(source2, target2);

            foreach (string element in target2)
                WriteLine(element);
            WriteLine();

            //p430
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";
            
            for(int i=0;i<str_list.length;i++)
                WriteLine(str_list[i]);
            WriteLine();

            MyList<int> int_list=new MyList<int>();
            int_list[0] = 0;
            int_list[1] = 1;
            int_list[2] = 2;
            int_list[3] = 3;
            int_list[4] = 4;

            for (int i = 0; i < int_list.length; i++)
                WriteLine(int_list[i]);

            //p435
            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 0;
            a.Array[1] = 1;
            a.Array[2] = 2;

            for(int i=0;i<a.Array.Length;i++)
                WriteLine(a.Array[i]);
            WriteLine();

            RefArray<StructArray<double>> b=new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(1005);

            for (int i = 0; i < b.Array.Length; i++)
                WriteLine(b.Array[i]);
            WriteLine();

            //436
            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            for (int i = 0; i < c.Array.Length; i++)
                WriteLine(c.Array[i]);
            WriteLine();

            BaseArray<Derived> d =new BaseArray<Derived>(3);
            d.Array[0] = new Derived();
            d.Array[1]=CreateInstance<Derived>();
            d.Array[2]=CreateInstance<Derived>();

            for (int i = 0; i < d.Array.Length; i++)
                WriteLine(d.Array[i]);
            WriteLine();

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopArray<Derived>(d.Array);

            for (int i = 0; i < e.Array.Length; i++)
                WriteLine(e.Array[i]);
            WriteLine();

            ReadLine();
        }
    }
}
using static System.Console;
using System;
using System.Collections;
namespace CsConsole
{
    class MainApp
    {
       //p443
       class MyList<T> : IEnumerable<T>, IEnumerator<T>
        {
            private T[] array;
            int position = -1;
            public MyList()
            {
                array= new T[3];
            }
            public T this[int index]
            {
                get { return array[index]; }
                set
                {
                    if(index>=array.Length)
                    {
                        Array.Resize(ref array, index+1);
                        WriteLine("Reszied array length : " + array.Length);
                        }
                    array[index] = value;
                }
            }
            public int Length
            {
                get { return array.Length; }
            }
            public IEnumerator<T> GetEnumerator() { return this; }
            IEnumerator IEnumerable.GetEnumerator() { return this; }
            public T Current
            {
                get { return array[position]; }
            }
            object IEnumerator.Current
            {
                get { return array[position]; }
            }
            public bool MoveNext()
            {
                if(position == array.Length - 1)
                {
                    Reset();
                    return false;
                }
                position++;
                return (position<array.Length);
            }
            public void Reset()
            {
                position = -1;
            }
            public void Dispose() { }
        }
        static void Main(string[] args)
        {
            //p438
            List<int> list = new List<int>();
            for(int i=0;i<5;i++)
                list.Add(i);
            foreach (int i in list)
                Write($"{i} ");
            WriteLine();

            list.RemoveAt(2);
            foreach (int i in list)
                Write($"{i} ");
            WriteLine();

            list.Insert(2, 2);
            foreach (int i in list)
                Write($"{i} ");
            WriteLine();

            //439
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            while(queue.Count > 0)
                Write(queue.Dequeue()+" ");
            WriteLine();
            //p440
            Stack<int> stack=new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while(stack.Count > 0)
                Write(stack.Pop()+" ");
            WriteLine();

            //p441
            Dictionary<string,string>dic = new Dictionary<string,string>();
            dic["하나"] = "one";
            dic["둘"]="two";
            dic["셋"] = "three";
            dic["넷"] = "four";
            dic["다섯"] = "five";

            foreach (string str in dic.Values)
                Write(str+" ");
            WriteLine();

            //p445
            MyList<string> str_list=new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            foreach (string str in str_list)
                WriteLine(str);
            WriteLine();

            MyList<int> int_list=new MyList<int>();
            int_list[0]= 1;
            int_list[1]= 2;
            int_list[2]= 3;
            int_list[3]= 4;
            int_list[4]= 5;

            foreach (int i in int_list)
                WriteLine(i);

            ReadLine();
        }
    }
}
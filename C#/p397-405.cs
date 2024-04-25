using static System.Console;
using System;
using System.Collections;
namespace CsConsole
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p397
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10,20,30 };
            jagged[2] = new int[] { 100,200 };

            foreach (int[] arr in jagged)
            {
                WriteLine($"Length : {arr.Length}, ");
                foreach (int i in arr)
                {
                    Write($"{i} ");
                }
                WriteLine("");
            }
            WriteLine("");

            int[][] jagged2 = new int[2][]
            {
                new int[]{1000,2000},
                new int[4]{6,7,8,9},
            };
            foreach (int[] arr in jagged2)
            {
                WriteLine($"Length : {arr.Length}, ");
                foreach (int i in arr)
                {
                    Write($"{i} ");
                }
                WriteLine("");
            }
            WriteLine("");

            //p400
            ArrayList list = new ArrayList();
            for(int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            foreach(object obj in list)
            {
                Write($"{obj} ");
            }
            WriteLine();

            list.RemoveAt(2);
            foreach (object obj in list)
            {
                Write($"{obj} ");
            }
            WriteLine();

            list.Insert(2, 2);
            foreach (object obj in list)
            {
                Write($"{obj} ");
            }
            WriteLine();

            list.Add("abc");
            list.Add("def");
            foreach (object obj in list)
            {
                Write($"{obj} ");
            }
            WriteLine();

            //p403
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while(que.Count > 0 )
                WriteLine(que.Dequeue());
            WriteLine();

            //p405
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
                WriteLine(stack.Pop());

            ReadLine();
        }
    }

}
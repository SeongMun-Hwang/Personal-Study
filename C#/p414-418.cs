using static System.Console;
using System;
using System.Collections;
namespace CsConsole
{
    class MainApp
    {
        //p414
        int[] numbers = { 1, 2, 3, 4 };
        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;
            yield return numbers[3];
        }
        static void Main(string[] args)
        {
            //p414
            var obj= new MainApp();
            foreach (int i in obj)
                WriteLine(i);
            WriteLine();

            //p417
            MyList list =   new MyList();
            for(int i = 0; i < 5; i++)
            {
                list[i] = i;
            }
            foreach(int i in list)
            {
                WriteLine(i);
            }


            ReadLine();
        }
    }
    //p416
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;
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
                    WriteLine("Resize array length : "+array.Length);
                }
                array[index] = value;
            }
        }
        //IEnumerator 멤버
        public object Current
        {
            get { return array[position]; }
        }
        //p417
        public bool MoveNext()
        {
            if(position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        //IEnumerable 멤버
        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}
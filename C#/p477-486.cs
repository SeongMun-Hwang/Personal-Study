using static System.Console;
using System;
using System.Collections;
namespace CsConsole
{
    //p477
    delegate int MyDelegate(int a, int b);
    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    //p481
    delegate int Compare(int a, int b);
    //p484
    delegate int CompareT<T>(T a, T b);
    class MainApp
    {    
        //481
        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else return -1;
        }
        static int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a==b)
                return 0;
            else return -1;
        }
        static void BubbleSort(int[] DataSet, Compare compare)
        {
            int i = 0;
            int j = 0;
            int temp = 0;
            for(i=0;i<DataSet.Length; i++)
            {
                for(j=0;j<DataSet.Length-1;j++)
                {
                    if (compare(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
        //p484
        static int AscendCompareT<T>(T a,T b)where T : IComparable<T>
        {
            return a.CompareTo(b);
        }
        static int DescendCompareT<T>(T a, T b)where T : IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }
        static void BubbleSortT<T>(T[] DataSet,CompareT<T> compare)
        {
            int i = 0, j = 0;
            T temp;
            for(i = 0; i < DataSet.Length; i++)
            {
                for (j = 0; j < DataSet.Length - 1; j++)
                {
                    if (compare(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp= DataSet[j + 1];
                        DataSet[j + 1]= DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //p478
            Calculator cal= new Calculator();
            MyDelegate Callback;

            Callback=new MyDelegate(cal.Plus);
            WriteLine(Callback(3, 4));

            Callback = new MyDelegate(cal.Minus);
            WriteLine(Callback(7, 5));
            WriteLine();

            //482
            int[] array = { 3, 7, 4, 2, 10 };
            WriteLine("Sorting Ascending...");
            BubbleSort(array,new Compare(AscendCompare));

            for (int i = 0; i < array.Length; i++)
                Write(array[i] + " ");
            WriteLine();

            int[] array2 = { 7, 2, 8, 10, 11 };
            WriteLine("Sorting Descending...");
            BubbleSort(array2, new Compare(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
                Write(array2[i] + " ");
            WriteLine();

            //p485
            int[] Tarray = { 3, 7, 4, 2, 10 };
            WriteLine("Sorting Ascending...");
            BubbleSortT<int>(Tarray, new CompareT<int>(AscendCompareT));

            for (int i = 0; i < Tarray.Length; i++)
                Write(Tarray[i] + " ");
            WriteLine();

            string[] Tarray2 = { "abc","def","ghi","jkl","mno" };
            WriteLine("Sorting Descending...");
            BubbleSortT<string>(Tarray2, new CompareT<string>(DescendCompareT));

            for (int i = 0; i < Tarray2.Length; i++)
                Write(Tarray2[i] + " ");
            WriteLine();

            ReadLine();
        }
    }
}
using static System.Console;
using System;
namespace CsConsole
{ 
    class MainApp
    {
        //p389
        static void PrintArray(System.Array array)
        {
            foreach(var e in array)
            {
                Write(e);
            }
            WriteLine();
        }
        

        static void Main(string[] args)
        {
            //p389
            char[] array = new char['Z' - 'A' + 1];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = (char)('A' + i);
            }
            PrintArray(array[..]);
            PrintArray(array[5..]);

            Range range_5_10 = 5..10;
            PrintArray(array[range_5_10]);

            Index last = ^0;
            Range range_5_last = 5..last;
            PrintArray(array[range_5_last]);

            PrintArray(array[^4..^1]);
            

            ReadLine();
        }
    }

}
using static System.Console;
using System;
using System.Collections;
namespace CsConsole
{
    //p468
    class FilterAbleException : Exception
    {
        public int ErrorNo { get; set; }
    }
    class MainApp
    {    
        static void Main(string[] args)
        {
            //p468
            WriteLine("Enter Number Between 0~10 : ");
            string input =ReadLine();
            try
            {
                int num = Int32.Parse(input);
                if (num < 0 || num > 10)
                    throw new FilterAbleException() { ErrorNo = num };
                else
                    WriteLine($"Output : {num}");
            }
            catch(FilterAbleException e) when (e.ErrorNo < 0)
            {
                WriteLine("Negative input is not allowed.");
            }
            catch(FilterAbleException e)when(e.ErrorNo > 10)
            {
                WriteLine("The number bigger than 10 is not allowed.");
            }
            WriteLine();

            //p471
            try
            {
                int a = 1;
                WriteLine(3 / --a);
            }
            catch(DivideByZeroException e)
            {
                WriteLine(e.StackTrace);
            }
            WriteLine();

            //p472
            int[] arr = new int[10];
            for(int i = 0; i < 10; i++)
            {
                arr[i] = i;
            }
            try
            {
                for(int i = 0; i < 11; i++)
                {
                    WriteLine(arr[i]);
                }
            }
            catch(IndexOutOfRangeException e)
            {
                WriteLine(e.Message);
                WriteLine(e.StackTrace);
            }
            ReadLine();
        }
    }
}
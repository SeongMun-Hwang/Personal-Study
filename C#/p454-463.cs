using static System.Console;
using System;
using System.Collections;
namespace CsConsole
{
    class MainApp
    {
        //p457
        static void DoSomething(int arg)
        {
            if (arg < 10)
                WriteLine($"arg : {arg}");
            else throw new Exception("Arg is bigger than 10");
        }

        //p462
        static int Divide(int dividend, int divisor)
        {
            try
            {
                WriteLine("Divide() Start");
                return dividend / divisor;
            }
            catch (DivideByZeroException e)
            {
                WriteLine("Divide Exception Occur");
                throw e;
            }
            finally
            {
                WriteLine("End Divide()");
            }
        }
        static void Main(string[] args)
        {
            //p454
            int[] arr = { 1, 2, 3 };
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                WriteLine($"Exception Occured : {e.Message}");
            }
            WriteLine("Exit");
            WriteLine();

            //457
            try
            {
                DoSomething(1);
                DoSomething(3);
                DoSomething(5);
                DoSomething(9);
                DoSomething(11);
            }
            catch(Exception e)
            {
                WriteLine(e.Message);
            }
            WriteLine();

            //459
            try
            {
                int? a = null;
                int b = a ?? throw new ArgumentException();
            }
            catch(ArgumentException e)
            {
                WriteLine(e);
            }
            try
            {
                int[] array = new[] { 1, 2, 3 };
                int index = 4;
                int value = array[
                    index >= 0 && index < 3
                    ? index : throw new IndexOutOfRangeException()];
            }
            catch(IndexOutOfRangeException e)
            {
                WriteLine(e);
            }
            WriteLine();

            //p462
            try
            {
                Write("Input Dividend : ");
                String temp = ReadLine();
                int dividend = Convert.ToInt32(temp);

                Write("Input Dividend : ");
                temp = ReadLine();
                int divisor = Convert.ToInt32(temp);

                WriteLine("{0}/{1} = {2}", dividend, divisor, Divide(dividend, divisor));
            }
            catch(FormatException e)
            {
                WriteLine("Error : " + e.Message);
            }
            catch(DivideByZeroException e)
            {
                WriteLine("Error : " + e.Message);
            }
            finally
            {
                WriteLine("Close Program");
            }

            ReadLine();
        }
    }
}
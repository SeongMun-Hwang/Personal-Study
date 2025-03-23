using static System.Console;
using System;
namespace CsConsole
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p392
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Write($"[{i}, {j}] : {arr[i, j]} ");
                }
                WriteLine();
            }
            WriteLine();

            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Write($"[{i}, {j}] : {arr2[i, j]} ");
                }
                WriteLine();
            }
            WriteLine();

            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Write($"[{i}, {j}] : {arr3[i, j]} ");
                }
                WriteLine();
            }
            WriteLine();

            //p395
            int[,,] array = new int[4, 3, 2]
            {
                {{1,2},{3,4},{5,6 } },
                {{1,4},{2,5},{3,6 } },
                {{6,5},{4,3},{2,1 } },
                {{6,3},{5,2},{4,1 } }
            };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Write("{ ");
                    for(int k=0; k<array.GetLength(2); k++)
                    {
                        Write($"{array[i,j,k]} ");
                    }
                    Write("} ");
                }
                WriteLine();
            }
            ReadLine();
        }
    }

}
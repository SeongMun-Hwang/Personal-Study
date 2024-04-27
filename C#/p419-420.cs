using static System.Console;
using System;
using System.Collections;
namespace CsConsole
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //p419
            int[,] A = { { 3, 2 }, { 1, 4 } };
            int[,] B = { { 9, 2 }, { 1, 7 } };
            int[,] C = new int[A.GetLength(0), B.GetLength(1)];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < A.GetLength(1); k++)
                    {
                        sum += A[i, k] * B[k, j];
                    }
                    C[i, j] = sum;
                    Write($"{C[i, j]} ");
                }
                WriteLine();
            }
            //p420
            Hashtable ht = new Hashtable();
            ht["회사"] = "Microsoft";
            ht["URL"] = "www.microsoft.com";

            WriteLine("회사 : {0}", ht["회사"]);
            WriteLine("URL : {0}", ht["URL"]);

            ReadLine();
        }
    }
}
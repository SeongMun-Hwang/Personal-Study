using static System.Console;
using System;
namespace CsConsole
{ 
    class MainApp
    {
        //p385
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }
        private static void Print(int value)
        {
            Write($"{value} ");
        }

        static void Main(string[] args)
        {
            //p379
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[^2] = 90;
            scores[^1] = 34;

            int sum = 0;
            foreach(int i in scores)
            {
                Write($"{i} ");
                sum += i;
            }
            WriteLine($"Average is {sum / scores.Length}");
            WriteLine();

            //p385
            Array.Sort(scores);
            Array.ForEach<int>(scores,new Action<int>(Print));
            WriteLine();

            WriteLine($"Number of dimesions : {scores.Rank}");
            WriteLine($"Binary Search : 81 is at " + $"{Array.BinarySearch<int>(scores, 81)}");

            WriteLine("Linear Search : 90 is at " + $"{Array.IndexOf(scores, 90)}");
            WriteLine($"Everyone passed ? :" + $"{Array.TrueForAll<int>(scores, CheckPassed)}");
            WriteLine();

            //p386
            int index = Array.FindIndex<int>(scores, (score) => score < 60);
            scores[index] = 61;
            WriteLine($"Everyone passed ? :" + $"{Array.TrueForAll<int>(scores, CheckPassed)}");
            WriteLine("Old length of socres : " + $"{scores.GetLength(0)}");

            Array.Resize<int>(ref scores, 10);
            WriteLine($"New lenght of scores : {scores.Length}");
            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine();

            Array.Clear(scores, 3, 7);
            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine();

            int[] sliced = new int[3];
            Array.ForEach<int>(sliced, new Action<int>(Print));
            WriteLine();

            Array.Copy(scores, 0, sliced, 0, 3);
            Array.ForEach<int>(sliced, new Action<int>(Print));

            ReadLine();
        }
    }

}
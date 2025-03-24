using System;

class Program
{
    static int N;
    static int[] numbers;
    static int maxValue;
    static int minValue;

    static void DFS(int idx, int currentValue, int add, int sub, int mul, int div)
    {
        if (idx == N)
        {
            maxValue = Math.Max(maxValue, currentValue);
            minValue = Math.Min(minValue, currentValue);
            return;
        }

        if (add > 0)
        {
            DFS(idx + 1, currentValue + numbers[idx], add - 1, sub, mul, div);
        }
        if (sub > 0)
        {
            DFS(idx + 1, currentValue - numbers[idx], add, sub - 1, mul, div);
        }
        if (mul > 0)
        {
            DFS(idx + 1, currentValue * numbers[idx], add, sub, mul - 1, div);
        }
        if (div > 0)
        {
            int nextValue = (currentValue < 0) ? -(-currentValue / numbers[idx]) : currentValue / numbers[idx];
            DFS(idx + 1, nextValue, add, sub, mul, div - 1);
        }
    }

    static void Main()
    {
        N = int.Parse(Console.ReadLine());
        numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] operators = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        maxValue = int.MinValue;
        minValue = int.MaxValue;

        DFS(1, numbers[0], operators[0], operators[1], operators[2], operators[3]);

        Console.WriteLine(maxValue);
        Console.WriteLine(minValue);
    }
}

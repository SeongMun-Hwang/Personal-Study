using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] T = new int[N + 1];
        int[] P = new int[N + 1];
        int[] dp = new int[N + 2]; // N+1일까지 고려

        for (int i = 1; i <= N; i++)
        {
            string[] input = Console.ReadLine().Split();
            T[i] = int.Parse(input[0]);
            P[i] = int.Parse(input[1]);
        }

        for (int i = 1; i <= N; i++)
        {
            // 현재까지의 최대 수익을 다음 날에도 유지
            dp[i + 1] = Math.Max(dp[i + 1], dp[i]);

            // 현재 상담을 진행할 수 있는 경우
            if (i + T[i] <= N + 1)
            {
                dp[i + T[i]] = Math.Max(dp[i + T[i]], dp[i] + P[i]);
            }
        }

        Console.WriteLine(dp[N + 1]);
    }
}


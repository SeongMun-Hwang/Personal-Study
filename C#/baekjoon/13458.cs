using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 입력 받기
        int N = int.Parse(Console.ReadLine());
        int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] BC = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int B = BC[0], C = BC[1];
        
        long totalSupervisors = 0;
        
        foreach (int students in A)
        {
            // 총감독관 배치
            totalSupervisors++;
            int remaining = students - B;
            
            // 부감독관 배치 (남은 인원이 있을 경우)
            if (remaining > 0)
            {
                totalSupervisors += (remaining + C - 1) / C; // 올림 계산
            }
        }
        
        Console.WriteLine(totalSupervisors);
    }
}

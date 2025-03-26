using System;

//알고리즘에서 완전수 : 자신을 제외한 약수의 합이 자신과 같은 수 
// 6 = 1 + 2 + 3 

class PerfectNumber
{
    static void Main()
    {
        int sum = 0;
        int count = 0;
        int max = 0;

        for (int i = 2; i <= 10000; i++)
        {
            sum = 0; //매 반복마다 초기화 목적 
            max = i / 2; //모든 짝수를 2로 나누면 가장 큰 약수가 나옴 

            for (int j = 1; j <= max; j++)
            {
                if (i % j == 0)
                {
                    sum += j;
                }
            }

            if (sum == i)
            {
                Console.WriteLine("완전수 :" + i); // 완전수 출력
                count++;
            }
        }

        Console.WriteLine($"완전수의 개수는: {count}");
    }
}
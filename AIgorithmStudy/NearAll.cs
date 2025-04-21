using System;
using System.Collections.Generic;

class NearAll
{
    static void Main()
    {

        //[1] Input
        int[] data = { 10, 30, 25, 18, 21, 40 };
        int target = 36;
        List<int> nears = new List<int>();
        int min = Int32.MaxValue;

        //[2] process: 차이의 최솟값 구하기
        for (int i = 0; i < data.Length; i++)
        {
            int diff = Math.Abs(data[i] - target);
            if (diff < min)
            {
                min = diff;
            }
        }

        //[3] Output
        Console.WriteLine($"차이의 최솟값: {min}");

        //차이의 최솟값이 min인 값을 다시 한 번 비교 
        for (int i = 0; i < data.Length; i++)
        {
            if (Math.Abs(data[i] - target) == min)
            {
                nears.Add(data[i]);
            }
        }

        foreach (var n in nears)
        {
            Console.WriteLine(n);
        }
    }
}
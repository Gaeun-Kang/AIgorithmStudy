using System;



//학습용 기초 알고리즘 12개
//Learn about Basic Algorithm's Input-Process-Output 
//합계 알고리즘 - SumAlgorithm

class SumAlgorithm
{
    static void Main()
    {
        //input
        int[] scores = { 100, 75, 50, 73, 90, 50, 69, 88 };
        int sum = 0;

        //Process : Filter 
        for(int i = 0; i < scores.Length; i++)
        {
            if (scores[i] >= 80) 
            { sum += scores[i]; }
        }


        //output
        Console.WriteLine($"{scores.Length}명의 점수 중 80점 이상의 총점 :{sum}점");
    }

}
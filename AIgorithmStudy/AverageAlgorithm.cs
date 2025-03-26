using System;

class AverageAlgorithm
{
    //[?] n명의 점수 중엥서 80점 이상 95점 이하인 점수의 평균 
    static void Main()
    {
        //input

        int[]score = {90, 80, 65, 50, 88, 96, 70, 55};
        int sum = 0; //조건에 부합하는 점수들 더하기  
        int count = 0;//조건에 부합하는 사람 수  
        int average = 0; //평균 
        //process
        for(int i =0; i < score.Length; i++)
        {
            if(score[i] >= 80 && score[i] <= 95)
            {
                sum += score[i];
                count++;
            }
        }

        average = sum/count;

        //output
        Console.WriteLine($"80점 이상 95점 이하인 점수의 평균 :{average}");

    }
}
using System;

class Averagecount
{

//[?]5명의 학생 점수를 입력받아 전체 학생 평균 이상의 성적인 학생 수 구하기 프로그램
    static void Main()
    {
        //input

        int[]score = {85, 90, 70, 45, 88};
        int sum = 0; //점수 합계 
        int average = 0; //전체 평균 
        int beststu = 0; //성적 우수 학생(평균 이상 )

        //process
        for(int i = 0; i < score.Length; i++)
        {
            sum += score[i];
        }

        if(sum != 0) //예외처리리
        {
            average = sum/score.Length; //만약 5명 이상으로 변동되더라도 구할 수 있게 

        }

       
          for(int i = 0; i < score.Length; i++)
        {
           if(score[i]>= average)
           {
            beststu++;
           }
        }

        //output
        Console.WriteLine($"평균은{average}점이며, 우수 학생수는 {beststu}명");
    }
}
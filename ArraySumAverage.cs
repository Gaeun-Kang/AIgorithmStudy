using System;

class ArraySumAverage
{
    //[?]2차원 배열을 사용하여 점수 합계 및 평균 구하기 
    static void Main()
    {
        //순서대로 국어, 영어, 합계, 평균 
      int[,] scores = { 
        {90, 100, 0, 0}, 
        {80, 90, 0,0}, 
        {100, 80,0,0} 
    };

    for(int i = 0; i < scores.GetLength(0); i++)
    {
       scores[i,2] = scores[i,0] + scores[i,1]; //국어,영어를 더해서 합계에 넣어라
       scores[i,3] = scores[i,2] / 2;
    }

    Console.WriteLine(" 국어 영어 합계 평균");

  for(int i = 0; i < scores.GetLength(0); i++)
    {
      for(int j = 0; j < scores.GetLength(1); j++)
      {
        Console.Write($"{scores[i,j], 4} ");

      }
      Console.WriteLine();
    }
  }
}

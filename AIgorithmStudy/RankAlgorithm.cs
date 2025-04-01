using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//RankAlgorithm : 주어진 데이터의 순위를 구하는 로직 ㄴ
//순위 알고리즘 : 


namespace AIgorithmStudy
{
class RankAl
    {
        static void Main()
        {
            //[1] Input
            int[] num = { 98, 120, 135, 80, 100, 115 };
            int[] rankings = Enumerable.Repeat(1, 6).ToArray();
            //Enumerable.Repeat -> 특정 타입의 값을 특정 횟수 반복하고 싶을때 사용

            //[2] Process : Rank

            for (int i = 0; i < num.Length; i++)
            {

                for(int j = 0; j< num.Length; j++)
                {
                    if (num[i] < num[j]) //  점수 비교 
                    {
                        rankings[i]++; //본인보다 큰 점수가 나올 시 순위 1증가(=후순위로 밀린다는뜻) 
                    }
                }
            }

            //[3] Output

            for (int i = 0; i < rankings.Length; i++)
            {
                Console.WriteLine($"{num[i],3}점: {rankings[i]}등");
            }
        }
    }

    //람다식표현 
    //int[] scores = {90, 85, 100, 80,70};
    // var rankings = scores.Select(s => scores.where(ss => ss > s).Count()+ 1).ToArray;
}

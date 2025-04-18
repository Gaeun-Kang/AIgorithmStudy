using System;
//주어진 데이터에서 가장 많이 나타난 값(=최빈값) 구하기 
class ModAlgorithm
{
    static void Main()
    {
        //[1]input
        int[] scores = { 1,2,3,4,5,5 }; //최빈값 
        int[] index = new int[6]; //점수 인덱스의 개수 저장
        int max = int.MinValue; //Max 알고리즘 
        int mode = 0; //최빈값이 담길 그릇 

        //[2]process : Data -> Index -> Count -> Max

        for (int i = 0; i < scores.Length; i++)
        {
            index[scores[i]]++; 
        }

        for (int j = 0; j < index.Length; j++)
        {
            if (index[j] > max)
            {
                max = index[j];
                mode = j;
            }
        }

        //[3]output
        Console.WriteLine($"최빈값은 : {mode} - {max}번 나타남");
    }
}

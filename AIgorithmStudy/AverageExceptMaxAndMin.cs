using System;
using System.Linq; //최댓값 구하는 확장 메소드 

//[?] 최댓갑과 최솟값을 제외한 평균값을 구하자 
class AverageExceptMaxAndMin{

    static void AverageExceptMaxAndMinMain()
    {
        //Initializie, 초기화  
        //최댓값을 담고자 하는 변수는 우선 최솟값으로 초기화해야함 
        int max = int.MinValue;
        int min = int.MaxValue; 
        int sum = 0; 
        int avg = 0;

        //input
        int[] num = {10, 50, 80, 32, 90, 95, 73,};

        //process
        for(int i =0; i < num.Length; i++)
        {
            sum += num[i];

            if(num[i]> max)
            {
                max = num[i]; //점점 더 큰 값을 할당해주는 구조 
            
            }

            if (num[i] < min)
            {
                min = num[i];
            }
        }

        //최대와 최소를 제외한 평균 구하기 
        avg = (sum - max - min) / num.Length - 2;
        //output
        Console.WriteLine($"합계 : {sum}, 최댓값 : {max} , 최솟값 : {min}");
        Console.WriteLine($"최댓값과 최솟값을 뺀 평균은 : {avg}");

    }
}
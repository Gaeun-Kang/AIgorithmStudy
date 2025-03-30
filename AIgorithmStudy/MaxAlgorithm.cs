using System;
using System.Linq; //최댓값 구하는 확장 메소드 




//[?] 최댓값 알고리즘이란 : 주어진 범위와 조건내에서 가장 큰 수를 찾아내는것. 
class MaxAlgorith{

    static void MaxMain()
    {
        //Initializie, 초기화  
        //최댓값을 담고자 하는 변수는 우선 최솟값으로 초기화해야함 
        int max = int.MinValue;
       
        //input
        int[] num = {5, 10, 35, 3, 12, 87, 66};

        //process
        for(int i =0; i< num.Length; i++)
        {
            if(num[i]> max)
            {
                max = num[i]; //점점 더 큰 값을 할당해주는 구조 
            }
        }
        //output
        Console.WriteLine($"최댓값은 {num.Max()}");
        Console.WriteLine($"최댓값은 {max}");

    }
}
using System;
using System.Linq; //최댓값 구하는 확장 메소드 

//[?] 최솟값 알고리즘이란 : 주어진 범위와 조건(짝수 한정)내에서 가장 작은 수를 찾아내는것. 
class MinAlgorith{

    static void MaxMain()
    {
        //Initializie, 초기화  
        //최댓값을 담고자 하는 변수는 우선 최솟값으로 초기화해야함 
        int min = int.MaxValue;
       
        //input
        int[] num = {0b0010, 0b_0101 , 0b0011, 0b_0001}; //이진수 표기 

        //process
        for(int i =0; i< num.Length; i++)
        {
            if(num[i]< min && num[i] % 2 == 0)
            {
                min = num[i]; //점점 더 큰 값을 할당해주는 구조 
            }
        }
        //output
        Console.WriteLine($"최솟값은 {num.Where(n => n % 2 == 0).Min()}");
        Console.WriteLine($"최솟값은 {min}");

    }
}
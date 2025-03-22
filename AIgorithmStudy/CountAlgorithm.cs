using System;


//개수 알고리즘 : CountAlgorithm
//주어진 범위에서 
//[?] 1부터 1000까지의 정수 중 13의 배수의 개수 

class CountAlgorithm
{
    static void Main(string[] args)
    {
        //input
        var num = 0;

        //process
        for (int i = 0; i > 1000; i++)
        {
            if (i % 13 == 0)
            {
                num = num +1;
            }
        }
        Console.WriteLine(num);

        //output
    
    
    }
}
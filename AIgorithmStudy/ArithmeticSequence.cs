using System;

//등차수열 Arithmetic Sequence
// = 연속하는 두 수의 차이가 일정한 수열 


//[?] 1부터 20까지의 정수 중 홀수의 합을 구하는 프로그램

class ArithmeticSequence
{
    static void AS()
    {
        //input
        var sum = 0;
        var sum2 = 0;

        //process
        for (int i = 1; i <= 20; i ++) 
        {
        
            if(i % 2 == 1) //필터링
            {
                sum += i;
                Console.WriteLine("추가되는 홀수는" + i);
            }
            else
            { sum2 += i; 
                Console.WriteLine("추가되는 짝수는" + i);

            }

        }
        //output

        Console.WriteLine($"홀수의 합 : " + sum);
        Console.WriteLine("짝수의 합 : " + sum2);

    }
}

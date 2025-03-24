using System;

//소수 개수를 구하는 알고리즘 
//정수 하나를 입력받아서 2붵 해당 수까지 소수 개수를 구하는 알고리즘
class PrimeNumberCount
{
 
    static void PrimeNumberCount()
    {
        //Input
        var number = 0;
        bool sw = true; //소수(true)인지 아닌지 확인 
        Console.WriteLine("수를 입력하세요 : _\b");
        number = Convert.ToInt32(Console.ReadLine());

        //Process
        
        for(i = 0; i < number; i++) //2부터 number까지 반복하면서 소수 판별
        {
            sw = true;
            //2부터 i(현재수) - 1까지 나누었을 때 나누어 떨어지면 소수가 아님
            for(int j = 2; j < i; j++)
            {
                if(i % j ==0)
                {
                    sw = false;
                    break;
                }
            }
        }

        if (sw)
        {
            Console.Write($"i\t");
            Count++;

            if(Count % 5 == 0)
            {
                Console.WriteLine(); //줄바꿈 
            }
        }

        //OutPut
        Console.WriteLine($"2부터 {number}까지의 소수의 개수는 :{count}");

    }



}
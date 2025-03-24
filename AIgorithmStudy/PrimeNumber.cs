using System;

// 특정 수를 입력 받아서 소수인지 아닌지 판별하는 프로그램 
// 소수(Prime Number) : 자연수 중에서 1과 자기 자신만을 약수로 가지는 자연수

// 소수를 구하는 법 : 2부터 해당 수까지 나머지값을 구해서 나머지 값이 0일때 나눈 수가 해당 수라면 소수
//

class PrimeNumber
{
    static void Main()
    {
        //input
        var number = 0;
        Console.Write("수를 입력해주세요 : _\b");
        number = Convert.ToInt32(Console.ReadLine());

        //process
        //2부터 n까지 나누어 떨어지는 수가 발생할 때 까지 반복 
        var i = 1;
        do
        {
            i = i+ 1; //2부터 반복
            Console.WriteLine($"{number} % {i} = {number % i}");
        } while (number % i != 0);

        //output
        
        if(number == i)
        {
            Console.WriteLine("소수");
        }else
        {  Console.WriteLine("소수가 아님");}
    }


}
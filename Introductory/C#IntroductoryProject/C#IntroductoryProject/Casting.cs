using System;

namespace C_IntroductoryProject
{
    internal class Casting
    {

        //casting
        //암시적 형변환 : 작은 자료형 -> 큰 자료형 (ex: float -> double) 손실x
        //명시적 형변환 : 큰 자료형 -> 작은 자료형(ex: dobule ->flaot) 손실o

        static void Main(string[] args)
        {
            //1. 암시적 형변환 
            int num = 2147483647;
            long bigNum = num;
            Console.WriteLine(bigNum);


            //2. 명시적 형변환 

            double x = 1234.5;
            int a;

            a=(int)x;
            Console.WriteLine(a); //결과값으로 소숫점자리 아래가 손실됨 
        
        }
        

    }
}

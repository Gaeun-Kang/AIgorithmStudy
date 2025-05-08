using System;

namespace C_IntroductoryProject
{
    class ConsoleWrite
    {
        static void Main(string[] args)
        {

            //-------------변수 연습----------------------------------------------------

            int a = 10;
            int b = 20;

            Console.WriteLine(a == b); //당연히 false 


            //-------------Console.WriteLine 메소드로 여러개의 값 출력하기-------------
            //String.Format() : 문자열을 만들 수 있음

            string primes;
            primes = String.Format("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            //Console.WriteLine("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7); 과 동일합니다.



            //---------output more than 2 var ---------------------------------------

            int v1 = 100;
            double v2 = 1.34;

            //1. 각각 문자열로 바꾸어 연결하기
            Console.WriteLine(v1.ToString() + ", " + v2.ToString());
            Console.WriteLine("v1 =" + v1 +", v2 = " +  v2);
            //2. 형식 정보를 사용하여 여러개의 변수 값 출력
            Console.WriteLine($"v1 = {v1}. v2 = {v2}");
            

            Console.WriteLine(primes);

            Console.Write("나이를 알려주세요");
            string age = Console.ReadLine();
            Console.WriteLine(age);
            Console.Write("키를 알려주세요");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine(height);

        }

    }
}

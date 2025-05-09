using System;


namespace C_IntroductoryProject
{
    internal class ArithmeticOperators
    {
        //산술연산자
        //그냥 한 번씩 정리하기 

        static void Main(string[] args)
        {
            Console.WriteLine("정수의 계산");
            Console.WriteLine(123 + 45);
            Console.WriteLine(123 - 45);
            Console.WriteLine(123 * 45);
            Console.WriteLine(123 / 45);
            Console.WriteLine(123 % 45); //나머지


            //DividByZeroException : 산술 연산자에서 나올 수 있는 에러
            // 0으로 나눔예외
          
            
            int x = 10, y = 0;
            
            Console.WriteLine(10.0 / y);
            //Console.WriteLine(x/y);
            
            //실수를 0으로 나누기 때문에 처리됮 않은 예외가 출력된다.
            //이 때 try-catch문을 사용하면 예외처리가 된다.

            try
            {
                Console.WriteLine(x / y);

            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }


        }


    }
}

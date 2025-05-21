using System;


namespace C_IntroductoryProject
{
    class ConditionalOperator
    {

        //조건연산자 : C# 연산자 중 유일하게 3개의 항을 가짐 
        //if-else 구성이 필요한 계산을 더 간결하게 표현 가능 
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            
            string result = (input > 0) ? "양수입니다." : "음수입니다."; //if문 대신에 1줄로 간단하게 쓸 수 있게 되는것임 
            Console.WriteLine("{0}는 {1}", input, result);
            Console.WriteLine("{0}는 {1}", input,
                (input % 2 ==0 )? "짝수입니다." : "홀수입니다.");


        }


    }
}

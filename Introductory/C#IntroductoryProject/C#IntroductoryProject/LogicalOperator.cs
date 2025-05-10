using System;

namespace C_IntroductoryProject
{
    internal class LogicalOperator
    {

        //논리연산자 
        //&&, ||, ^, !
        //And, OR, 배타적 OR, NOT
        static void Main(string[] args)
        {
            bool result;
            int first = 10, second = 20;

            if (result = (first == second) || (first > 5))
            {
                Console.WriteLine("반은 맞음 ");
            }
            else if (result = (first == second) && (second > 5)) 
            {
                Console.WriteLine("출력되지 않을것입니다. first == second가 애초에 틀리므로. ");
            
            }

            //^은
            //두 값 중 하나만 참일 때 참을 반환하고, 두 값 모두 참 또는 모두 거짓일 때 거짓을 반환하는 연산자

            result = true ^ false; //true는 true이므로, 하나가 참인 조건을 만족하므로 true 반환 
            Console.WriteLine(result);

            //! = not 
            result = !(first > second); //first : 10, second: 20
            Console.WriteLine(result); //따라서 true 반환


        }



    }
}

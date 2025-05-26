using System;

namespace C_IntroductoryProject
{
    class StringContain
    {
        static void Main(string[]args)
        {

            //Contatin()
            //string에 특정 문자열이 포함되어있는지 체크해주는 역할
            //대소문자 구분 O 

            Console.WriteLine("당신은 누구십니까? : ");
            string s = Console.ReadLine();
            string check = "Gaeun";
            bool b = s.Contains(check);

            if(b == true)
            {
                //IndexOF()메소드
                //문자열에서 특정 문자 또는 문자열이 나타나는 인덱스를 리턴(0부터 시작), 문자열이 없으면 -1 리턴 

                int index = s.IndexOf(check);


                Console.WriteLine(index);
                Console.WriteLine("어서오세요, {0}님", s);
            }
 
            

            //StringComparision
            // 대소문자 구분 x 




        }

    }
}

using System;


namespace C_IntroductoryProject
{
    class StringMethods
    {

        static void Main(string[] args)
        {

            //String.Split() 메소드 
            //특정 문자를 기준으로 문자열을 나눠주는 함수 

            StringConcat();

            Console.Write("더하려고 하는 숫자들을 입력 :");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split();

            foreach(var i in v) //몇 개나 입력될지 알수없으므로 foreach 구문 사용해서 해결 
            {
                sum += int.Parse(i);
            }
            Console.WriteLine("결과는 {0}", sum);

        }

        static void StringConcat()
        {

            string[] food = { "Apple", "meat", "Drinks", "Cake" };

            //문자열을 연결하는 네가지 방법
            //1 + 연산자 

            Console.Write(" 이름을 입력하시오 :");

            string userName = Console.ReadLine();

            string date = DateTime.Today.ToShortDateString();
            string strPlus = "Hello , " + userName + date;

            Console.WriteLine(strPlus);

            //2. 문자열 보간(string Interpolation) : $문자 사용
            string inter = $"Hello {userName}. {date}.";
            Console.WriteLine(inter);

            // 3. String.Format 

            string strFormat = String.Format("Hello {0}, {1}.", userName,date);
            Console.WriteLine(strFormat);

            // 4. String.Concat() String.Join()

            Console.WriteLine(String.Concat("I", "have", " a", "Dream"));


            //Join()은 구분 기호 표시도 가능함

            string t = String.Join(",", food);
            Console.WriteLine(t);
            

        }


    }
}

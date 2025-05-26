using System;
using System.Diagnostics;
using System.Text;


namespace C_IntroductoryProject
{
    class StringBuilderStudy
    {

        static void Main(string[]args)
        {
            //string과 string builder 클래스의 차이
            //string : 불변, 한 번 만들면 변경 불가
            //stringBuilder : 가변, 자주 변경되는 스트링에 용이

            StringBuilder sb = new StringBuilder("StringBuilder Test Text");
            //객체값을 String으로 변환, 길이 
            Console.WriteLine("{0} {1} characters", sb.ToString(), sb.Length);

            //초기화
            sb.Clear();

            sb.Append("This is a new String");
            Console.WriteLine("{0} {1} characters", sb.ToString(), sb.Length);

            sb.Insert(5, "끼어들기!", 2);
            Console.WriteLine("{0} {1} characters", sb.ToString(), sb.Length);

        }
    }
}

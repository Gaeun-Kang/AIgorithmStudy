using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_IntroductoryProject
{
    internal class ValueAndRef
    {

        static void Main(string[] args)
        {
            //value (값) : 변수가 실제 데이터 값을 저장하는 형식
            //int, double,char,enum,struct 등...
            
            //ref (참조) : 변수가 값이 저장되어 있는 곳의 위치를 저장하는 형식 (c언어의 포인터와 유사)
            //

            string s = "before passing";
            Console.WriteLine(s);

            Test(s);
            //Main의 string s는  값이 변하지 않음 
            Console.WriteLine(s);

            Test(ref s);
            //ref 키워드로 인해 Main에서도 값이 변함 
            Console.WriteLine(s);

            //배열과 객체의 메소드 매개변수
            //배열 : 참조형! 즉, Main에도 바로 반영이 된다. 

            int[] arr = { 10, 20, 30, };
            Console.WriteLine("Main() before : arr[0] = {0}", arr[0]);

            //배열의 이름을 매개변수로 호출, 배열의 이름은 참조형이므로 Main에도 반영 
            Change(arr);
            Console.WriteLine("Main() after : arr[0] = {0}", arr[0]);

        }

        private static void Change(int[] arr)
        {
            arr[0] = -10;
        }

        public static void Test(string s) 
        {
            s = "Test"; 
        
        }

        public static void Test(ref string s)
        {
            s = "Test";
        }
    }

    class Student
    {
        public string name;
    }
}

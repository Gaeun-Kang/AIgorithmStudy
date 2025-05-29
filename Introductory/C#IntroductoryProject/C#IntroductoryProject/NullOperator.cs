using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_IntroductoryProject
{
    internal class NullOperator
    {

        //Null
        //어떤 객체도 참조하지 않는 참조형 변수 
        //참조형 변수의 디폴트 값이다. 값 형식 변수에는 할당할 수 없다! 

        //Null의 조건 연산자 "?" 
        //NullReferenceException을 방지하기 위한 연산자

        //Nullable
        //C# 2.0부터 도입되어, 값 형식의 변수에 null을 할당할 수 있게 하는 값
       
        
        
        static void Main (string[] args)
        {
            string animal = null;
            Console.WriteLine("4글자 이상인 동물의 이름만 출력");
            do
            {
                NameAnimal(animal);
                Console.WriteLine("동물 이름 :");

            } while((animal= Console.ReadLine()) != "");
        }

        private static void NameAnimal(string animal) 
        {
            if(animal?.Length >=4) //animal이 null이므로 ?연산자로 예외처리를 해줘야함. 
            {
                Console.WriteLine(animal + " :" + animal.Length);
            }

        }

        //Nullable형은 다음과 같은 구조체임 
        public struct Nullable<T> where T : struct
        {
            public bool HasValue { get; }
            public T value { get; }
        }


        //형식에 따른 기본값
        //ref : null
        //숫자값 형식: 0
        //bool : false
        //char : '\0'
        //struct : 모든 참조 형식 필드를 null로 설정하여 생성한 갑 . . . 
       

    }
}

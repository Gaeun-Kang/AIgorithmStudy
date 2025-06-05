using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_IntroductoryProject
{
    internal class Object
    {

        static void Main(string[] args)
        {
            //Boxing : 값 형식의 변수가 object 타입으로 변환되는 것
            //Unboxing : object 타입의 변수가 값 형식으로 변환되는 것을 말함 (형변환을 위한 casting 필요)

            //obejct -> 참조형식, 즉 힙에 데이터 할당 
            //값 형식(int 등) -> 스택에 데이터 할당 

            int i = 123;
            object o = i; //i의 값을 박싱하여 o로 복사
            i = i + 10; // i의 값을 
            int j = (int)o; //o의 값을 언박싱하여 j로 복사 

            //i의 값이 변해도 o에 저장된 값은 영향 받지 않음을 확인 가능

            Console.WriteLine("The value-type value i = {0}", i);
            Console.WriteLine("The value-type value o = {0}", o);
            Console.WriteLine("The value-type value j = {0}", j);

            object p = o;
            o = 100;

            Console.WriteLine("The value-type value i = {0}", i);
            Console.WriteLine("The value-type value o = {0}", o);
            Console.WriteLine("The value-type value j = {0}", j);

        }

    }
}

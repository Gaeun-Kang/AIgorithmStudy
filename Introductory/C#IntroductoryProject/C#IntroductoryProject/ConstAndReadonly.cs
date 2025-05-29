using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_IntroductoryProject
{
    //Const와 ReadOnly에 대하여
    //Const : 상수, 어려울 것 없음.


    //Readonly : 읽기 전용
    //변수를 선언하는 시점과 생성자 메소드에서만 값 변경 가능 

    class ConstEX
    {
        //const이므로 한 번 선언하면 변경 불가 
        public const int number = 3;
    }

    class ReadOnlyEx
    {
        //선언하는 시점과 생성자 메소드에서 값 변경 가능
        public readonly int number = 10;

        public ReadOnlyEx()
        {
            number = 20;
        }

        public ReadOnlyEx(int n)
        {
            number = n;
        }
    }
    internal class ConstAndReadonly
    {

  
        static void Main(string[] args)
        {
            //Const 사용 
            Console.WriteLine(ConstEX.number); 
        
            //Readonly instance 1 
            //ReadonlyEX()가 실행되면서, 20으로 할당 
            ReadOnlyEx inst1 = new ReadOnlyEx();
            Console.WriteLine(inst1.number);

            //Readonly instance 3
            //매개변수 int로 가지고 있는 생성자가 실행되면서, 100이라는 결과가 나옴
            ReadOnlyEx inst2 = new ReadOnlyEx(100);
            Console.WriteLine(inst2.number);

        }
    }
}

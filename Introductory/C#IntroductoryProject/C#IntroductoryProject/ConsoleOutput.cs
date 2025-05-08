using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_IntroductoryProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //기본 출력- 줄바꿈x, 줄바꿈o 
            Console.Write("Hello");
            Console.WriteLine("World!");

            //콘솔 입력 및 변수 저장-출력 
            Console.Write("안녕하세요! 이름을 입력해주세요");
            string name = Console.ReadLine();
            Console.Write(name + "님을 환영합니다!");
        }
    }
}

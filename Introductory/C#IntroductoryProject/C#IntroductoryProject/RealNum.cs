using System;

namespace C_IntroductoryProject
{
    class RealNum
    {

        //실수형 자료형 
        //flaot : 7, dobule : 15~16, decimal : 28~29 


        static void Main(string[] args)
        {

            //1. 정밀도 확인 : 몇 자리수까지 표현되는가 
            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3;

        
            Console.WriteLine("float :" + flt + ", double : " + dbl + ", dcm :" + dcm);

            //2 용량 확인 :  float부터 4, 8, 16바이트 
            Console.WriteLine("float : {0} bytes , double : {1} bytes, decimal : {2} bytes ", sizeof(float), sizeof(double), sizeof(decimal));

            //3.각 자료형의 최솟값과 최댓값 확인해보기 
            Console.WriteLine("float : {0}~{1}", float.MinValue, float.MaxValue);
            Console.WriteLine("dobule : {0}~{1}", double.MinValue, double.MaxValue);
            Console.WriteLine("decimal : {0}~{1}", decimal.MinValue, decimal.MaxValue);

        }
    }
}

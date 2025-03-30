using System;

namespace AIgorithmStudy
{

    //근삿값 알고리즘(Near Alogirhtm) : 차잇값의 절대값 구하기 
    class NearAlgorithm
    {

        static void Main()
        {
            //Initialize(초기화)
            int min = int.MaxValue; //차잇값의 절댓값의 최솟값이 담길 그릇 
  
            //절댓값 구하기 로컬 함수
            int Abs(int number) => (number <0) ? - number : number;

            //input
            int target = 25; //근사값이 되어줄것임 
            int near = default;
            int[] numbers = { 10, 20, 30, 40, 50, 60, };

            //process
            for (int i = 0; i < numbers.Length; i++)
            {
                int abs = Abs(numbers[i] - target);
                if(abs < min)
                {
                    min = abs;
                    near = numbers[i];
                
                }
                   

            }

            //output
            Console.WriteLine($" 주어진 수들 중 25와 가장 가까운 값은? :{near}");

        }
    }
}

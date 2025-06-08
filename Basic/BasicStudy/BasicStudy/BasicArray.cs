using System;

namespace BasicStudy
{
    class BasicArray
    {

        //배열 요소 출력해주는 method 만들기

        static void PrintArray(System.Array array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array.GetValue(i) + ",");
            }
        }
        static void Main(string[] args)
        {
            string[] food = { "Ramen", "Ice Cream", "Chicken" };
            Console.Write("food[] :");
            foreach (var value in food)
                Console.Write(value + "");


            //배열 크기 지정 
            int[] b = new int[3] { 1, 2, 3 };
            Console.Write("\nb[]:");
            for(int i = 0; i < 3; i++)
            {
                Console.Write(b[i] + "");

            }


            //Method Test
            
            int[] a = { 30, 54, 13, 62, 8, 27 };
            PrintArray(a);

            Console.WriteLine( a.Length + " ,");
            Array.Sort(a);
            Console.WriteLine("오름차순");
            PrintArray(a);

            Console.WriteLine("내림차순");
            Array.Reverse(a);
            PrintArray(a);


            int[] c = new int[10];
            Array.Copy(a, 0, c, 1, 5); //a 배열 0번부터 5개의 요소를 c 배열 1번 인덱스에 copy
            PrintArray(c);


            Console.WriteLine("초기화");
            Array.Clear(a, 0, a.Length);
            PrintArray(a);

        }
        
    }
}

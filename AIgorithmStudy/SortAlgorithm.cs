using System;

//SortAlgorithm : 정렬 알고리즘 - SelectSort 
// 

class SortAlgorithm
{
    static void Main()
    {
        //[1] Input : Data Structure (Array, List ,Stack ... etc)

        int[] data = {10, 30, 23, 56, 79};
        int N = data.Length; //슈도코드 

        //[2]Process : Selection Sort
        for (int i = 0; i < N - 1; i++) // i = 0 to N -1
        {
            for(int j = i+1; j < N; j++) //j = i + 1 to N
            {
                if (data[i] > data[j]) //오름차순이면 >, 내림차순이면 < 인 것.
                {
                    //수합코드                     
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }
        }

        //[3]Output : Console, Deesktop, Web ... etc 
        for(int i = 0; i < N; i++)
        {
            Console.Write($"{data[i]}\t");

        }
            Console.WriteLine();
    }
}
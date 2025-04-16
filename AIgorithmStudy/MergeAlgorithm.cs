using System;

//2개의 정수 배열 합치기 : 단, 2개의 배열은 오름차순으로 정렬되어있다고 가정 
//Merge Algorithm : 오름차순으로 정렬되어 있는 정수 배열을 하나로 병합 

class MergeAlgorithm
{
    static void Main()
    {
        //[1] Input

        int[] first = { 1, 2, 3, 4, 5, 6, };
        int[] second = { 10, 11, 12, 13, };
        int M = first.Length;
        int N = second.Length;

        int[] merge = new int[M + N];
        int i = 0; int j = 0; int k = 0;

        //[2] Process, 두 배열을 하나로 합치는 과정 Merge

        while(i < M && j < N) //둘 중 하나라도 배열의 끝에 도달할 때 까지
        {
            if (first[i] <= second[j]) //더 작은 값을 merge 배열에 저장
            {
                merge[k++] = first[i++];
            }
            else
            {
                merge[k++] = second[j++];
            }
        }
        while(i<M)
        {
            merge[k++] = first[i++];
        }
        while (j<N)
        {
            merge[k++] = second[j++];
        }


        //[3] Output
        foreach (var m in merge)
        {
            Console.Write($"{m}\t");
        }
        Console.WriteLine();
        
    }
}
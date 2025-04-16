using System;

//2���� ���� �迭 ��ġ�� : ��, 2���� �迭�� ������������ ���ĵǾ��ִٰ� ���� 
//Merge Algorithm : ������������ ���ĵǾ� �ִ� ���� �迭�� �ϳ��� ���� 

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

        //[2] Process, �� �迭�� �ϳ��� ��ġ�� ���� Merge

        while(i < M && j < N) //�� �� �ϳ��� �迭�� ���� ������ �� ����
        {
            if (first[i] <= second[j]) //�� ���� ���� merge �迭�� ����
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
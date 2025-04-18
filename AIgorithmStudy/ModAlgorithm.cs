using System;
//�־��� �����Ϳ��� ���� ���� ��Ÿ�� ��(=�ֺ�) ���ϱ� 
class ModAlgorithm
{
    static void Main()
    {
        //[1]input
        int[] scores = { 1,2,3,4,5,5 }; //�ֺ� 
        int[] index = new int[6]; //���� �ε����� ���� ����
        int max = int.MinValue; //Max �˰��� 
        int mode = 0; //�ֺ��� ��� �׸� 

        //[2]process : Data -> Index -> Count -> Max

        for (int i = 0; i < scores.Length; i++)
        {
            index[scores[i]]++; 
        }

        for (int j = 0; j < index.Length; j++)
        {
            if (index[j] > max)
            {
                max = index[j];
                mode = j;
            }
        }

        //[3]output
        Console.WriteLine($"�ֺ��� : {mode} - {max}�� ��Ÿ��");
    }
}

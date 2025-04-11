using System;


//serach Algorithm : 검색 알고리즘
// 특정 데이터 베이스에서 특정한 값이나 문자열이 있는지 찾는 것 
// 이진 검색을 사용 (이분 탐색, 반 씩 나눠서 검색)
public class SerachAlgorithm
{
	static void Main()
	{
		//[1] input
		int []Data = { 30, 10, 45, 80, 75, 20, 99,105 }; //정돈되어있지 않음
		int N = Data.Length;
		int search = 99; //찾으려고 하는 데이터
		int index = -1; //인덱스 변수 : 찾은 위치 
		
		bool find = false;


		//[2] process : 이진 검색(Binary Search)

		//우선 오름차순으로 만들어주자 
		for(int i = 0; i < N - 1; i++)
		{
			for(int j = i + 1; j < N; j++)
			{
				if (Data[i] > Data[j]) 
				{
					int temp = Data[i];
					Data[i] = Data[j];
					Data[j] = temp;
				}
			}
		}

        for (int i = 0; i < N; i++)
        {
            Console.Write($"{Data[i]}\t");

        }

        int low = 0; //min
		int high = N - 1; //max 
		
		while(low <= high)
		{
			int mid = (low + high) / 2;
			if (Data[mid] == search)
			{
				find = true;
				index = mid;
				break;
			}
			if (Data[mid]>search)
			{
				high = mid - 1;
			}
			else
			{
				low = mid + 1;
			}
		}
	
			//[3] output

		if(find)
		{
			Console.WriteLine($"{search}을(를) {index}위치에서 찾았습니다.");
		}
		else
		{
			Console.WriteLine("찾지 못 했습니다.");
		}
	}
}

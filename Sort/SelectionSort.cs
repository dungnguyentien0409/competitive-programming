/*
 * Problem: SelectionSort
 * Author: Dung Nguyen Tien (Chris)
*/

public static class Sort
{
	public static void SelectionSort(List<int> arr)
	{
		var Length = arr.Count;
		var min = int.MaxValue;
		var imin = 0;
		
		for(var i = 0; i < Length - 1; i++)
		{
			min = arr[i];
			imin = i;

			for (var j = i + 1; j < Length; j++)
			{
				if (arr[j] < min)
				{
					min = arr[j];
					imin = j;
				}
			}

			swap(arr, i, imin);
		}
	}

	static void swap(List<int> arr, int i, int j)
	{
		if (i == j) return;

		var tmp = arr[i];
		arr[i] = arr[j];
		arr[j] = tmp;
	}
}
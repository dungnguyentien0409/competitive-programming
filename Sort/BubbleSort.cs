/*
 * Problem: BubbleSort
 * Author: Dung Nguyen Tien (Chris)
*/

public static void BubbleSort(List<int> arr)
{
	var noSwap = true;
	for (var length = arr.Count; length > 0; length--)
	{
		noSwap = true;
		for (var i = 0; i < length - 1; i++)
		{
			if (arr[i] > arr[i + 1])
			{
				noSwap = false;
				Swap(arr, i, i + 1);
			}
		}

		if (noSwap) break;
	}
}

public static void Swap(List<int> arr, int x, int y)
{
	if (x == y) return;

	var tmp = arr[x];
	arr[x] = arr[y];
	arr[y] = tmp;
}
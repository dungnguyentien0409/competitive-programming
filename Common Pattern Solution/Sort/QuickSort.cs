/*
 * Problem: QuickSort
 * Author: Dung Nguyen Tien (Chris)
*/

public static void QuickSort(List<int> arr, int left, int right)
{
	if (left < right)
	{
		var pivot = Partition(arr, left, right);

		QuickSort(arr, 0, pivot - 1);
		QuickSort(arr, pivot + 1, right);
	}
}

public static int Partition(List<int> arr, int left, int right)
{
	var pivot = arr[right];
	var i = left - 1;

	for (var j = left; j < right; j++)
	{
		if (arr[j] < pivot)
		{
			i++;
			Swap(arr, i, j);
		}
	}

	Swap(arr, i + 1, right);
	return i + 1;
}

public static void Swap(List<int> arr, int x, int y)
{
	if (x == y) return;

	var tmp = arr[x];
	arr[x] = arr[y];
	arr[y] = tmp;
}
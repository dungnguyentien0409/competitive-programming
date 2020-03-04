/*
 * Problem: HeapSort
 * Author: Dung Nguyen Tien (Chris)
*/

public class Sort
{
	public static void Heapify(List<int> arr, int n, int i)
	{
		var left = 2 * i;
		var right = 2 * i + 1;
		var imax = i;

		if (left < n && arr[left] > arr[imax]) imax = left;
		if (right < n && arr[right] > arr[imax]) imax = right;

		if (imax == i) return;
		else if (imax == left)
		{
			Swap(arr, left, i);
			Heapify(arr, n, left);
		}
		else if (imax == right)
		{
			Swap(arr, right, i);
			Heapify(arr, n, right);
		}
	}

	public static void BuildHeap(List<int> arr)
	{
		var n = arr.Count / 2 - 1;

		for (var i = n; i >= 0; i--)
		{
			Heapify(arr, arr.Count, i);
		}
	}

	public static void HeapSort(List<int> arr)
	{
		BuildHeap(arr);

		for (var i = arr.Count - 1; i >= 0; i--)
		{
			Swap(arr, i, 0);
			Heapify(arr, i, 0);
		}
	}

	public static void Swap(List<int> arr, int x, int y)
	{
		if (x == y) return;

		var tmp = arr[x];
		arr[x] = arr[y];
		arr[y] = tmp;
	}
}
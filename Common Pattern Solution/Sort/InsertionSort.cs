/*
 * Problem: InsertionSort
 * Author: Dung Nguyen Tien (Chris)
*/

public static void InsertionSort(List<int> arr)
{
	for (var i = 1; i < arr.Count; i++)
	{
		var index = BinarySearch(new List<int>(arr.GetRange(0, i - 1)), arr[i]);

		if (index != i)
		{
			var tmp = arr[i];
			arr.RemoveAt(i);
			arr.Insert(index, tmp);
		}
	}
}

public static int BinarySearch(List<int> arr, int target)
{
	if (arr.Count == 0) return 0;

	var left = 0;
	var right = arr.Count - 1;

	while (left < right)
	{
		var mid = (left + right) / 2;

		if (arr[mid] < target) left = mid + 1;
		else right = mid;
	}

	if (arr[left] < target) return left + 1;
	return left;
}
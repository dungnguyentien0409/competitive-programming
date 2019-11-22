/*
 * Problem: MergeSort
 * Author: Dung Nguyen Tien (Chris)
*/

public static List<int> MergeSort(List<int> arr)
{
	if (arr.Count > 1)
	{
		var mid = arr.Count / 2;
		var len1 = mid;
		var len2 = arr.Count - len1;
		
		var leftArr = new List<int>(arr.GetRange(0, len1));
		var rightArr = new List<int>(arr.GetRange(mid, len2));

		return Merge(MergeSort(leftArr), MergeSort(rightArr));
	}

	return arr;
}

public static List<int> Merge(List<int> leftArr, List<int> rightArr)
{
	var sortedArr = new List<int>();

	while (leftArr.Count > 0 && rightArr.Count > 0)
	{
		if (leftArr[0] < rightArr[0])
		{
			sortedArr.Add(leftArr[0]);
			leftArr.RemoveAt(0);
		}
		else
		{
			sortedArr.Add(rightArr[0]);
			rightArr.RemoveAt(0);
		}
	}

	while(leftArr.Count > 0)
	{
		sortedArr.Add(leftArr[0]);
		leftArr.RemoveAt(0);
	}

	while(rightArr.Count > 0)
	{
		sortedArr.Add(rightArr[0]);
		rightArr.RemoveAt(0);
	}

	return sortedArr;
}
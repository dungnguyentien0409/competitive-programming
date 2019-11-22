/*
 * Problem: RadixSort
 * Author: Dung Nguyen Tien (Chris)
*/

public class Sort
{
	public static List<int> RadixSort(List<int> arr)
	{
		var max = GetMax(arr);

		for (var i = 0; i < max; i++)
		{
			var buckets = CreateBuckets();
			for (var j = 0; j < arr.Count; j++)
			{
				buckets[GetDigit(arr[j], i)].Add(arr[j]);
			}

			arr = new List<int>();
			foreach (var range in buckets) arr.AddRange(range);
		}

		return arr;
	}

	public static List<List<int>> CreateBuckets()
	{
		var buckets = new List<List<int>>();

		for (var i = 0; i < 10; i++) buckets.Add(new List<int>());

		return buckets;
	}

	public static int GetMax(List<int> arr)
	{
		var max = 0;

		for (var i = 0; i < arr.Count; i++)
		{
			if (arr[i].ToString().Length > max)
				max = arr[i].ToString().Length;
		}

		return max;
	}

	public static int GetDigit(int n, int i)
	{
		return (n / (int)Math.Pow(10, i)) % 10;
	}
}
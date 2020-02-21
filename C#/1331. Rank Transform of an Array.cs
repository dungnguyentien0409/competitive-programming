/*
 * Link: https://leetcode.com/problems/rank-transform-of-an-array/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        var len = arr.Length;
        var sorted = (int[])arr.Clone();
        Array.Sort(sorted, delegate(int a, int b) {
            return a - b;
        });
        var map = new Dictionary<int, int>();
        
        for (var i = 0; i < len; i++) {
            if (!map.ContainsKey(sorted[i])) {
                map.Add(sorted[i], map.Count + 1);
            }
        }
        
        for (var i = 0; i < len; i++) {
            arr[i] = map[arr[i]];
        }
        
        return arr;
    }
}
/*
 * Link: https://leetcode.com/problems/4sum-ii/
 * Author: Dung Nguyen Tien (Chris)
*/
public class Solution {
    public int FourSumCount(int[] A, int[] B, int[] C, int[] D) {
        var map = new Dictionary<int, int>();
        int count = 0, N = A.Length;
        
        for (var i = 0; i < N; i++) {
            for (var j = 0; j < N; j++) {
                var sum = A[i] + B[j];
                
                if (!map.ContainsKey(sum)) map.Add(sum, 0);
                map[sum]++;
            }
        }
        
        for (var i = 0; i < N; i++) {
            for (var j = 0; j < N; j++) {
                var sum = -(C[i] + D[j]);
                
                if (map.ContainsKey(sum)) {
                    count += map[sum];
                }
            }
        }
        
        return count;
    }
}
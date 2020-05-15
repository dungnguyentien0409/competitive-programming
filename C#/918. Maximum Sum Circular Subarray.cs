/*
 * Link: https://leetcode.com/problems/maximum-sum-circular-subarray/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxSubarraySumCircular(int[] A) {
        int sum_max = 0, f_max = Int32.MinValue;
        int sum_min = 0, f_min = Int32.MaxValue;
        int sum = 0;
        
        foreach(var n in A) {
            sum_max = Math.Max(sum_max + n, n);
            sum_min = Math.Min(sum_min + n, n);
            
            f_max = Math.Max(f_max, sum_max);
            f_min = Math.Min(f_min, sum_min);
            
            sum += n;
        }
        
        return f_max > 0 ? Math.Max(f_max, sum - f_min) : f_max;
    }
}
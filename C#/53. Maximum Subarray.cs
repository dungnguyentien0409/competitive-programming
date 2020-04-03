/*
 * Link: https://leetcode.com/problems/maximum-subarray/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxSubArray(int[] nums) {
        var max = 0;
        var f_max = Int32.MinValue;
        
        foreach(var n in nums) {
            max = Math.Max(max + n, n);
            f_max = Math.Max(max, f_max);
        }
        
        return f_max;
    }
}
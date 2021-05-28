/*
 * Link: https://leetcode.com/problems/maximum-erasure-value/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaximumUniqueSubarray(int[] nums) {
        var set = new HashSet<int>();
        int begin = 0, end = 0;
        
        int sum = 0;
        int f_sum = 0;
        while(end < nums.Length) {
            while (set.Contains(nums[end])) {
                set.Remove(nums[begin]);
                sum -= nums[begin];
                begin++;
            }
            
            set.Add(nums[end]);
            sum += nums[end];
            f_sum = Math.Max(f_sum, sum);
            
            end++;
        }
        
        return f_sum;
    }
}
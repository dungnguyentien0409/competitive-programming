/*
 * Link: https://leetcode.com/problems/minimum-operations-to-reduce-x-to-zero/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinOperations(int[] nums, int x) {
        x = nums.Sum() - x;
        
        if (x < 0) return -1;
        if (x == 0) return nums.Length;
        
        int start = 0, end = 0, d = 0;
        
        int sum = 0;
        while(end < nums.Length) {
            sum += nums[end++];
            
            while(sum >= x) {
                if (sum == x) {
                    d = Math.Max(d, end - start);
                }
                
                sum -= nums[start++];
            }
        }
        
        return d == 0 ? - 1 : nums.Length - d;
    }
}
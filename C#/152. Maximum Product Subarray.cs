/*
 * Link: https://leetcode.com/problems/maximum-product-subarray/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxProduct(int[] nums) {
        if (nums.Length == 1) return nums[0];
        
        int max = 1, min = 1, res = 0;
        foreach(var n in nums) {
            var x = max * n;
            var y = min * n;
            
            max = Math.Max(n, Math.Max(x, y));
            min = Math.Min(n, Math.Min(x, y));
            res = Math.Max(res, max);
        }
        
        return res;
    }
}
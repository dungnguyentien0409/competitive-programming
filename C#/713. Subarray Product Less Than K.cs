/*
 * Link: https://leetcode.com/problems/subarray-product-less-than-k/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        if (k == 0) return 0;
        
        int left = 0;
        int prod = 1;
        int res = 0;
        
        for (var right = 0; right < nums.Length; right++) {
            prod *= nums[right];
            
            while(prod >= k && left <= right) prod /= nums[left++];
            
            res += right - left + 1;
        }
        
        return res;
    }
}
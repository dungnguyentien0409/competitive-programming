/*
 * Link: https://leetcode.com/problems/product-of-array-except-self/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var len = nums.Length;
        var res = new int[len];
        Array.Fill(res, 1);
        
        for (var i = 1; i < len; i++) {
            res[i] = res[i - 1] * nums[i - 1];
        }
        
        var right = 1;
        for(var i = len - 1; i >= 0; i--) {
            res[i] *= right;
            right *= nums[i];
        }
        
        return res;
    }
}
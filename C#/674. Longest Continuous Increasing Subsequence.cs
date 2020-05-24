/*
 * Link: https://leetcode.com/problems/longest-continuous-increasing-subsequence/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        var res = 0;
        var count = 0;
        
        for (var i = 0; i < nums.Length; i++) {
            if (i == 0 || nums[i - 1] < nums[i]) {
                res = Math.Max(res, ++count);
            }
            else {
                count = 1;
            }
        }
        
        return res;
    }
}
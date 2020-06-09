/*
 * Link: https://leetcode.com/problems/wiggle-subsequence/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int WiggleMaxLength(int[] nums) {
        if (nums.Length < 2) return nums.Length;
        
        var count = 1;
        bool? trend = null;
        
        for (var i = 1; i < nums.Length; i++) {
            if (nums[i] > nums[i - 1] && (trend == null || trend == false)) {
                trend = true;
                count++;
            }
            else if (nums[i] < nums[i - 1] && (trend == null || trend == true)) {
                trend = false;
                count++;
            }
        }
        
        return count;
    }
}
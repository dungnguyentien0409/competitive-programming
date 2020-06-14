/*
 * Link: https://leetcode.com/problems/running-sum-of-1d-array/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] RunningSum(int[] nums) {
        for (var i = 1; i < nums.Length; i++) {
            nums[i] = nums[i - 1] + nums[i];
        }
        
        return nums;
    }
}
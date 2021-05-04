/*
 * Link: https://leetcode.com/problems/non-decreasing-array/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool CheckPossibility(int[] nums) {
        int count = 0;
        
        for(var i = 1; i < nums.Length; i++) {
            if (nums[i] < nums[i - 1]) {
                count++;
                
                //modify
                if(i - 2 < 0 || nums[i - 2] <= nums[i]) nums[i - 1] = nums[i];
                else nums[i] = nums[i - 1];
            }
        }
        
        return count <= 1;
    }
}
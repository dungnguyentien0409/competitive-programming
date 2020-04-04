/*
 * Link: https://leetcode.com/problems/remove-element/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if (nums.Length == 0) return 0;
        
        var i = 0;
        for (var j = 0; j < nums.Length; j++) {
            if (nums[j] != val) {
                nums[i] = nums[j];
                i++;
            }
        }
        
        return i;
    }
}
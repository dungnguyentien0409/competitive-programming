/*
 * Link: https://leetcode.com/problems/jump-game/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool CanJump(int[] nums) {
        if (nums.Length == 0) return true;
        
        var currentEnd = 0;
        var furthestPlace = 0;
        
        for(var i = 0; i < nums.Length; i++) {
            furthestPlace = Math.Max(furthestPlace, i + nums[i]);
            
            if (i == currentEnd) {
                if (furthestPlace >= nums.Length - 1) return true;
                currentEnd = furthestPlace;
            }
        }
        
        return false;
    }
}
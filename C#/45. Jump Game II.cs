/*
 * Link: https://leetcode.com/problems/jump-game-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int Jump(int[] nums) {
        var currentEnd = 0;
        var furthest = 0;
        var jump = 0;
        
        for(var i = 0; i < nums.Length - 1; i++) {
            furthest = Math.Max(furthest, i + nums[i]);
            
            if (i == currentEnd) {
                currentEnd = furthest;
                jump++;
            }
        }
        
        return jump;
    }
}
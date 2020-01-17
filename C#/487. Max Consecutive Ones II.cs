/*
 * Link: https://leetcode.com/problems/max-consecutive-ones-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var max = 0;
        var count = 0;
        var beforeOne = -1;
        
        for (var i = 0; i < nums.Length; i++) {
            var n = nums[i];
            
            if (n == 1) {
                count++;
            }
            else {
                count = i - beforeOne;
                beforeOne = i;
            }
            
            max = Math.Max(max, count);
        }
        
        return max;
    }
}
/*
 * Link: https://leetcode.com/problems/max-consecutive-ones/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var count = 0;
        var max = 0;
        
        foreach (var n in nums) {
            if (n == 1) {
                count++;
                max = Math.Max(max, count);
            }
            else {
                count = 0;
            }
        }
        
        return max;
    }
}
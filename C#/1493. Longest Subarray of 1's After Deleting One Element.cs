/*
 * Link: https://leetcode.com/problems/longest-subarray-of-1s-after-deleting-one-element/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LongestSubarray(int[] nums) {
        int begin = 0, end = 0;
        int max = 0;
        int countZero = 0;
        
        while(end < nums.Length) {
            if (nums[end++] == 0) {
                countZero++;
            }
            
            while(countZero > 1) {
                if (nums[begin++] == 0) {
                    countZero--;
                }
            }
            
            max = Math.Max(max, end - begin - 1);
        }
        
        return max;
    }
}
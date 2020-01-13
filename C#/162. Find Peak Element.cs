/*
 * Link: https://leetcode.com/problems/find-peak-element/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindPeakElement(int[] nums) {
        var left = 0;
        var right = nums.Length - 1;
        
        while(left < right) {
            var mid = (left + right) / 2;
            
            if (nums[mid] < nums[mid + 1]) left = mid + 1;
            else right = mid;
        }
        
        return left;
    }
}
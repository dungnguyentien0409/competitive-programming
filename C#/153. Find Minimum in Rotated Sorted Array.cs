/*
 * Link: https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindMin(int[] nums) {
        if (nums.Length == 0) return 0;
        int left = 0, right = nums.Length - 1;
        
        while(left < right) {
            var mid = (left + right) / 2;
            
            if (nums[mid] > nums[right]) {
                left = mid + 1;
            }
            else {
                right = mid;
            }
        }
        
        return nums[left];
    }
}
/*
 * Link: https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindMin(int[] nums) {
        int left = 0, right = nums.Length - 1;
        
        while(left < right) {
            var mid = (left + right) / 2;
            
            if (nums[mid] > nums[right]) {
                left = mid + 1;
            }
            else if (nums[mid] < nums[right]) {
                right = mid;
            }
            else {
                right--;
            }
        }
        
        return nums[left];
    }
}
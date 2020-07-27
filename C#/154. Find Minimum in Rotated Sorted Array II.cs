/*
 * Link: https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindMin(int[] nums) {
        int left = 0, right = nums.Length - 1;
        
        while(left < right) {
            var mid = (left + right) / 2;
            
            if (nums[mid] < nums[right]) {
                right = mid;
            }
            else if (nums[mid] > nums[right]) {
                left = mid + 1;
            }
            else {
                if (right != 0 && nums[right - 1] <= nums[right]) right--;
                else return nums[right];
            }
        }
        
        return nums[left];
    }
}
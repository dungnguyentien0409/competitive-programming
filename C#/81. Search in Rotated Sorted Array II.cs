/*
 * Link: https://leetcode.com/problems/search-in-rotated-sorted-array-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        
        while(left <= right) {
            var mid = (left + right) / 2;
            
            if (nums[mid] == target) return true;
            
            if (nums[left] == nums[mid]) {
                left++;
            }
            else if (nums[left] < nums[mid]) {
                if (target >= nums[left] && target < nums[mid]) right = mid - 1;
                else left = mid + 1;
            }
            else { // nums[left] > nums[mid]
                if (target > nums[mid] && target <= nums[right]) left = mid + 1;
                else right = mid - 1;
            }
        }
        
        return false;
    }
}
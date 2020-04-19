/*
 * Link: https://leetcode.com/problems/search-in-rotated-sorted-array/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length == 0) return -1;
        if (nums[0] < nums[nums.Length - 1]) {
            return BinarySearch(nums, 0, nums.Length - 1, target);
        }
        
        
        var start = FindStartIndex(nums);
        var res = -1;
        
        if (target == nums[0]) {
            return 0;
        }
        else if (target < nums[0]) {
            res = BinarySearch(nums, start, nums.Length - 1, target);
        }
        else { // target > nums[0]
            res = BinarySearch(nums, 0, start - 1, target);
        }
        
        return res;
    }
    
    public int FindStartIndex(int[] nums) {
        int left = 0, right = nums.Length - 1;
        
        while(left < right) {
            var mid = (left + right) / 2;
            
            if (nums[mid] > nums[right]) left = mid + 1;
            else right = mid;
        }
        
        return left;
    }
    
    public int BinarySearch(int[] nums, int left, int right, int target) {
        while(left < right) {
            var mid = (left + right) / 2;
            
            if (nums[mid] == target) return mid;
            else if (nums[mid] < target) left = mid + 1;
            else right = mid;
        }
        
        Console.WriteLine(nums[left] + " " + left);
        if (nums[left] == target) return left;
        return -1;
    }
}
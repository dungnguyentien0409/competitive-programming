/*
 * Link: https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if (nums.Length == 0) return new int[2] { -1, -1 };
        
        var left = BinarySearchLeft(nums, target);
        var right = BinarySearchRight(nums, target);
        Console.WriteLine(left + " " + right);
        if (left >= nums.Length 
            || right >= nums.Length 
            || nums[left] != target 
            || nums[right] != target) return new int[2] { -1, -1 };
        
        return new int[2] { left, right };
    }
    
    public int BinarySearchLeft(int[] nums, int target) {
        var left = 0;
        var right = nums.Length - 1;

        while(left < right) {
            var mid = (left + right) / 2;
            if (nums[mid] < target) left = mid + 1;
            else right = mid;
        }
        
        if (nums[left] < target) return left + 1;
        return left;
    }
    
    public int BinarySearchRight(int[] nums, int target) {
        var left = 0;
        var right = nums.Length - 1;

        while(left < right) {
            var mid = (int)Math.Ceiling((decimal)(left + right) / 2);
            if (nums[mid] > target) right = mid - 1;
            else left = mid;
        }
        
        if (nums[right] > target) return right - 1;
        return right;
    }
}
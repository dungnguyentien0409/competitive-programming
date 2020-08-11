/*
 * Link: https://leetcode.com/problems/next-permutation/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public void NextPermutation(int[] nums) {
        if (nums.Length <= 1) return;
        
        int i = nums.Length - 2;
        
        while(i >= 0 && nums[i] >= nums[i + 1]) i--;
        
        if (i >= 0) {
            int j = nums.Length - 1;
            while(nums[j] <= nums[i]) j--;
            
            Swap(nums, i, j);
        }
        
        Reverse(nums, i + 1, nums.Length - 1);
    }
    
    public void Reverse(int[] nums, int left, int right) {
        while(left < right) {
            Swap(nums, left++, right--);
        }
    }
    
    public void Swap(int[] nums, int x, int y) {
        if (x == y) return;
        
        var tmp = nums[x];
        nums[x] = nums[y];
        nums[y] = tmp;
    }
}
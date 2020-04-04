/*
 * Link: https://leetcode.com/problems/move-zeroes/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public void MoveZeroes(int[] nums) {
        int length = nums.Length;
        int p1 = 0, p2 = 0;
        
        //p1 point to first 0, p2 point to first number after p1
        while(p1 < length && p2 < length) {
            if (p1 < p2 && nums[p1] == 0 && nums[p2] != 0) {
                swap(nums, p1, p2);
            }
            
            if (nums[p1] != 0) p1++;
            if (p2 < p1 || nums[p2] == 0) p2++;
        }
    }
    
    public void swap(int[] nums, int x, int y) {
        if (x == y) return;
        
        var tmp = nums[x];
        nums[x] = nums[y];
        nums[y] = tmp;
    }
}
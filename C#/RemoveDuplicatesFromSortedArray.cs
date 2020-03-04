/*
 * Problem: https://leetcode.com/problems/remove-duplicates-from-sorted-array/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length <= 1) return nums.Length;
        
        // point to distinct sorted element
        var pivot = 0;
        for (var i = 1; i < nums.Length; i++) {
            if (nums[i] > nums[pivot]) {
                pivot++;
                swap(ref nums, i, pivot);
            }
        }
        
        return pivot + 1;
    }
    
    public void swap(ref int[] nums, int x, int y) {
        if (x == y) return;
        
        var tmp = nums[x];
        nums[x] = nums[y];
        nums[y] = tmp;
    }
}
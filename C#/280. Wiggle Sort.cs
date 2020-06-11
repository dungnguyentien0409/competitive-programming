/*
 * Link: https://leetcode.com/problems/wiggle-sort/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public void WiggleSort(int[] nums) {
        for (var i = 0; i < nums.Length - 1; i++) {
            if (i % 2 == 0 && nums[i + 1] < nums[i]) {
                Swap(nums, i, i + 1);
            }
            else if (i % 2 == 1 && nums[i + 1] > nums[i]) {
                Swap(nums, i, i + 1);
            }
        }
    }
    
    public void Swap(int[] nums, int x, int y) {
        if (x == y) return;
        
        var tmp = nums[x];
        nums[x] = nums[y];
        nums[y] = tmp;
    }
}
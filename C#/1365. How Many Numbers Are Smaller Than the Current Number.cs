/*
 * Link: https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        var sorted = new int[nums.Length];
        Array.Copy(nums, sorted, nums.Length);
        Array.Sort(sorted, delegate(int a, int b) {
            return a - b;
        });
            
        for (var i = 0; i < nums.Length; i++) {
            nums[i] = Array.IndexOf(sorted, nums[i]);
        } 
        
        return nums;
    }
}
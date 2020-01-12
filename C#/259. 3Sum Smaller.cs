/*
 * Link: https://leetcode.com/problems/3sum-smaller/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int ThreeSumSmaller(int[] nums, int target) {
        if (nums.Length < 3) return 0;
        
        Array.Sort(nums, delegate(int a, int b) {
            return a - b;
        });
         
        var count = 0;
        for (var i = 0; i < nums.Length - 2; i++) {
            var left = i + 1;
            var right = nums.Length - 1;
            
            while (left < right) {
                var sum = nums[i] + nums[left] + nums[right];
                if (sum >= target) {
                    right--;
                }
                else{
                    count += (right - left);
                    left++;
                }
            }
        }
        
        return count;
    }
}
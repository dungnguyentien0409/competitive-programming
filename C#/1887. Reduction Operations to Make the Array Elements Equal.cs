/*
 * Link: https://leetcode.com/problems/reduction-operations-to-make-the-array-elements-equal/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int ReductionOperations(int[] nums) {
        Array.Sort(nums);
        int res = 0, len = nums.Length;
        
        for (var i = len - 1; i > 0; i--) {
            if (nums[i] != nums[i - 1]) {
                res += len - i;
            }
        }
        
        return res;
    }
}
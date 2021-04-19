/*
 * Link: https://leetcode.com/problems/combination-sum-iv/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        if (nums.Length == 0) return 0;
        
        var dp = new int[target + 1];
        dp[0] = 1;
        
        for(var i = 1; i <= target; i++) {
            foreach(var n in nums) {
                if (i - n >= 0) {
                    dp[i] += dp[i - n];
                }
            }
        }
        
        return dp[target];
    }
}
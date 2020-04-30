/*
 * Link: https://leetcode.com/problems/greatest-sum-divisible-by-three/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: lee215
*/

class Solution {
    public int MaxSumDivThree(int[] nums) {
        var dp = new int[3] { 0, Int32.MinValue, Int32.MinValue };
        
        foreach(var n in nums) {
            var dp2 = new int[3];
            
            for (var i = 0; i < 3; i++) {
                var index = (n + i) % 3;
                
                dp2[index] = Math.Max(dp[index], dp[i] + n);
            }
            
            dp = dp2;
        }
        
        return dp[0];
    }
}
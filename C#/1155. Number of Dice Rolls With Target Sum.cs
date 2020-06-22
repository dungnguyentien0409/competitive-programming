/*
 * Link: https://leetcode.com/problems/number-of-dice-rolls-with-target-sum/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumRollsToTarget(int d, int f, int target) {
        int MAX = (int)Math.Pow(10, 9) + 7;
        var dp = new int[target + 1];
        
        dp[0] = 1;
        for (var i = 0; i < d; i++) {
            var tmp = new int[target + 1];
            
            for (var j = 1; j <= f; j++) {
                for (var t = 1; t <= target; t++) {
                    if (t - j >= 0) {
                        tmp[t] = (tmp[t] + dp[t - j]) % MAX;
                    }
                }
            }
            
            dp = tmp;
        }
        
        return dp[target];
    }
}
// Link: https://leetcode.com/problems/distinct-subsequences/submissions/
// Author: Dung Nguyen Tien (Chris)

public class Solution {
    public int NumDistinct(string s, string t) {
        var dp = createDP(s, t);
        dp[0][0] = 1;
        
        for (var i = 1; i <= s.Length; i++) {
            dp[0][i] = 1;
        }
        
        for (var i = 1; i <= t.Length; i++) {
            for (var j = 1; j <= s.Length; j++) {
                if (t[i - 1] == s[j - 1]) {
                    dp[i][j] = dp[i - 1][j - 1] + dp[i][j - 1];
                }
                else {
                    dp[i][j] = dp[i][j - 1];
                }
            }
        }
        
        return dp[t.Length][s.Length];
    }
    
    int[][] createDP(string s, string t) {
        var dp = new int[t.Length + 1][];
        
        for (var i = 0 ; i <= t.Length; i++) {
            dp[i] = new int[s.Length + 1];
            
            for (var j = 0; j <= s.Length; j++) {
                dp[i][j] = 0;
            }
        }
        
        return dp;
    }
}
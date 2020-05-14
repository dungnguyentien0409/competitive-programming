/*
 * Link: https://leetcode.com/problems/is-subsequence/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool IsSubsequence(string s, string t) {
        var dp = new bool[s.Length + 1][];
        
        for (var i = 0; i <= s.Length; i++) {
            dp[i] = new bool[t.Length + 1];
            Array.Fill(dp[i], false);
        }
        
        Array.Fill(dp[0], true);
        
        for (var i = 1; i <= s.Length; i++) {
            for (var j = 1; j <= t.Length; j++) {
                if (s[i - 1] == t[j - 1]) {
                    dp[i][j] = dp[i - 1][j - 1];
                }
                else {
                    dp[i][j] = dp[i][j - 1];
                }
            }
        }
        
        return dp[s.Length][t.Length];
    }
}
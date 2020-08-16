/*
 * Link: https://leetcode.com/problems/longest-palindromic-subsequence/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LongestPalindromeSubseq(string s) {
        var n = s.Length;
        var dp = CreateDP(n);
        
        for (var i = 0; i < n; i++) dp[i][i] = 1;
        
        for (var len = 2; len <= n; len++) {
            for (var i = 0; i <= n - len; i++) {
                var j = len + i - 1;
                
                if (len == 2 && s[i] == s[j]) {
                    dp[i][j] = 2;
                }
                else if (s[i] == s[j]) {
                    dp[i][j] = 2 + dp[i + 1][j - 1];
                }
                else {
                    dp[i][j] = Math.Max(dp[i][j - 1], dp[i + 1][j]);
                }
            }
        }
        
        return dp[0][n - 1];
    }
    
    public int[][] CreateDP(int n) {
        var dp = new int[n][];
        
        for (var i = 0; i < n; i++) dp[i] = new int[n];
        
        return dp;
    }
}
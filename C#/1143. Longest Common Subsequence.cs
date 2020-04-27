/*
 * Link: https://leetcode.com/problems/longest-common-subsequence/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int len1 = text1.Length, len2 = text2.Length;
        var dp = CreateDP(len1, len2);
        
        for (var i = 1; i <= len1; i++) {
            for (var j = 1; j <= len2; j++) {
                if (text1[i - 1] == text2[j - 1]) {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }
        
        return dp[len1, len2];
    }
    
    public int[,] CreateDP(int len1, int len2) {
        var dp = new int[len1 + 1, len2 + 1];
        
        for (var i = 0; i <= len1; i++) {
            for (var j = 0; j <= len2; j++) {
                dp[i, j] = 0;
            }
        }
        
        return dp;
    }
}
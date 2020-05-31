/*
 * Link: https://leetcode.com/problems/edit-distance/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/
public class Solution {
    public int MinDistance(string word1, string word2) {
        int len1 = word1.Length, len2 = word2.Length;
        var dp = new int[len1 + 1][];
        
        for(var i = 0; i <= len1; i++) dp[i] = new int[len2 + 1];
        
        for(var i = 1; i <= len1; i++) dp[i][0] = i;
        for(var i = 1; i <= len2; i++) dp[0][i] = i;
        
        for(var i = 1; i <= len1; i++) {
            for (var j = 1; j <= len2; j++) {
                if (word1[i - 1] == word2[j - 1]) {
                    dp[i][j] = dp[i - 1][j - 1];
                }
                else {
                    dp[i][j] = Math.Min(dp[i - 1][j - 1],
                        Math.Min(dp[i - 1][j], dp[i][j - 1])) + 1;
                }
            }
        }
        
        return dp[len1][len2];
    }
}
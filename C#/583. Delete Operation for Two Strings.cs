/*
 * Link: https://leetcode.com/problems/delete-operation-for-two-strings/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinDistance(string word1, string word2) {
        int lcs = LongestCommonString(word1, word2);
        
        return word1.Length + word2.Length - 2 * lcs;
    }
    
    public int LongestCommonString(string w1, string w2) {
        var dp = CreateDP(w1, w2);
        
        for (var i = 1; i <= w1.Length; i++) {
            for (var j = 1; j <= w2.Length; j++) {
                if (w1[i - 1] == w2[j - 1]) {
                    dp[i][j] = dp[i - 1][j - 1] + 1;
                }
                else {
                    dp[i][j] = Math.Max(dp[i - 1][j], dp[i][j - 1]);
                }
            }
        }
        
        return dp[w1.Length][w2.Length];
    }
    
    public int[][] CreateDP(string w1, string w2) {
        var dp = new int[w1.Length + 1][];
        
        for (var i = 0; i <= w1.Length; i++) {
            dp[i] = new int[w2.Length + 1];
        }
        
        return dp;
    }
}
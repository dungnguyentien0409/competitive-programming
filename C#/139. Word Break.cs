/*
 * Link: https://leetcode.com/problems/word-break/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var dp = new bool[s.Length + 1];
        dp[0] = true;
        
        for (var len = 1; len <= s.Length; len++) {
            foreach (var w in wordDict) {
                if (len >= w.Length && dp[len - w.Length]
                   && s.Substring(len - w.Length, w.Length) == w) {
                    dp[len] = true;
                }
            }
        }
        
        return dp[s.Length];
    }
}
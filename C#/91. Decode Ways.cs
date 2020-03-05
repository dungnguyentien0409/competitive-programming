/*
 * Link: https://leetcode.com/problems/decode-ways/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumDecodings(string s) {
        var dp = new int[s.Length + 1];
        Array.Fill(dp, 0);
        
        dp[0] = 1;
        dp[1] = s[0] == '0' ? 0 : 1;
        
        for (var i = 2; i <= s.Length; i++) {
            if (s[i - 1] != '0') {
                dp[i] += dp[i - 1];
            }
            
            var str = s.Substring(i - 2, 2);
            if (string.Compare(str, "10") >= 0 && string.Compare(str, "26") <= 0) {
                dp[i] += dp[i - 2];
            }
        }
        
        return dp[s.Length];
    }
}
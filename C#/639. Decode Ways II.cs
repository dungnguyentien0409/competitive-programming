/*
 * Link: https://leetcode.com/problems/decode-ways-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumDecodings(string s) {
        long MAX = (long)Math.Pow(10, 9) + 7;
        var dp = CreateDP(s);
        
        for (var i = 2; i <= s.Length; i++) {
            if (s[i - 1] == '*') {
                dp[i] = (dp[i] + dp[i - 1] * 9) % MAX;
                
                if (s[i - 2] == '1') {
                    dp[i] = (dp[i] + dp[i - 2] * 9) % MAX;
                }
                else if (s[i - 2] == '2') {
                    dp[i] = (dp[i] + dp[i - 2] * 6) % MAX;
                }
                else if (s[i - 2] == '*') {
                    // because * is from 1 to 9, cannot 10 or 20
                    dp[i] = (dp[i] + dp[i - 2] * 15) % MAX;
                }
            }
            else {
                if (s[i - 1] != '0') {
                    dp[i] = (dp[i] + dp[i - 1]) % MAX;
                }
                
                if (s[i - 2] == '*') {
                    if (s[i - 1] <= '6') {
                        dp[i] = (dp[i] + dp[i - 2] * 2) % MAX;
                    }
                    else {
                        dp[i] = (dp[i] + dp[i - 2]) % MAX;
                    }
                }
                else {
                    var str = s.Substring(i - 2, 2);
                    if (string.Compare(str, "10") >= 0 && string.Compare(str, "26") <= 0) {
                        dp[i] = (dp[i] + dp[i - 2]) % MAX;
                    }
                }
            }
        }
        
        return (int)(dp[s.Length] % MAX);
    }
    
    public long[] CreateDP(string s) {
        var dp = new long[s.Length + 1];
        Array.Fill(dp, 0);
        
        dp[0] = 1;
        
        switch(s[0]) {
            case '0':
                dp[1] = 0;
                break;
            case '*':
                dp[1] = 9;
                break;
            default:
                dp[1] = 1;
                break;
        }
            
        return dp;
    }
}
/*
 * Link: https://leetcode.com/problems/restore-the-array/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumberOfArrays(string s, int k) {
        var dp = new long[s.Length];
        
        Array.Fill(dp, -1);
        MAX = (long)Math.Pow(10, 9) + 7;
        
        backtrack(s, 0, (long)k, dp);
        
        return (int)dp[0];
    }
    
    long MAX;
    public long backtrack(string s, int start, long k, long[] dp) {
        if (start == s.Length) {
            return 1;
        }
        if (dp[start] > -1) {
            return dp[start];
        }
        
        long total = 0;
        for(var len = 1; len <= s.Length - start; len++) {
            var substring = s.Substring(start, len);
            var num = Int64.Parse(substring);
            
            if (num == 0 || num > k) break;
            
            if (start + len <= s.Length) {
                total = (total
                    + backtrack(s, start + len, k, dp) % MAX) % MAX;
            }
        }
        
        return dp[start] = total;
    }
}
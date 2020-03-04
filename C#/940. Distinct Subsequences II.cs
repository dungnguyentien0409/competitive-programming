// Link: https://leetcode.com/problems/distinct-subsequences-ii/
// Author: Dung Nguyen Tien (Chris)

public class Solution {
    public int DistinctSubseqII(string S) {
        // dp[i] is the total of subset from S having the len i
        var dp = createDP(S);
        var last = createLast();
        int max = 1000000007;
        // the empty string
        dp[0] = 1;
        
        for (var i = 1; i <= S.Length; i++) {
            dp[i] = dp[i - 1] * 2 % max;
            
            // if the character is duplicate, then substract
            var iLast = S[i - 1] - 'a';
            if (last[iLast] >= 0) {
                dp[i] -= dp[last[iLast] - 1];
            }
            
            dp[i] %= max;
            last[iLast] = i;
            Console.WriteLine(dp[i]);
        }
        
        // substract the empty string
        dp[S.Length] -= 1;
        
        if (dp[S.Length] < 0) dp[S.Length] += max;
        
        return dp[S.Length];
    }
    
    int[] createDP(string S) {
        var dp = new int[S.Length + 1];
        
        for (var i = 1; i <= S.Length; i++) {
            dp[i] = 0;
        }
        
        return dp;
    }
    
    int[] createLast() {
        var last = new int[27];
        
        for (var i = 0; i < 27; i++) {
            last[i] = -1;
        }
        
        return last;
    }
}
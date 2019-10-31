/**
 * Problem: https://leetcode.com/problems/distinct-subsequences-ii/solution/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} S
 * @return {number}
 */
var distinctSubseqII = function(S) {
    // dp[i]: the distinct subset can have with the length of i from S 
    var max = Math.pow(10, 9) + 7;
    var dp = Array(S.length + 1).fill(0);
    var last = Array(26).fill(-1);
    
    // the empty subsequence
    dp[0] = 1;
    
    for (var i = 1; i <= S.length; i++) {
        // the next sub equal to the length of current sub + currentsub (add one S[i] for each element)
        dp[i] = dp[i - 1] * 2 % max;
        
        // if the S[i] added is duplicate
        
        var iLast = S.charCodeAt(i - 1) - 97;
        
        if (last[iLast] >= 0) {
            dp[i] -= dp[last[iLast] - 1];
        }
        
        dp[i] %= max;
        // save the index of total subset of character S[iLast]
        last[iLast] = i;
    }

    // minus the empty string
    dp[S.length] -= 1;
    if (dp[S.length] < 0) dp[S.length] += max;
    
    return dp[S.length];
};
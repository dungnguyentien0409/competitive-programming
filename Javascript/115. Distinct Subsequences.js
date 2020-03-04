/**
 * Link: https://leetcode.com/problems/distinct-subsequences/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} s
 * @param {string} t
 * @return {number}
 */
var numDistinct = function(s, t) {
    // the distinct subsquences until s (len i), t (len j)
    // at empth s, t there is one subsequences which is empty
    var dp = Array(t.length + 1).fill().map(() => Array(s.length + 1).fill(0));  
    dp[0][0] = 1;
    
    // empty is the distinct subsequence of every length
    for (var i = 1; i <= s.length; i++) dp[0][i] = 1;
    
    for (var j = 1; j <= t.length; j++) dp[j][0] = 0;
    
    for (var i = 1; i <= t.length; i++) {
        for (var j = 1; j <= s.length; j++) {
            if (s[j - 1] == t[i - 1]) {
                // there are 2 case: one we use the char s[i - 1], the other is not
                dp[i][j] = dp[i - 1][j - 1] + dp[i][j - 1]
            }
            else {
                // only one case dont use char in s
                dp[i][j] = dp[i][j - 1];
            }
        }
    }
    console.log(dp);
    return dp[t.length][s.length];
};
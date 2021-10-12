/**
 * @param {string} s
 * @param {number} k
 * @return {boolean}
 */
var isValidPalindrome = function(s, k) {
    return s.length - lps(s) <= k;
};

function lps(s) {
    var n = s.length;
    var dp = Array(n).fill().map(() => Array(n).fill(0));
    
    for(var i = 0; i < n; i++) dp[i][i] = 1;
    
    for(var len = 2; len <= n; len++) {
        for (var i = 0; i < n - len + 1; i++){
            var j = i + len - 1;
            
            if (s[i] == s[j]) {
                dp[i][j] = len == 2 ? 2 : 2 + dp[i + 1][j - 1];
            }
            else {
                dp[i][j] = Math.max(dp[i + 1][j], dp[i][j - 1]);
            }
        }
    }
    
    return dp[0][n - 1];
}
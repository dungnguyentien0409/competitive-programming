/**
 * Link: https://leetcode.com/problems/interleaving-string/
 * Implement: Dung Nguyen Tien (Chris)
 * Idea by: Tushar Roy
 * Reference: https://www.youtube.com/watch?v=ih2OZ9-M3OM
 * @param {string} s1
 * @param {string} s2
 * @param {string} s3
 * @return {boolean}
 */
var isInterleave = function(s1, s2, s3) {
    if (s3.length != s1.length + s2.length) return false;
    
    var dp = Array(s1.length + 1).fill().map(() => Array(s2.length + 1).fill(false));
    dp[0][0] = true;
    
    var i3 = 0;
    for (var i = 1; i <= s1.length; i++) {
        if (s1[i - 1] == s3[i3]) {
            dp[i][0] = dp[i - 1][0];
            i3++;
        }
        else dp[i][0] = false;
    }
    
    i3 = 0;
    for (var i = 1; i <= s2.length; i++) {
        if (s2[i - 1] == s3[i3]) {
            dp[0][i] = dp[0][i - 1];
            i3++;
        }
        else dp[0][i] = false;
    }
    
    for (var i = 1; i <= s1.length; i++) {
        i3 = i;
        for (var j = 1; j <= s2.length; j++) {
            if (s1[i - 1] != s3[i3] && s2[j - 1] != s3[i3]) {
                dp[i][j] = false;
            }
            else {
                if (s1[i - 1] == s3[i3]) {
                    dp[i][j] = dp[i - 1][j] || dp[i][j];
                }
                if (s2[j - 1] == s3[i3]) {
                    dp[i][j] = dp[i][j - 1] || dp[i][j];
                }
            }
            i3++;
        }
    }
    console.log(dp);
    return dp[s1.length][s2.length]
};

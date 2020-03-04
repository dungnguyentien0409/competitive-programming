/**
 * Link: https://leetcode.com/problems/delete-operation-for-two-strings/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} word1
 * @param {string} word2
 * @return {number}
 */
var minDistance = function(word1, word2) {
    // if one of them is null, the other need to delete all
    if (word1.length == 0) return word2.length;
    if (word2.length == 0) return word1.length;
    
    var longestCommonSubstring = LongestCommonSubstring(word1, word2);
    
    // find the common, then the others characters need to be deleted
    return word1.length - longestCommonSubstring + word2.length - longestCommonSubstring;
};

// find the longest common substring
// find the explanation here: https://github.com/dungnguyentien0409/competitive-programming/blob/master/Dynamic%20Programming/LongestCommonSubsequence.js
function LongestCommonSubstring(word1, word2) {
    var n1 = word1.length;
    var n2 = word2.length;
    var dp = Array(n1).fill().map(() => Array(n2).fill(0));
    
    for (var i = 0; i < n1; i++) {
        for (var j = 0; j < n2; j++) {
            if (word1[i] == word2[j]) {
                dp[i][j] = (i >= 1 && j >= 1) ? dp[i - 1][j - 1] + 1 : 1;
            }
            else {
                if (i >= 1 && j >= 1)
                    dp[i][j] = Math.max(dp[i - 1][j], dp[i][j - 1]);
                else if (i >= 1)
                    dp[i][j] = dp[i - 1][j];
                else if (j >= 1)
                    dp[i][j] = dp[i][j - 1];
                else
                    dp[i][j] = 0;
            }
        }
    }
    
    return dp[n1 - 1][n2 - 1];
}
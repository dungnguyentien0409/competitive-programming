/**
 * Problem: https://leetcode.com/problems/longest-common-subsequence/
 * Author: Dung Nguyen Tien (Chris)
 * @param {string} text1
 * @param {string} text2
 * @return {number}
 */
var longestCommonSubsequence = function(text1, text2) {
    var n1 = text1.length;
    var n2 = text2.length;
    // dp[i][j] store the longest common subsequence of text1(0...i) and text2(0..j)
    var dp = Array(n1).fill().map(() => Array(n2).fill(0));
    
    for (var i = 0; i < n1; i++) {
        for (var j = 0; j < n2; j++) {
            if (text1[i] == text2[j]) {
                // if text1 equal to text2 than the longest eqail to the longest of text1(0...i - 1) and text2(0...j - 1) expand to 1
                dp[i][j] = (i >= 1 && j >= 1) ? dp[i - 1][j - 1] + 1 : 1;
            }
            else {
                // if text1 is different to text2, the longest of dp[i][j] is equal to that of text1 reduce one element or text2 reduce one element
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
    console.log(dp);
    return dp[n1 - 1][n2 -1];
};
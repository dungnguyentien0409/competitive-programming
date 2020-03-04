/**
 * Link: https://leetcode.com/problems/longest-palindromic-subsequence/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: implement following explanation of Mr.Shar
 * Link: https://www.youtube.com/watch?v=_nCsPn7_OgI
 * @param {string} s
 * @return {number}
 */
var longestPalindromeSubseq = function(s) {
    return findTheLongest(s);
};

function findTheLongest(s) {
    var n = s.length;
    // dp[i][j] store the length of longest palindrome subsequence from i to j
    var dp = Array(n).fill().map(() => Array(n).fill(0));
    
    // for each substring has length = 1 having the longest palindromic subsequence is 1
    for (var i = 0; i < n; i++) {
        dp[i][i] = 1;
    }
    
    // consider for substring has length from 2 to n
    for (var len = 2; len <= n; len++) {
        for (var i = 0; i <= n - len; i++) {
            var j = i + len - 1;
            // if the left is the same as the right => the longest is 2
            if (len == 2 && s[i] == s[j]) {
                dp[i][j] = 2;
            } 
            else if (s[i] == s[j]) {
                dp[i][j] = 2 + dp[i + 1][j - 1];
            }
            // if the left is different from the right: consider the current longest is equal to that of reducing one element to left or right: (left + 1 to right) or (left to right + 1)
            else {
                dp[i][j] = Math.max(dp[i + 1][j], dp[i][j - 1]);
            }
        }
    }
    console.log(dp);
    return dp[0][n - 1];
}
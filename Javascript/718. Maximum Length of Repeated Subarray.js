/**
 * Link: https://leetcode.com/problems/maximum-length-of-repeated-subarray/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} A
 * @param {number[]} B
 * @return {number}
 */
var findLength = function(A, B) {
    // dp[i][j] is the max sub array of A and B
    // end at A[i - 1] and B[j - 1]
    var dp = Array(A.length + 1).fill().map(() => Array(B.length + 1).fill(0));
    var max = 0;
    
    for (var i = 1; i <= A.length; i++) {
        for (var j = 1; j <= B.length; j++) {
            if (A[i - 1] == B[j - 1]) {
                // if the same, then add one char for both line
                dp[i][j] = dp[i - 1][j - 1] + 1;
                max = Math.max(max, dp[i][j]);
            }
            else {
                // if dont match
                // so the max subarray A and B
                // end at A[i - 1] and B[j - 1 is 0]
                dp[i][j] = 0;
            }
        }
    }
    
    return max;
};
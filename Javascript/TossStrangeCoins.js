/**
 * Problem: https://leetcode.com/problems/toss-strange-coins/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} prob
 * @param {number} target
 * @return {number}
 */
var probabilityOfHeads = function(prob, target) {
    // dp[c][k] is the posibility to get k face with c coin
    var dp = Array(prob.length + 1).fill().map(() => Array(target + 1).fill(0));
    dp[0][0] = 1;
 
    // there is no coin to get k face
    for (var k = 1; k <= target; k++) dp[0][k] = 0;
    
    // there are coin to get 0 face
    for (var c = 1; c <= prob.length; c++) {
        dp[c][0] = dp[c - 1][0] * (1 - prob[c - 1]);
    }
    
    for (var c = 1; c <= prob.length; c++) {
        for (var k = 1; k <= target; k++) {
            var i = c - 1;
            var kFace = dp[c - 1][k - 1] * prob[i];
            var kNotFace = dp[c - 1][k] * (1 - prob[i]);
            dp[c][k] = kFace + kNotFace;
        }
    }
    return dp[prob.length][target];
};

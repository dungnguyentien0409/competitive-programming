/**
 * Link: https://leetcode.com/problems/climbing-stairs/solution/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} n
 * @return {number}
 */
var climbStairs = function(n) {
    if (n == 1) return 1;
    
    // dp[i] represent how many ways to jump from i
    var dp = Array(n + 1);
    // one way to jump from 1: 1
    dp[1] = 1;
    //two way to jump from 2: 1-1, 2
    dp[2] = 2
    
    for (var i = 3; i <= n; i++) {
        // from i jump 1, or 2
        dp[i] = dp[i-1] + dp[i-2];
    }
    // way to jump from n
    return dp[n];
};

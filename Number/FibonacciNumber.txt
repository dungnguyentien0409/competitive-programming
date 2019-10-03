/**
 * Problem: https://leetcode.com/problems/fibonacci-number/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} N
 * @return {number}
 */
var fib = function(N) {
    if (N == 0) return 0
    if (N <= 2) return 1;
    
    var dp = Array(N).fill(0);
    dp[0] = 1;
    dp[1] = 1;
    
    for (var i = 2; i < N; i++) {
        dp[i] = dp[i - 1] + dp[i - 2];
    }
    
    return dp[N - 1];
};
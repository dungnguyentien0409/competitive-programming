/**
 * Problem: https://leetcode.com/problems/coin-change/solution/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} coins
 * @param {number} amount
 * @return {number}
 */
var coinChange = function(coins, amount) {
    var dp = Array(amount + 1).fill(Number.MAX_SAFE_INTEGER);
    dp[0] = 0;
    
    // put each coin into the value
    for (var c of coins) {
        for (var i = c; i <= amount; i++) {
            dp[i] = Math.min(dp[i], dp[i - c] + 1);
        }
    }
    
    return dp[amount] == Number.MAX_SAFE_INTEGER ? -1 : dp[amount];
};
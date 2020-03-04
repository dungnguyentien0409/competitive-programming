/**
 * Link: https://leetcode.com/problems/coin-change-2/
 * Authoir: Dung Nguyen Tien (Chris)
 * @param {number} amount
 * @param {number[]} coins
 * @return {number}
 */
var change = function(amount, coins) {
    var dp = Array(amount + 1).fill(0);
    dp[0] = 1;
    
    // put each coin in the amount
    // we only consider one coin once, so it wont repeat
    for (var coin of coins) {
        for (var i = coin; i <= amount; i++) {
            dp[i] += dp[i-coin];
        }
    }

    return dp[amount];
};
/**
 * Problem: https://leetcode.com/problems/coin-change/solution/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} coins
 * @param {number} amount
 * @return {number}
 */
var coinChange = function(coins, amount) {
    // dp with i: the current total money, dp[i]: min coin to get that money
    var dp = Array(amount + 1).fill(Number.MAX_SAFE_INTEGER);
    dp[0] = 0;
    
    for (var i = 1; i <= amount; i++) {
        for (var j = 0; j < coins.length; j++) {
            if (i >= coins[j]) {
                // with i: total money, check all the previous value of coin. let say dp[i - 1] + 1 = dp[i] for coin 1, dp[i - 2] + 1 for coin 2, and get the min
                dp[i] = Math.min(dp[i], dp[i - coins[j]] + 1);
            }
        }
    }
    // return the min coin dp[amount] for the amout: i = amount
    return dp[amount] != Number.MAX_SAFE_INTEGER ? dp[amount] : -1;
};
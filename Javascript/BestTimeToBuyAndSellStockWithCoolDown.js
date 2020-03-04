/**
 * Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    if (prices.length == 0) return 0;
    var n = prices.length;
    
    var b0 = -prices[0], b1 = b0;
    var s0 = 0, s1 = 0, s2 = 0;
    
    // if i: to buy or to rest
    // to rest: equal to buy[i - 1]
    // to buy: take s[i - 2] - rest at i - 1
    //buy[i] = max(buy[i - 1], s[i - 2] - prices[i]);
    // if i: to sell or to rest
    // to rest: equal to sell[i - 1];
    // to sell: 2 previous buy + prices[i]
    //sell[i] = max(sell[i - 1], buy[i - 1] + prices[i]);
    // b0 => b[i], b1 => b[i-1]
    // s0 => s[i], s1 => s[i-1], s2=> s[i-2]
    for (var i = 1; i < n; i++) {
        b0 = Math.max(b1, s2 - prices[i]);
        s0 = Math.max(s1, b1 + prices[i]);
        b1 = b0;
        s2 = s1;
        s1 = s0;
    }
    
    return s0;
};
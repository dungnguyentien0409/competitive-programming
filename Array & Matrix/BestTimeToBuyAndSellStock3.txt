/**
 * Problem: https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    var buy1 = Number.MIN_SAFE_INTEGER, buy2 = Number.MIN_SAFE_INTEGER;
    var sell1 = 0, sell2 = 0;
    // buy1 is the first buy, sell1 is the first sell
    // buy2 is the second buy, sell2 is the second sell
    for (var i = 0; i < prices.length; i++) {
        // which each buy lost prices[i] mean -prices[i]
        // get the buy closest to 0 min the mean buy
        buy1 = max(buy1, -prices[i]);
        // get the max sell
        sell1 = max(sell1, buy1 + prices[i]);
        buy2 = max(buy2, sell1 - prices[i]);
        sell2 = max(sell2, buy2 + prices[i]);
    }
    
    return sell2;
};
    
function max(a, b) {
    return a > b ? a : b;
}



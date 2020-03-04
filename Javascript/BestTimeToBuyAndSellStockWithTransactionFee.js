/**
 * Problem: https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/solution/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} prices
 * @param {number} fee
 * @return {number}
 */
var maxProfit = function(prices, fee) {
    var buy = Number.MIN_SAFE_INTEGER;
    var sell = 0;
    
    for (var i = 0; i < prices.length; i++) {
        // get smaller buy means closedt to 0,
        buy = Math.max(buy, sell - prices[i]);
        // get the largest sell
        // after selling, charge fee
        sell = Math.max(sell, buy + prices[i] - fee); 
    }

    return sell;
};
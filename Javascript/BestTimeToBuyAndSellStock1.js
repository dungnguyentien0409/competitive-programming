/**
 * Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    var buy = Number.MIN_SAFE_INTEGER;
    var sell = 0;
    
    for(var i = 0; i < prices.length; i++) {
        // before buy you have 0
        // with buy, you lost prices[i] mean 0 - prices[i];
        // to find with - prices[i] closest to 0 mean the smallest
        buy = Math.max(buy, -prices[i]);
        
        // find the max sell with the smallest buy
        // which each sell you get prices[i] mean buy + prices[i]
        sell = Math.max(sell, buy + prices[i]);
    }
    
    return sell;
};
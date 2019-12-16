/**
 * Problem: https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    var buy = -prices[0];
    var sell = 0;
    
    for (var i = 0; i < prices.length; i++) {
        // compare the last buy with the current buy after sell
        // take the max means which one cost less money
        // with each buy lost prices[i]
        // mean take the previous value: sell - prices[i]
        buy = Math.max(buy, sell - prices[i]);
        //compare to get the biggest sell
        sell = Math.max(sell, buy + prices[i]);
    }
    //return the last sell
    return sell;
};
/**
 * Problem: https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iv/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} k
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(k, prices) {
    if (k == 0 || prices.length <= 1) return 0;
    // for the length, k must smaller or equal to length / 2
    if (k > prices.length / 2) k = Math.floor(prices.length / 2);
    
    var buy = [];
    var sell = [];
    
    for (var i = 0; i < k; i ++) {
        // array to save k step of buy and sell
        buy.push(Number.MIN_SAFE_INTEGER);
        sell.push(0);
    }
    
    for (var i = 0; i < prices.length; i++) {
        // take the smallest buy which is closest to 0
        buy[0] = Math.max(buy[0], -prices[i]);
        for (var j = 0; j < k; j++) {
            if (j != 0) {
                // compare the min value of current buy with the current money - prices[i]
                buy[j] = Math.max(buy[j], sell[j - 1] - prices[i]);
            }
            
            //get the max profit
            sell[j] = Math.max(sell[j], buy[j] + prices[i]);
        }
    }
    
    return sell[k - 1];
};

function max(a, b) {
    if (isNaN(a) || isNaN(b)) console.log(a + "-" + b);
    return a > b ? a : b;
}
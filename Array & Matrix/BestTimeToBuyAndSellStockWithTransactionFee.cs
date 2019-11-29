/*
 * Problem: https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/submissions/
 * Author: Dung Nguyen Tien (Chris)
 *
*/

public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        var buy = Int32.MinValue;
        var sell = 0;
        
        for (var i = 0; i < prices.Length; i++) {
            buy = Math.Max(buy, sell - prices[i]);
            sell = Math.Max(sell, buy + prices[i] - fee);
        }
        
        return sell;
    }
}
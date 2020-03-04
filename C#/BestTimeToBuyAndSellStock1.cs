/*
 * Problem: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxProfit(int[] prices) {
        var buy = Int32.MinValue;
        var sell = 0;
        
        for (var i = 0; i < prices.Length; i++) {
            buy = Math.Max(buy, -prices[i]);
            sell = Math.Max(sell, buy + prices[i]);
        }
        
        return sell;
    }
}
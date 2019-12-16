/*
 * Problem: https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/
 * Author: Dung Nguyen Tien (Chris)
*/
public class Solution {
    public int MaxProfit(int[] prices) {
        var buy = Int32.MinValue;
        var sell = 0;
        var pre_sell = sell;
        
        for (var i = 0; i < prices.Length; i++) {
            // the next buy should take the 2 previous sell, not the previous sell
            buy = Math.Max(buy, pre_sell - prices[i]);
            // we take 2 status, the previous sell and the current sell
            pre_sell = sell;
            sell = Math.Max(sell, buy + prices[i]);
        }
        
        return sell;
    }
}
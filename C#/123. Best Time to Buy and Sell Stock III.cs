/*
 * Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxProfit(int[] prices) {
        int buy1 = Int32.MinValue, buy2 = Int32.MinValue;
        int sell1 = 0, sell2 = 0;
        
        for (var i = 0; i < prices.Length; i++) {
            buy1 = Math.Max(buy1, -prices[i]);
            sell1 = Math.Max(sell1, buy1 + prices[i]);
            buy2 = Math.Max(buy2, sell1 - prices[i]);
            sell2 = Math.Max(sell2, buy2 + prices[i]);
        }
        
        return sell2;
    }
}
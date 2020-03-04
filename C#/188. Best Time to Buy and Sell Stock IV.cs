/*
 * Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iv/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxProfit(int k, int[] prices) {
        if (k == 0 || prices.Length <= 1) return 0;
        // for the length, k must smaller or equal to length / 2
        if (k > prices.Length / 2) k = prices.Length / 2;
        
        var buy = new int[k];
        var sell = new int[k];
        Array.Fill(buy, Int32.MinValue);
        Array.Fill(sell, 0);
        
        for (var i = 0; i < prices.Length; i++) {
            for (var j = 0; j < k; j++) {
                if (j == 0) {
                    buy[0] = Math.Max(buy[0], -prices[i]);
                }
                else {
                    buy[j] = Math.Max(buy[j], sell[j - 1] - prices[i]);
                }
                sell[j] = Math.Max(sell[j], buy[j] + prices[i]);
            }
        }
        
        for (var i = 0; i < k; i++) {
            Console.WriteLine(sell[i]);
        }
        
        return sell[k - 1];
    }
}
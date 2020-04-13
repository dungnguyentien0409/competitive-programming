/*
 * Link: https://leetcode.com/problems/last-stone-weight-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LastStoneWeightII(int[] stones) {
        // divided into 2 group, one to detroys another one: S1, S2
        // S1 + S2 = S
        // S1 - S2 = diff => diff = S - 2*S2
        // get min diff => max S2 (S2 is from 0 => S/2)
        // the problem is, stone to get 0 => S/2: knapback
        var S = GetTotal(stones);
        var S2 = 0;
        var dp = CreateDP(stones.Length, S / 2);
        
        for (var i = 1; i <= stones.Length; i++) {
            for (var j = 1; j <= S / 2; j++) {
                var remainWeight = j - stones[i - 1];
                
                if (remainWeight < 0) {
                    // cannot pick
                    dp[i, j] = dp[i - 1, j];
                }
                else {
                    dp[i, j] = Math.Max(dp[i - 1, j], // not pick
                        dp[i - 1, remainWeight] + stones[i - 1]); // pick
                }
            }
        }
        
        return S - 2 * dp[stones.Length, S / 2];
    }
    
    public int[,] CreateDP(int x, int y) {
        var dp = new int[x + 1, y + 1];
        
        for (var i = 0; i <= x; i++) {
            for (var j = 0; j <= y; j++) {
                dp[i, j] = 0;
            }
        }
        
        return dp;
    }
    
    public int GetTotal(int[] stones) {
        var total = 0;
        
        foreach(var stone in stones) total += stone;
        
        return total;
    }
}
/*
 * Problem: https://leetcode.com/problems/perfect-squares/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumSquares(int n) {
        var arr = BuildSquareArray(n);
        var dp = new int[n + 1];
        Array.Fill(dp, Int32.MaxValue);
        
        dp[0] = 0;
        dp[1] = 1;
        
        foreach (var square in arr) {
            for (var i = 1; i <= n; i++) {
                if (i >= square && dp[i - square] != Int32.MaxValue) {
                    dp[i] = Math.Min(dp[i - square] + 1, dp[i]);
                }
                
                //if (dp[n] != Int32.MaxValue) break;
            }
        }
        
        return dp[n];
    }
    
    public List<int> BuildSquareArray(int n) {
        var i = 1;
        var list = new List<int>();
        
        while(i * i <= n) {
            list.Add(i * i);
            i++;
        }
        
        return list;
    }
}
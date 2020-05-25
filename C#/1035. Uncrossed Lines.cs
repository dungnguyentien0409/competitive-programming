/*
 * Link: https://leetcode.com/problems/uncrossed-lines/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxUncrossedLines(int[] A, int[] B) {
        if (A.Length == 0 || B.Length == 0) return 0;
        
        var dp = CreateDP(A, B);
        for(var i = 1; i <= A.Length; i++) {
            for (var j = 1; j <= B.Length; j++) {
                if (A[i - 1] == B[j - 1]){
                    dp[i][j] = dp[i - 1][j - 1] + 1;
                }
                else {
                    dp[i][j] = Math.Max(dp[i - 1][j], dp[i][j - 1]);
                }
            }
        }
        
        return dp[A.Length][B.Length];
    }
    
    public int[][] CreateDP(int[] A, int[] B) {
        var dp = new int[A.Length + 1][];
        
        for (var i = 0; i <= A.Length; i++) {
            dp[i] = new int[B.Length + 1];
        }
        
        return dp;
    }
}
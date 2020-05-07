/*
 * Link: https://leetcode.com/problems/unique-binary-search-trees/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumTrees(int n) {
        var dp = new int[n + 1];
        
        dp[0] = 1;
        dp[1] = 1;
        
        for (var i = 2; i <= n; i++) {
            for (var j = 0; j < i; j++) {
                // possibility in left: i - j - 1
                // possibility in right: j
                //Console.WriteLine((i - j - 1) + " " + (j));
                dp[i] += (dp[i - j - 1] * dp[j]);
            }
        }
        
        return dp[n];
    }
}
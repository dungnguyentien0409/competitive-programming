/*
 * Link: https://leetcode.com/problems/triangle/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int rows = triangle.Count;
        
        var dp = new int[rows][];
        for(var i = 0; i < rows; i++) {
            int cols = triangle[i].Count;
            dp[i] = new int[cols];
        }
        Array.Copy(triangle[rows - 1].ToArray(), dp[rows - 1], triangle[rows - 1].Count);
        
        for(var i = rows - 2; i >= 0; i--) {
            int cols = triangle[i].Count;
            for(var j = 0; j < cols; j++) {
                dp[i][j] = triangle[i][j]
                    + Math.Min(dp[i + 1][j], dp[i + 1][j + 1]);
            }
        }
        
        return dp[0][0];
    }
}
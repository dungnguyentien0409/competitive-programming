/*
 * Problem: https://leetcode.com/problems/spiral-matrix/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        if (matrix.Length == 0 || matrix[0].Length == 0) return new List<int>();
        
        int r1 = 0, r2 = matrix.Length - 1;
        int c1 = 0, c2 = matrix[0].Length - 1;
        var res = new List<int>();
        
        while(c1 <= c2 && r1 <= r2) {
            for (var c = c1; c <= c2; c++)
                res.Add(matrix[r1][c]);
            
            for (var r = r1 + 1; r <= r2; r++)
                res.Add(matrix[r][c2]);
            
            if (c1 < c2 && r1 < r2) {
                for (var c = c2 - 1; c >= c1; c--) 
                    res.Add(matrix[r2][c]);
                for (var r = r2 - 1; r > r1; r--)
                    res.Add(matrix[r][c1]);
            }
            
            c1++;
            r1++;
            c2--;
            r2--;
        }
        
        return res;
    }
}
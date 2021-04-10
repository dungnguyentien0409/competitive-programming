/*
 * Link: https://leetcode.com/problems/longest-increasing-path-in-a-matrix/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LongestIncreasingPath(int[][] matrix) {
        if (matrix.Length == 0 || matrix[0].Length == 0) return 0;
        
        var directions = new int[4][] {
            new int[2] { 0, 1 },
            new int[2] { 0, -1 },
            new int[2] { 1, 0 },
            new int[2] { -1, 0 }
        };
        
        int res = 0;
        int[][] cache = new int[matrix.Length][];
        
        for (var i = 0; i < matrix.Length; i++) {
            cache[i] = new int[matrix[0].Length];
            Array.Fill(cache[i], -1);
        }
        
        for (var i = 0; i < matrix.Length; i++) {
            for (var j = 0; j < matrix[0].Length; j++) {
                res = Math.Max(res, dfs(matrix, directions, i, j, cache));
            }
        }
        
        return res;
    }
    
    public int dfs(int[][] matrix, int[][] directions, int x, int y, int[][] cache) {
        if (cache[x][y] > - 1) return cache[x][y];
        
        int len = 0;
        foreach(var d in directions) {
            int nX = x + d[0], nY = y + d[1];
            
            if (nX < 0 || nY < 0 || nX >= matrix.Length || nY >= matrix[0].Length
               || matrix[nX][nY] <= matrix[x][y]) continue;
            
            len = Math.Max(len, dfs(matrix, directions, nX, nY, cache));
        }
        
        len++;
        cache[x][y] = len;
        return len;
    }
}
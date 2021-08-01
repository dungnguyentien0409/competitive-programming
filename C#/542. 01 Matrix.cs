public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        int rows = mat.Length, cols = mat[0].Length;
        int MAX = rows + cols;
        
        for(var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                if (mat[i][j] == 0) continue;
                
                int top = i == 0 ? MAX: mat[i - 1][j];
                int left = j == 0 ? MAX: mat[i][j - 1];
                mat[i][j] = Math.Min(top, left) + 1;
            }
        }
        
        for(var i = rows - 1; i >= 0; i--) {
            for (var j = cols - 1; j >= 0; j--) {
                if (mat[i][j] == 0) continue;
                
                int bot = i == rows - 1 ? MAX : mat[i + 1][j];
                int right = j == cols - 1 ? MAX : mat[i][j + 1];
                mat[i][j] = Math.Min(mat[i][j], Math.Min(bot, right) + 1);
            }
        }
        
        return mat;
    }
}
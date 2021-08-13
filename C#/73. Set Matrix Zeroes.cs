public class Solution {
    public void SetZeroes(int[][] matrix) {
        int rows = matrix.Length, cols = matrix[0].Length;
        bool col0 = false;
        
        for(var i = 0; i < rows; i++) {
            col0 = col0 || (matrix[i][0] == 0);
            
            for (var j = 1; j < cols; j++) {
                if (matrix[i][j] != 0) continue;
                
                
                matrix[0][j] = 0;
                matrix[i][0] = 0;
            }
        }
        
        for(var i = rows - 1; i >= 0; i--) {
            for (var j = cols - 1; j >= 1; j--) {
                if (matrix[i][0] == 0 || matrix[0][j] == 0) {
                    matrix[i][j] = 0;
                }
            }
            
            matrix[i][0] = col0 ? 0 : matrix[i][0];
        }
    }
}
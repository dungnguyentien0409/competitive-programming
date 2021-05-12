/*
 * Link: https://leetcode.com/problems/range-sum-query-2d-immutable/
 * Author: Dung Nguyen Tien (Chris)
*/
public class NumMatrix {
    int[][] sum;
    public NumMatrix(int[][] matrix) {
        int rows = matrix.Length, cols = matrix[0].Length;
        
        sum = new int[rows + 1][];
        for (var i = 0; i <= rows; i++) sum[i] = new int[cols + 1];
        
        for (var i = 1; i <= rows; i++) {
            for (var j = 1; j <= cols; j++) {
                sum[i][j] = matrix[i - 1][j - 1]
                    + sum[i - 1][j] + sum[i][j - 1] - sum[i - 1][j - 1];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        return sum[row2 + 1][col2 + 1] - sum[row2 + 1][col1] - sum[row1][col2 + 1]
            + sum[row1][col1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */
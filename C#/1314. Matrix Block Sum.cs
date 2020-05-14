/*
 * Link: https://leetcode.com/problems/matrix-block-sum/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[][] MatrixBlockSum(int[][] mat, int K) {
        int rows = mat.Length, cols = mat[0].Length;
        var sum = CreateSum(rows + 1, cols + 1);
        
        for(var i = 1; i <= rows; i++) {
            for (var j = 1; j <= cols; j++) {
                sum[i][j] = mat[i - 1][j - 1]
                    + sum[i - 1][j] + sum[i][j - 1]
                    - sum[i - 1][j - 1];
            }
        }
        
        WriteSum(sum);
        
        var res = CreateSum(rows, cols);
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                var il = i - K >= 0 ? i - K : 0;
                var jl = j - K >= 0 ? j - K : 0;
                var ir = i + K < rows ? i + K : rows - 1;
                var jr = j + K < cols ? j + K : cols - 1;
                
                res[i][j] = sum[ir + 1][jr + 1]
                    - sum[il][jr + 1] 
                    - sum[ir + 1][jl] 
                    + sum[il][jl];
            }
        }
        
        return res;
    }
    
    public int[][] CreateSum(int rows, int cols) {
        var sum = new int[rows][];
        
        for(var i = 0; i < rows; i++) {
            sum[i] = new int[cols];
        }
        
        return sum;
    }
    
    public void WriteSum(int[][] sum) {
        for (var i = 0; i < sum.Length; i++) {
            for (var j = 0; j < sum[0].Length; j++) {
                Console.Write(sum[i][j] + " ");
            }
            
            Console.WriteLine();
        }
    }
}
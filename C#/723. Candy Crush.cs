/*
 * Link: https://leetcode.com/problems/candy-crush/submissions/
 * Idea: kekzi
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[][] CandyCrush(int[][] board) {
        int rows = board.Length, cols = board[0].Length;
        bool found = true;
        
        while(found) {
            found = false;
            
            for (var i = 0; i < rows; i++) {
                for (var j = 0; j < cols; j++) {
                    int val = Math.Abs(board[i][j]);
                    
                    if (val == 0) continue;
                    
                    if (j < cols - 2 && Math.Abs(board[i][j + 1]) == val && Math.Abs(board[i][j + 2]) == val) {
                        found = true;
                        
                        int index = j;
                        while(index < cols && Math.Abs(board[i][index]) == val) board[i][index++] = -val;
                    }
                    
                    if (i < rows - 2 && Math.Abs(board[i + 1][j]) == val && Math.Abs(board[i + 2][j]) == val) {
                        found = true;
                        
                        int index = i;
                        while(index < rows && Math.Abs(board[index][j]) == val) board[index++][j] = -val;
                    }
                }
            }
            
            MoveDown(board, found);
        }
        
        return board;
    }
    
    public void MoveDown(int[][] board, bool found) {
        if (!found) return;
        
        int rows = board.Length, cols = board[0].Length;
        
        for (var j = 0; j < cols; j++) {
            var last = rows - 1;
            
            for (var i = rows - 1; i >= 0; i--) {
                if (board[i][j] > 0) {
                    board[last--][j] = board[i][j];
                }
            }
            
            for (var k = last; k >= 0; k--) board[k][j] = 0;
        }
    }
}
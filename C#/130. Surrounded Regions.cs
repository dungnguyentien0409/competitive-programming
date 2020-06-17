/*
 * Link: https://leetcode.com/problems/surrounded-regions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public void Solve(char[][] board) {
        if (board.Length == 0 || board[0].Length == 0) return;
        
        int rows = board.Length, cols = board[0].Length;
        
        for (var i = 0; i < rows; i++) {
            dfs(board, i, 0);
            dfs(board, i, cols - 1);
        }
        
        for (var j = 0; j < cols; j++) {
            dfs(board, 0, j);
            dfs(board, rows - 1, j);
        }
        
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                if (board[i][j] == 'Y') {
                    board[i][j] = 'O';
                }
                else if (board[i][j] == 'O') {
                    board[i][j] = 'X';
                }
            }
        }
    }
    
    public void dfs(char[][] board, int x, int y) {
        if (x < 0 || x >= board.Length
           || y < 0 || y >= board[0].Length
           || board[x][y] != 'O') return;
        
        board[x][y] = 'Y';
        dfs(board, x - 1, y);
        dfs(board, x + 1, y);
        dfs(board, x, y - 1);
        dfs(board, x, y + 1);
    }
}
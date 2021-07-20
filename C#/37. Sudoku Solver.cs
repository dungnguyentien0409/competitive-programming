public class Solution {   
    public void SolveSudoku(char[][] board) {
        Solve(board);
    }
    
    public bool Solve(char[][] board) {
        for (var i = 0; i < 9; i++) {
            for (var j = 0; j < 9; j++) {
                if (board[i][j] != '.') continue;
                
                for (var c = '1'; c <= '9'; c++) {
                    if (IsValid(board, i, j, c)) {
                        board[i][j] = c;
                        
                        if (Solve(board)) return true;
                        else board[i][j] = '.';
                    }
                }
                
                return false;
            }
        }
        
        return true;
    }
    
    public bool IsValid(char[][] board, int x, int y, char num) {
        for (var i = 0; i < 9; i++) {
        // check for the same row
        if (board[x][i] == num) return false;
        // check for the same col
        if (board[i][y] == num) return false;
        // check for the same block
        var xblockNo = 3 * (x / 3);
        var yblockNo = 3 * (y / 3);
        
        if (board[xblockNo + (i / 3)][yblockNo + i % 3] == num) return false;
    }
    
    return true;
    }
}
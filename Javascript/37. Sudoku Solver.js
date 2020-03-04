/**
 * Link: https://leetcode.com/problems/sudoku-solver/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {character[][]} board
 * @return {void} Do not return anything, modify board in-place instead.
 */
var solveSudoku = function(board) {
    if(board == null || board.length == 0)
        return;
    solve(board);
};

function solve(board) {
    for (var i = 0; i < board.length; i++) {
        for (var j = 0; j < board[0].length; j++) {
            if (board[i][j] == ".") {
                for (var num = "1"; num <= "9"; num++) {
                    if (isValid(board, i, j, num)) {
                        board[i][j] = num + "";
                        
                        if (solve(board)) return true;
                        else board[i][j] = "."
                    }
                }
                
                // cannot place any item from 1 to 9
                return false;
            }
        }
    }
    // the board is fulfil
    return true;
}

function isValid(board, row, col, num) {
    for (var i = 0; i < 9; i++) {
        // check for the same row
        if (board[row][i] == num) return false;
        // check for the same col
        if (board[i][col] == num) return false;
        // check for the same block
        var xblockNo = 3 * (Math.floor(row / 3));
        var yblockNo = 3 * (Math.floor(col / 3));
        
        if (board[xblockNo + Math.floor(i / 3)][yblockNo + i % 3] == num) return false;
    }
    
    return true;
}
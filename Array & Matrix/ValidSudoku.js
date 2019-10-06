/**
 * Problem: https://leetcode.com/problems/valid-sudoku/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {character[][]} board
 * @return {boolean}
 */
var isValidSudoku = function(board) {
    var row = {}; // from 0 to 8
    var col = {}; // from 0 to 8
    var block = {}; // left to right, top to down: 00 01 02, 10 11 12, 20 21 22
    
    var rows = board.length;
    var cols = board[0].length;
    
    for (var i = 0; i < rows; i++) {
        for (var j = 0; j < cols; j++) {
            if (board[i][j] != ".") {
                var number = board[i][j];  
                var blockKey = Math.floor(i/3) + "" + Math.floor(j/3);
                // if that number exist in row or col or block, return false
                if ((row[i] && row[i].indexOf(number) != -1)
                   || (col[j] && col[j].indexOf(number) != -1)
                   || (block[blockKey] && block[blockKey].indexOf(number) != -1)) {
                    return false;
                }
                
                //if not add it to row, col, block
                row[i] ? row[i].push(number) : row[i] = [number];
                col[j] ? col[j].push(number) : col[j] = [number];
                block[blockKey] ? block[blockKey].push(number) : block[blockKey] = [number];
            }
        }
    }
    
    return true;
};
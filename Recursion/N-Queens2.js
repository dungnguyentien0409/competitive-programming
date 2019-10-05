/**
 * Problem: https://leetcode.com/problems/n-queens-ii/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} n
 * @return {number}
 */
var totalNQueens = function(n) {
    // to check the col, and 2 diagonal is safe to place the queen
    var cols = Array(n).fill(true);
    var diagonals1 = Array(2*n).fill(true);
    var diagonals2 = Array(2*n).fill(true);
    
    count = 0;
    placeQueen(n, 0, cols, diagonals1, diagonals2);
    
    return count;
};

var count;
function placeQueen(n, row, cols, diagonals1, diagonals2) {
    if (n == row) return true;
    
    for (var col = 0; col < n; col++) {
        var isSafe = true;
        var d1 = row - col + n;
        var d2 = row + col;
        
        // check if safe to place the queen
        if (cols[col] == false
           || diagonals1[d1] == false
           || diagonals2[d2] == false){
            isSafe = false;
        }
        
        if (isSafe) {
            // if safe place the queen
            cols[col] = false;
            diagonals1[d1] = false;
            diagonals2[d2] = false;
            
            // check for the queen in the next row, until reach the last row
            if (placeQueen(n, row + 1, cols, diagonals1, diagonals2) == true) {
                ++count;
            }
            // take out the queen to try to put to the next col
            cols[col] = true;
            diagonals1[d1] = true;
            diagonals2[d2] = true;
        }
    }
    
    return false;
}
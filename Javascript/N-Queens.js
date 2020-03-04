/**
 * Problem: https://leetcode.com/problems/n-queens/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {number} n
 * @return {string[][]}
 */
var solveNQueens = function(n) {
    var queens = [];
    var solutions = [];
    var canPlace = placeTheQueenHelper(n, 0, queens, solutions);
    
    return builResult(n, solutions);
};

function placeTheQueenHelper(n, row, queens, solutions) {
    // if can put the queen in the row n - 1, mean put all the queen
    if (row == n) return true;
    
    //for each row, try to place queen in each col
    for (var col = 0; col < n; col++) {
        var canPlace = true;
        
        // check if can place in this col by going through all the queens has placed, can not in the same col, the same row, and diagonal: x - y, x + y
        for(var queen of queens) {
            if (queen[1] == col
               || queen[0] - queen[1] == row - col
               || queen[0] + queen[1] == row + col) {
                canPlace = false;
                break;
            }
        }
        
        if (canPlace) {
            // if can place, push the queen to list
            queens.push([row, col]);
            if (placeTheQueenHelper(n, row + 1, queens, solutions)) {
                solutions.push(queens.slice(0));
            }
            // pop the queen, try to put to the next column to find another solution
            queens.pop();
        }
    }
    
    return false;
}

function builResult(n, solutions) {
    var builtResult = [];
    
    for (var solution of solutions) {
        var board = Array(n).fill().map(() => Array(n).fill('.'));
        
        for(var position of solution) {
            board[position[0]][position[1]] = 'Q';
        }
        
        var convertedBoard = convertBoardToString(n, board);
        builtResult.push(convertedBoard);
    }
    
    return builtResult;
}

function convertBoardToString(n, board) {
    var str = [];
    
    for(var row of board) {
        str.push(row.join(''));
    }
    
    return str;
}
/**
 * Link: https://leetcode.com/problems/word-search/
 * Author: Dung Nguyen Tien (Chris)
 * @param {character[][]} board
 * @param {string} word
 * @return {boolean}
 */
var exist = function(board, word) {
    var dict = {};

    var rows = board.length;
    var cols = board[0].length;
    
    for (var i = 0; i < rows; i++) {
        for (var j = 0; j < cols; j++) {
            // for each word, use dfs to check
            if (check(board, word.slice(0), i, j) == true) return true;
        }
    }
    return false;
};

function check(board, word, x, y) {
    if (word.length == 0) return true;
    else if (x < 0 || x > board.length - 1 || y < 0 || y > board[0].length - 1 || board[x][y] == 0)
        return false;

    if (board[x][y] == word[0]) {
        var isValid = false;
        var c = word[0];
        // mark the word visited
        board[x][y] = 0;
        //go deeper
        isValid = isValid || check(board, word.slice(1), x - 1, y);
        isValid = isValid || check(board, word.slice(1), x + 1, y);
        isValid = isValid || check(board, word.slice(1), x, y + 1);
        isValid = isValid || check(board, word.slice(1), x, y - 1);
        // if that start is not correct, mark the word unvisit, to go with another start
        board[x][y] = c;

        if (isValid) return true;
    }
    
    return false;
}
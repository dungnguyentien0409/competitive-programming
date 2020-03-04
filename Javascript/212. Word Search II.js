/**
 * Link: https://leetcode.com/problems/word-search-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * @param {character[][]} board
 * @param {string[]} words
 * @return {string[]}
 */
var findWords = function(board, words) {
    var rows = board.length;
    var cols = board[0].length;
    var res = [];
    var abort = false;
    
    for (var word of words) {
        abort = false;
        // for each word, set abort = false to start finding in the board
        for (var i = 0; i < rows && !abort; i++) {
            for (var j = 0; j < cols; j++) {
                if (check(board, i, j, word)) {
                    // if can find, break both of 2 loop to stop finding in the board
                    res.push(word);
                    abort = true;
                    break;
                }
            }
        }
    }
    
    return res;
};

// dfs
function check(board, x, y, word) {
    if (word.length == 0) return true;
    else if (x < 0 || y < 0 || x > board.length - 1 || y > board[0].length - 1 || board[x][y] == 0) return false;
    
    if (board[x][y] == word[0]) {
        var isValid = false;
        var c = word[0];
        board[x][y] = 0;
        
        isValid = isValid || check(board, x - 1, y, word.slice(1));
        isValid = isValid || check(board, x + 1, y, word.slice(1));
        isValid = isValid || check(board, x, y - 1, word.slice(1));
        isValid = isValid || check(board, x, y + 1, word.slice(1));
        
        board[x][y] = c;
        if (isValid == true) return true;
    }
    
    return false;
}
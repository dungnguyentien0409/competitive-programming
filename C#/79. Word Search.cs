/*
 * Link: https://leetcode.com/problems/word-search/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool Exist(char[][] board, string word) {
        for (var i = 0; i < board.Length; i++) {
            for (var j = 0; j < board[0].Length; j++) {
                if (Check(board, word, 0, i, j)) {
                    return true;
                }
            }
        }
        
        return false;
    }
    
    public bool Check(char[][] board, string word, int pos, int x, int y) {
        if (pos == word.Length) return true;
        
        if (x < 0 || x >= board.Length || y < 0 || y >= board[0].Length
           || board[x][y] != word[pos])
            return false;
        
        var c = board[x][y];
        board[x][y] = '*';
        
        var check =  Check(board, word, pos + 1, x - 1, y)
            || Check(board, word, pos + 1, x + 1, y)
            || Check(board, word, pos + 1, x, y - 1)
            || Check(board, word, pos + 1, x, y + 1);
        
        board[x][y] = c;
        
        return check;
    }
}
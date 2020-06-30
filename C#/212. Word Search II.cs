/*
 * Link: https://leetcode.com/problems/word-search-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        var res = new List<string>();
        
        foreach(var w in words) {
            var found = false;
            
            for (var i = 0; i < board.Length && !found; i++) {
                for (var j = 0; j < board[0].Length && !found; j++) {
                    if (Check(board, w, 0, i, j)) {
                        res.Add(w);
                        found = true;
                    }
                }
            }
        }
        
        return res;
    }
    
    public bool Check(char[][] board, string w, int pos, int x, int y) {
        if (pos == w.Length) return true;
        
        if (x < 0 || x >= board.Length || y < 0 || y >= board[0].Length
           || board[x][y] != w[pos])
            return false;
        
        var c = board[x][y];
        board[x][y] = '*';
        
        var isValid = Check(board, w, pos + 1, x + 1, y)
            || Check(board, w, pos + 1, x - 1, y)
            || Check(board, w, pos + 1, x, y + 1)
            || Check(board, w, pos + 1, x, y - 1);
        
        board[x][y] = c;
        
        return isValid;
    }
}
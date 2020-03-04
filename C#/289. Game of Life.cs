/* 
 * Link: https://leetcode.com/problems/game-of-life/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public void GameOfLife(int[][] board) {
        // [2 bit, 1 bit]
        // 00, 10, 01, 11
        // we only change bit 2, so the bit 1 dont change
        if (board.Length == 0 || board[0].Length == 0) return;
        
        var rows = board.Length;
        var cols = board[0].Length;
        
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                var liveNeighbors = CountLiveNeighbor(board, i, j);
                // only care when second bit becomes 1
                if (board[i][j] == 0 && liveNeighbors == 3) {
                    board[i][j] = 2;
                }
                if (board[i][j] == 1 && liveNeighbors >= 2 && liveNeighbors <= 3) {
                    board[i][j] = 3;
                }
                // eles - bit 2 = 0
            }
        }

        // update to the second bi
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                board[i][j] >>= 1;            
            }
        }
    }
    
    public int CountLiveNeighbor(int[][] board, int x, int y) {
        var directions = new int[8][] {
            new int[2] { 0, 1 },
            new int[2] { 0, -1 },
            new int[2] { 1, 0 },
            new int[2] { -1, 0 },
            new int[2] { 1, 1 },
            new int[2] { -1, -1 },
            new int[2] { 1, -1 },
            new int[2] { -1, 1 }
        };
        var liveNeighbors = 0;
        
        foreach (var direction in directions) {
            var nX = x + direction[0];
            var nY = y + direction[1];
            
            // &1 to compare only bit 1
            // we only change bit 2
            if (nX >=0 && nX < board.Length
               && nY >= 0 && nY < board[0].Length
               && ((board[nX][nY] & 1) == 1))
                liveNeighbors++;
        }

        return liveNeighbors;
    }
}
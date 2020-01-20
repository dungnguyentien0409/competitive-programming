/* 
 * Link: https://leetcode.com/problems/rotting-oranges/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int OrangesRotting(int[][] grid) {
        if (grid.Length == 0 || grid[0].Length == 0) return 0;
        
        var fresh = CountFresh(grid);
        var minutes = Rotting(grid, fresh);
        
        return minutes;
    }
    
    public int Rotting(int[][] grid, int fresh) {
        int rows = grid.Length, cols = grid[0].Length;
        int[,] directions = new int[4, 2] {
            { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 }
        };
        int minutes = 0;
        var queue = InitiateRotten(grid);
        
        while(queue.Count > 0) {
            var n = queue.Count;
            var canRotten = false;
            
            for (var i = 0; i < n; i++) {
                var rotten = queue.Dequeue();
                
                for (var j = 0; j < directions.GetLength(0); j++) {
                    var nextX = rotten[0] + directions[j, 0];
                    var nextY = rotten[1] + directions[j, 1];
                    
                    if (nextX >= 0 && nextY >= 0 && nextX < rows && nextY < cols
                       && grid[nextX][nextY] == 1) {
                        grid[nextX][nextY] = 2;
                        queue.Enqueue(new int[2] { nextX, nextY });
                        canRotten = true;
                        fresh--;
                    }
                }
            }
            
            if (canRotten == true) {
                minutes++;
            }
        }
        
        if (fresh != 0) return -1;
        return minutes;
    }
    
    public Queue<int[]> InitiateRotten(int[][] grid) {
        var queue = new Queue<int[]>();
        int rows = grid.Length, cols = grid[0].Length;
        
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                if (grid[i][j] == 2) {
                    queue.Enqueue(new int[2] { i, j });
                }
            }
        }
        
        return queue;
    }
    
    public int CountFresh(int[][] grid) {
        int rows = grid.Length, cols = grid[0].Length;
        int fresh = 0;
        
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                if (grid[i][j] == 1) {
                    fresh++;
                }
            }
        }
        
        return fresh;
    }
}
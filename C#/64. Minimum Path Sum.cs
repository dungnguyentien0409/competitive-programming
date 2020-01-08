/*
 * Link: https://leetcode.com/problems/minimum-path-sum/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinPathSum(int[][] grid) {
        if (grid.Length == 0 || grid[0].Length == 0) return 0;
        var minSum = bfs(grid);
        
        return minSum;
    }
    
    public int bfs(int[][] grid) {
        int rows = grid.Length, cols = grid[0].Length;
        var trace = CreateTraceMap(grid);
        var directions = new int[2][] {
            new int[]{0, 1}, 
            new int[]{1, 0}
        };
        var queue = new Queue<int[]>();
        
        queue.Enqueue(new int[]{0, 0});
        trace[0][0] = grid[0][0];
        while(queue.Count > 0) {
            var node = queue.Dequeue();
            
            foreach(var dir in directions) {
                var nextX = node[0] + dir[0];
                var nextY = node[1] + dir[1];
                
                if (nextX >= rows || nextY >= cols) continue;
                
                var sum = trace[node[0]][node[1]] + grid[nextX][nextY];
                
                if (sum < trace[nextX][nextY]){
                    trace[nextX][nextY] = sum;
                    queue.Enqueue(new int[]{nextX, nextY});
                }
            }
        }
        
        return trace[rows - 1][cols - 1];
    }
    
    public int[][] CreateTraceMap(int[][] grid) {
        var trace = new int[grid.Length][];
        
        for (var i = 0; i < grid.Length; i++) {
            trace[i] = new int[grid[0].Length];
            Array.Fill(trace[i], Int32.MaxValue);
        }
        
        return trace;
    }
}
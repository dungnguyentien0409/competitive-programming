/*
 * Link: https://leetcode.com/problems/walls-and-gates/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public void WallsAndGates(int[][] rooms) {
        if (rooms.Length == 0 || rooms[0].Length == 0) return;
        
        int rows = rooms.Length, cols = rooms[0].Length;
        var queue = GetGate(rooms);
        var directions = new int[4, 2] {
            { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 }
        };
        
        while(queue.Count > 0) {
            var n = queue.Count;
            
            for (var i = 0; i < n; i++) {
                var current = queue.Dequeue();
                
                for(var j = 0; j < directions.GetLength(0); j++) {
                    var nextX = current[0] + directions[j, 0];
                    var nextY = current[1] + directions[j, 1];
                    var distance = rooms[current[0]][current[1]] + 1;
                    
                    if (nextX >= 0 && nextY >= 0 && nextX < rows && nextY < cols
                       && rooms[nextX][nextY] != - 1
                       && rooms[nextX][nextY] > distance) {
                        
                        rooms[nextX][nextY] = distance;
                        queue.Enqueue(new int[2] { nextX, nextY });
                    }
                }
            }
        }
    }
    
    public Queue<int[]> GetGate(int[][] rooms) {
        int rows = rooms.Length, cols = rooms[0].Length;
        var queue = new Queue<int[]>();
        
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                if (rooms[i][j] == 0) {
                    queue.Enqueue(new int[2] { i, j });
                }
            }
        }
        
        return queue;
    }
}
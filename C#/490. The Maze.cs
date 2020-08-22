/*
 * Link: https://leetcode.com/problems/the-maze/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    int[][] directions;
    public bool HasPath(int[][] maze, int[] start, int[] destination) {
        directions = new int[4][] {
            new int[2] { 1, 0 },
            new int[2] { -1, 0 },
            new int[2] { 0, 1 },
            new int[2] { 0, -1 }
        };
        var visited = new bool[maze.Length][];
        for (var i = 0; i < maze.Length; i++) {
            visited[i] = new bool[maze[0].Length];
            Array.Fill(visited[i], false);
        }
        
        return dfs(maze, start, destination, visited);
    }
    
    public bool dfs(int[][] maze, int[] current, int[] des, bool[][] visited) {
        int x = current[0], y = current[1];
        
        if (visited[x][y]) return false;
        if (x == des[0] && y == des[1]) return true;
        
        visited[x][y] = true;
        
        foreach(var d in directions) {
            x = current[0];
            y = current[1];
            
            while(IsValid(maze, x + d[0], y + d[1])) {
                x += d[0];
                y += d[1];
            }
            
            if (dfs(maze, new int[] { x, y }, des, visited)) return true;
        }
        
        return false;
    }
    
    public bool IsValid(int[][] maze, int x, int y) {
        if (x < 0 || y < 0 || x >= maze.Length || y >= maze[0].Length
           || maze[x][y] == 1)
            return false;
        
        return true;
    }
}
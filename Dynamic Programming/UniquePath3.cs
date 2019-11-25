/*
 * Problem: https://leetcode.com/problems/unique-paths-iii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int UniquePathsIII(int[][] grid) {
        var rows = grid.Length;
        var cols = grid[0].Length;
        var walk = 2;
        var start = new int[] { -1, -1 };
        var end = new int[] { -1, -1 };
        
        for (var i = 0; i < rows; i++) {
            for (var j = 0; j < cols; j++) {
                if (grid[i][j] == 1) start = new int[] { i, j };
                else if (grid[i][j] == 2) end = new int[] { i, j };
                else if (grid[i][j] == 0) walk++;
            }
        }
        
        var result = new List<List<int[]>>();
        var steps = new List<int[]>();
        steps.Add(start);
        
        DFS(grid, start, end, result, steps, walk);
        
        return result.Count;
    }
    
    public void DFS(int[][] grid, int[] current, int[] end, List<List<int[]>> result, List<int[]> steps, int walk) 
    {
        if (ComparePosition(current, end) && steps.Count == walk) {
            result.Add(new List<int[]>(steps));
            return;
        }
        
        var directions = new int[][] {
            new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 }
        };
        
        foreach(var d in directions) {
            var nextMove = new int[2];
            nextMove[0] = current[0] + d[0]; 
            nextMove[1] = current[1] + d[1];
            
            if (nextMove[0] < 0 || nextMove[0] >= grid.Length
               || nextMove[1] < 0 || nextMove[1] >= grid[0].Length
               || grid[nextMove[0]][nextMove[1]] == -1
               || steps.Any(step => ComparePosition(step, nextMove))) {
                continue;
            }
            
            steps.Add(nextMove);
            DFS(grid, nextMove, end, result, steps, walk);
            steps.RemoveAt(steps.Count - 1);
        }
    }
    
    public bool ComparePosition(int[] p1, int[] p2) {
        return p1[0] == p2[0] && p1[1] == p2[1];
    }
}
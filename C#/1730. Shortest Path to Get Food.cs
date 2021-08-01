public class Solution {
    int[][] dr;
    public int GetFood(char[][] grid) {
        dr = new int[4][] {
            new int[2] { 1, 0 }, new int[2] { -1, 0 }, new int [2] { 0, 1 }, new int[2] { 0, -1 }
        };
        
        int res = 0;
        var q = new Queue<int[]>();
        var start = GetStart(grid);
        var visited = new HashSet<string>();
        q.Enqueue(start);
        
        while(q.Count > 0) {
            var len = q.Count;
            
            for(var i = 0; i < len; i++) {
                var cur = q.Dequeue();
                
                if (grid[cur[0]][cur[1]] == '#') return res;
                
                foreach(var d in dr) {
                    int nextX = cur[0] + d[0], nextY = cur[1] + d[1];
                    
                    if (nextX < 0 || nextY < 0 || nextX >= grid.Length || nextY >= grid[0].Length
                        || grid[nextX][nextY] == 'X' || visited.Contains(nextX + "" + nextY)) continue;
                    
                    q.Enqueue(new int[2] { nextX, nextY });
                    visited.Add(nextX + "" + nextY);
                }
            }
            
            res++;
        }
        
        return -1;
    }
    
    public int[] GetStart(char[][] grid) {
        for (var i = 0; i < grid.Length; i++) {
            for (var j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == '*') return new int[2] { i, j };
            }
        }
        
        return new int[2] { 0, 0 };
    }
}
public class Solution {
    public int ShortestPath(int[][] grid, int k) {
        var q = new Queue<Node>();
        int m = grid.Length, n = grid[0].Length;
        int[][] directions = new int[4][]{ new int[2]{1, 0}, new int[2]{-1, 0}, new int[2]{0, 1}, new int[2]{0, -1}};
        int[][] visited = new int[m][];
        int step = 0;
        
        for(var i = 0; i < m; i++) {
            visited[i] = new int[n];
            Array.Fill(visited[i], Int32.MaxValue);
        }
        
        q.Enqueue(new Node(0, 0, 0));
        while(q.Count > 0) {
            int len = q.Count;
            
            
            for(var i = 0; i < len; i++) {
                var cur = q.Dequeue();
                
                if (cur.x == m - 1 && cur.y == n - 1) 
                    return step;
                
                foreach(var d in directions) {
                    int nx = cur.x + d[0];
                    int ny = cur.y + d[1];
                    
                    if (nx < 0 || ny < 0 || nx >= m || ny >= n) continue;
                    
                    int o = grid[nx][ny] + cur.o;
                    
                    if (o >= visited[nx][ny] || o > k) continue;
                    
                    visited[nx][ny] = o;
                    q.Enqueue(new Node(nx, ny, o));
                }
            }
            
            step++;
        }
        
        return -1;
    }
}

public class Node {
    public int x;
    public int y;
    public int o;
    
    public Node(int a, int b, int c) {
        x = a;
        y = b;
        o = c;
    }
}
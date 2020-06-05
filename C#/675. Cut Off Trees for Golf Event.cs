/*
 * Link: https://leetcode.com/problems/cut-off-trees-for-golf-event/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int CutOffTree(IList<IList<int>> forest) {
        var order = CustomList(forest);
        var directions = new int[4][] {
            new int[2] { 0, 1 },
            new int[2] { 0, -1 },
            new int[2] { 1, 0 },
            new int[2] { -1, 0 }
        };
        
        var start = new Node(0, 0, 0);
        var end = new Node();
        var res = 0;
        
        while(order.Count > 0) {
            end = order[0];
            order.RemoveAt(0);
            
            var steps = bfs(forest, directions, start, end);
            
            if (steps == -1) return -1;
            
            res += steps;
            
            start.x = end.x;
            start.y = end.y;
            start.height = end.height;
        }
        
        return res;
    }
    
    public int bfs(IList<IList<int>> forest, int[][] directions, Node start, Node end) {
        int rows = forest.Count, cols = forest[0].Count;
        var queue = new Queue<int[]>();
        var steps = 0;
        var visited = new bool[rows, cols];
        
        queue.Enqueue(new int[2] { start.x, start.y });
        visited[start.x, start.y] = true;
        while(queue.Count > 0) {
            var len = queue.Count;
            
            for (var i = 0; i < len; i++) {
                var pos = queue.Dequeue();
                if (pos[0] == end.x && pos[1] == end.y) return steps;
                
                foreach(var d in directions) {
                    int nX = pos[0] + d[0], nY = pos[1] + d[1];
                         
                    if (nX < 0 || nX >= rows || nY < 0 || nY >= cols
                       || forest[nX][nY] == 0 || visited[nX, nY]) continue;
                    
                    queue.Enqueue(new int[2] { nX, nY });
                    visited[nX, nY] = true;
                }
            }
            steps++;  
        }
        
        return -1;
    }
    
    public List<Node> CustomList(IList<IList<int>> forest) {
        var list = new List<Node>();
        
        for(var i = 0; i < forest.Count; i++) {
            for (var j = 0; j < forest[0].Count; j++) {
                if (forest[i][j] > 1) {
                    list.Add(new Node(i, j, forest[i][j]));
                }
            }
        }
        
        list.Sort(delegate(Node a, Node b) {
            return a.height - b.height;
        });
        
        return list;
    }
}

public class Node {
    public int x;
    public int y;
    public int height;
    
    public Node() {}
    public Node(int x, int y, int h) {
        this.x = x;
        this.y = y;
        this.height = h;
    }
}
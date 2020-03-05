/*
 * Link: https://leetcode.com/problems/number-of-connected-components-in-an-undirected-graph/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int CountComponents(int n, int[][] edges) {
        if (edges.Length == 0 || edges[0].Length == 0) return n;
        
        var map = CreateMap(n, edges);
        var visited = new HashSet<int>();
        var count = 0;
        
        for (var i = 0; i < n; i++) {
            if (!visited.Contains(i)) {
                visited.Add(i);
                
                dfs(map, visited, i);
                count++;
            }
        }
        
        return count;
    }
    
    public void dfs(List<IList<int>> map, HashSet<int> visited, int x) {
        foreach(var node in map[x]) {
            if (!visited.Contains(node)) {
                visited.Add(node);
                
                dfs(map, visited, node);
            }
        }
    }
    
    public List<IList<int>> CreateMap(int n, int[][] edges) {
        var map = new List<IList<int>>();
        
        for (var i = 0; i < n; i ++) {
            map.Add(new List<int>());
        }
        
        foreach(var edge in edges) {
            map[edge[0]].Add(edge[1]);
            map[edge[1]].Add(edge[0]);
        }
        
        return map;
    }
}
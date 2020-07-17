/*
 * Link: https://leetcode.com/problems/all-paths-from-source-to-target/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        var map = CreateMap(graph);
        var n = graph.Length;
        var visited = new HashSet<int>();
        var res = new List<IList<int>>();
        
        visited.Add(0);
        dfs(map, res, visited, 0, n - 1);
        
        return res;
    }
    
    public void dfs(Dictionary<int, List<int>> map, List<IList<int>> res, HashSet<int> visited, int current, int des) {
        if (current == des) {
            res.Add(new List<int>(visited));
            return;
        }
        
        foreach(var next in map[current]) {
            if (visited.Contains(next)) continue;
            
            visited.Add(next);
            dfs(map, res, visited, next, des);
            visited.Remove(next);
        }
    }
    
    public Dictionary<int, List<int>> CreateMap(int[][] graph) {
        var map = new Dictionary<int, List<int>>();
        
        for (var i = 0; i < graph.Length; i++) {
            map.Add(i, new List<int>(graph[i]));
        }
        
        return map;
    }
}
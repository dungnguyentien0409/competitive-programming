/*
 * Link: https://leetcode.com/problems/graph-valid-tree/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        /*
            To tell whether a graph is a valid tree, we have to:

            Make sure there is no cycle in the graph - this has to be a none-cyclic graph;
            Make sure every node is reached - this has to be a connected graph;
        */
        var map = CreateMap(n, edges);
        var visited = new bool[n];
        Array.Fill(visited, false);
        
        var check = dfs(map, visited, -1, 0);                
        if (check == false) return false;

        // not visit all vertex
        for (var i = 0; i < n; i++) {
            if (!visited[i]) return false;
        }
        
        return true;
    }
    
    public bool dfs(List<IList<int>> map, bool[] visited, int parent, int x) {
        visited[x] = true;
        
        foreach(var node in map[x]) {
            if (!visited[node]) {
                var check = dfs(map, visited, x, node);
                
                if (!check) return false;
            }
            else {
                if (node != parent) {
                    return false;
                }
            }
        }
        
        return true;
    }
    
    public List<IList<int>> CreateMap(int n, int[][] edges) {
        var map = new List<IList<int>>();
        
        for (var i = 0; i < n; i++) {
            map.Add(new List<int>());
        }
        
        foreach(var edge in edges) {
            map[edge[0]].Add(edge[1]);
            map[edge[1]].Add(edge[0]);
        }
        
        return map;
    }
}
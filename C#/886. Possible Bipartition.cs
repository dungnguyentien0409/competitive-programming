/*
 * Link: https://leetcode.com/problems/possible-bipartition/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool PossibleBipartition(int N, int[][] dislikes) {
        var visited = new int[N + 1];
        var map = BuildMap(N, dislikes);
        
        Array.Fill(visited, 0);
        for(var i = 1; i <= N; i++) {
            if (visited[i] == 0) {
                var check = dfs(i, map, visited, 1);
                
                if (check == false) {
                    return false;
                }
            }
        }
        
        return true;
    }
    
    public bool dfs(int pos, Dictionary<int, List<int>> map, int[] visited, int g) {
        visited[pos] = g;
        
        foreach(var next in map[pos]) {
            if (visited[next] == g) {
                return false;
            }
            else if (visited[next] == 0) {
                var check = dfs(next, map, visited, -g);
                
                if (check == false) {
                    return false;
                }
            }
        }

        return true;
    }
    
    public Dictionary<int, List<int>> BuildMap(int N, int[][] dislikes) {
        var map = new Dictionary<int, List<int>>();
        
        for (var i = 1; i <= N; i++) map.Add(i, new List<int>());
        
        foreach(var dislike in dislikes) {
            map[dislike[0]].Add(dislike[1]);
            map[dislike[1]].Add(dislike[0]);
        }
        
        return map;
    }
}
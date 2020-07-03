/*
 * https://leetcode.com/problems/friend-circles/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindCircleNum(int[][] M) {
        var N = M.Length;
        var count = 0;
        var visited = new bool[N];
        
        for (var i = 0; i < N; i++) {
            if (!visited[i]) {
                count++;
                dfs(M, i, N, visited);
            }
        }
        
        return count;
    }
    
    public void dfs(int[][] M, int current, int N, bool[] visited) {
        visited[current] = true;
        
        for (var i = 0; i < N; i++) {
            if (M[current][i] == 1) {
                M[current][i] = 0;
                dfs(M, i, N, visited);
            }
        }
    }
}
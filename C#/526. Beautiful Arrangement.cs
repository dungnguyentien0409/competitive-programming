/*
 * Link: https://leetcode.com/problems/beautiful-arrangement/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int CountArrangement(int n) {
        return Backtrack(1, n, new HashSet<int>());
    }
    
    public int Backtrack(int current, int n, HashSet<int> visited) {
        if (current == n + 1) return 1;
        
        int res = 0;
        for (var i = 1; i <= n; i++) {
            if (!visited.Contains(i) && (i % current == 0 || current % i == 0)) {
                visited.Add(i);
                res += Backtrack(current + 1, n, visited);
                visited.Remove(i);
            }
        }
        
        return res;
    }
}
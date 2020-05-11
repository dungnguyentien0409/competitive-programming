/*
 * Link: https://leetcode.com/problems/jump-game-iii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool CanReach(int[] arr, int start) {
        var visited = new HashSet<int>();
        
        var res = backtrack(arr, start, visited);
        
        return res;
    }
    
    public bool backtrack(int[] arr, int pos, HashSet<int> visited) {
        //Console.WriteLine(pos);
        if (pos < 0 || pos >= arr.Length || visited.Contains(pos)) return false;
        
        if (arr[pos] == 0) return true;
        
        var jump1 = pos + arr[pos];
        var jump2 = pos - arr[pos];
        var res = false;
        
        visited.Add(pos);
        res = backtrack(arr, jump1, visited)
            || backtrack(arr, jump2, visited);
        visited.Remove(pos);
        
        return res;
    }
}
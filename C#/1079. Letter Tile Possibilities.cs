/*
 * Link: https://leetcode.com/problems/letter-tile-possibilities/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumTilePossibilities(string tiles) {
        var count = new int[26];
        
        foreach(var c in tiles) count[c - 'A']++;
        
        return dfs(count);
    }
    
    public int dfs(int[] arr) {
        int sum = 0;
        
        for (var i = 0; i < 26; i++) {
            if(arr[i] == 0) continue;
            sum++;
            
            arr[i]--;
            sum += dfs(arr);
            arr[i]++;
        }
        
        return sum;
    }
}
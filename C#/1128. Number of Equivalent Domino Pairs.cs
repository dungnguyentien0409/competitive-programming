/*
 * Link: https://leetcode.com/problems/number-of-equivalent-domino-pairs/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumEquivDominoPairs(int[][] dominoes) {
        var map = new Dictionary<string, int>();
        var count = 0;
        
        foreach(var domino in dominoes) {
            var a = domino[0];
            var b = domino[1];
            var k = Math.Min(a, b) + "-" + Math.Max(a, b);
            
            if (!map.ContainsKey(k)) {
                map.Add(k, 0);
            }
            
            map[k]++;
        }
        
        foreach(var v in map.Values.ToList()) {
            count += v * (v - 1) / 2;
        }
        
        return count;
    }
}
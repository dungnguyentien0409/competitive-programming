/*
 * Link: https://leetcode.com/problems/longest-harmonious-subsequence/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindLHS(int[] nums) {
        var map = new Dictionary<int, int>();
        
        foreach(var n in nums) {
            if (!map.ContainsKey(n)) map.Add(n, 0);
            
            map[n]++;
        }
        
        int max = 0;
        foreach(var k in map.Keys.ToList()) {
            if (map.ContainsKey(k + 1)) {
                max = Math.Max(max, map[k] + map[k + 1]);
            }
        }
        
        return max;
    }
}
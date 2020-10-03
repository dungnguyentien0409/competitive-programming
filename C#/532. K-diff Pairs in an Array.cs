/*
 * Link: https://leetcode.com/problems/k-diff-pairs-in-an-array/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindPairs(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        int res = 0;
        
        foreach(var n in nums) {
            if (!map.ContainsKey(n)) map.Add(n, 0);
            map[n]++;
        }
        
        foreach(var key in map.Keys.ToList()) {
            if (k == 0 && map[key] >= 2 || k > 0 && map.ContainsKey(key - k)) {
                res += 1;
            }
        }
        
        return res;
    }
}
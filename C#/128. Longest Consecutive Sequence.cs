/*
 * Link: https://leetcode.com/problems/longest-consecutive-sequence/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LongestConsecutive(int[] nums) {
        int longest = 0;
        var map = new Dictionary<int, int>();
        
        foreach(var n in nums) {
            if (!map.ContainsKey(n)) {
                var left = map.GetValueOrDefault(n - 1);
                var right = map.GetValueOrDefault(n + 1);
                var length = left + right + 1;
                
                longest = Math.Max(longest, length);
                
                map[n] = length;
                map[n - left] = length;
                map[n + right] = length;
            }
        }
        
        return longest;
    }
}
/*
 * Link: https://leetcode.com/problems/remove-covered-intervals/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
        if (intervals.Length <= 1) return intervals.Length;
        
        Array.Sort(intervals, delegate(int[] a, int[] b) {
            if (a[0] == b[0]) return b[1] - a[1];
            
            return a[0] - b[0];
        });
        
        int res = intervals.Length;
        
        var last = intervals[0];
        for(var i = 1; i < intervals.Length; i++) {
            var curr = intervals[i];
            
            if (curr[0] >= last[0] && curr[1] <= last[1]) res--;
            
            if (curr[1] > last[1]) last = curr;
        }
        
        return res;
    }
}
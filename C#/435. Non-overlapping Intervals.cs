/*
 * Link: https://leetcode.com/problems/non-overlapping-intervals/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        if (intervals.Length <= 1) return 0;
        
        Array.Sort(intervals, delegate(int[] a, int[] b) {
            return a[1] - b[1];
        });
        
        var last = intervals[0];
        var count = 1;
        
        for (var i = 1; i < intervals.Length; i++) {
            var current = intervals[i];
            
            if (current[0] >= last[1]) {
                count++;;
                last = current;
            }
        }
        
        return intervals.Length - count;
    }
}
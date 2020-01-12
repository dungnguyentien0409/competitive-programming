/*
 * Link: https://leetcode.com/problems/merge-intervals/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length <= 1) return intervals;
        
        Array.Sort(intervals, delegate(int[] a, int[] b) {
            if (a[0] == b[0]) return a[1] - b[1];
            
            return a[0] - b[0];
        });
            
        var res = new List<int[]>();
        
        res.Add(intervals[0]);
        for(var i = 1; i < intervals.Length; i++) {
            var current = intervals[i];
            var prev = res[res.Count - 1];
            res.RemoveAt(res.Count - 1);
            
            if(prev[1] >= current[0]) {
                var start = Math.Min(prev[0], current[0]);
                var end = Math.Max(prev[1], current[1]);
                res.Add(new int[2] {start, end});
            }
            else {
                res.Add(prev);
                res.Add(current);
            }
        }
        
        return res.ToArray();
    }
}
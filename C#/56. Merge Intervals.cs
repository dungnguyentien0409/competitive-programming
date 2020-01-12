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
        foreach(var interval in intervals) {
            if (res.Count == 0) {
                res.Add(interval);
            }
            else {
                while(res.Count > 0 && res[res.Count - 1][1] >= interval[0]) {
                    var last = res[res.Count - 1];
                    
                    interval[0] = Math.Min(interval[0], last[0]);
                    interval[1] = Math.Max(interval[1], last[1]);
                    res.RemoveAt(res.Count - 1);
                }
                
                res.Add(interval);
            }
        }
        
        return res.ToArray();
    }
}
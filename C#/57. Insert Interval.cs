/*
 * Link: https://leetcode.com/problems/insert-interval/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        if (intervals.Length == 0) return new int[][] { newInterval };
        
        var newI = newInterval;
        var res = new List<int[]>();
        
        foreach(var it in intervals) {
            if(it[1] < newI[0]) {
                res.Add(it);
            }
            else if (newI[1] < it[0]) {
                res.Add(newI);
                newI = it;
            }
            else {
                newI[0] = Math.Min(newI[0], it[0]);
                newI[1] = Math.Max(newI[1], it[1]);
            }
        }
        res.Add(newI);
        
        return res.ToArray();
    }
}
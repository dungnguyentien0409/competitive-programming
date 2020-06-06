/*
 * Link: https://leetcode.com/problems/queue-reconstruction-by-height/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[][] ReconstructQueue(int[][] people) {
        Array.Sort(people, delegate(int[] a, int[] b) {
            if (a[0] == b[0]) return a[1] - b[1];
            
            return b[0] - a[0];
        });
            
        var res = new List<int[]>();
        
        foreach(var p in people) {
            var index = p[1];
            
            res.Insert(index, p);
        }
        
        return res.ToArray();
    }
}
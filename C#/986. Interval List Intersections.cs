/*
 * Link: https://leetcode.com/problems/interval-list-intersections/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[][] IntervalIntersection(int[][] A, int[][] B) {
        int ia = 0, ib = 0;
        var res = new List<int[]>();
        
        while(ia < A.Length && ib < B.Length) {
            int[] a = A[ia], b = B[ib];
            
            var startMax = Math.Max(a[0], b[0]);
            var endMin = Math.Min(a[1], b[1]);
            
            if (startMax <= endMin) {
                res.Add(new int[2] { startMax, endMin });
            }
            
            if (a[1] == endMin) ia++;
            if (b[1] == endMin) ib++;
        }
        
        return res.ToArray();
    }
}